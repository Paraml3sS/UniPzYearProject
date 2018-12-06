using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dal.Enums;
using Dal.Extensions;

namespace Dal.Abstract
{
    public abstract class Repository<TEntity> : IDisposable
        where TEntity : class, new()

    {
        protected DbConnectionFactory DbConnectionFactory { get; }
        protected DbContext DbContext { get; }


        protected string tEntityName => typeof(TEntity).Name;
        protected string tableName => $"tbl{tEntityName}";


        public Repository()
        {
            DbConnectionFactory = new DbConnectionFactory();
            DbContext = new DbContext(DbConnectionFactory);
        }

        protected IEnumerable<TEntity> Execute(IDbCommand command)
        {
            try
            {
                using (var record = command.ExecuteReader())
                {
                    List<TEntity> items = new List<TEntity>();
                    while (record.Read())
                    {
                        items.Add(Map(record));
                    }
                    return items;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        protected TEntity Map(IDataRecord record)
        {
            var objT = Activator.CreateInstance<TEntity>();
            foreach (var property in typeof(TEntity).GetProperties())
            {
                if (record.HasColumn(property.Name) && !record.IsDBNull(record.GetOrdinal(property.Name)))
                    property.SetValue(objT, record[property.Name]);
            }
            return objT;
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }


        protected Dictionary<string, object> NameValuePropertyPairs(TEntity entity, PropertySkip propertyToSkip) {
            var properties = typeof(TEntity).GetProperties();

            switch (propertyToSkip)
            {
                case PropertySkip.None:
                    return properties                                                       // Collection initializing not gonna work !!!!   
                        .ToDictionary(prop => prop.Name, prop => prop.GetValue(entity));

                case PropertySkip.PrimaryKey:
                    return properties.Where(prop => prop.Name != $"{tEntityName}Id").ToDictionary(prop => prop.Name, prop => prop.GetValue(entity));

                default:
                    throw new Exception();                                                  // Create exception !!!!
            }
        }

        protected virtual void IdCommandParameters(IDbCommand command, long id)
        {
            command.AddParameter($"@{tEntityName}Id", id);
        }

        protected virtual void CommandParameters(IDbCommand command, TEntity entity, PropertySkip propertyToSkip)
        {
            var propPairs = NameValuePropertyPairs(entity, propertyToSkip);

            foreach (var prop in propPairs)
            {
                command.AddParameter($"@{prop.Key}", prop.Value);
            }
        }

        protected virtual List<string> GenerateCommandInputStrings(TEntity entity, Operation operation, PropertySkip propertyToSkip)
        {
            var propPairs = NameValuePropertyPairs(entity, propertyToSkip);

            switch (operation)
            {
                case Operation.Create:
                    return GenerateCreateInputStrings();
                case Operation.Update:
                    return GenerateUpdateInputStrings();
                default:
                    throw new Exception();                                                  // Create exception !!!!
            }

            List<string> GenerateCreateInputStrings() {
                StringBuilder columnsBuilder = new StringBuilder();
                StringBuilder valuesBuilder = new StringBuilder();

                foreach (var kvp in propPairs)
                {
                    columnsBuilder.Append($"{kvp.Key},");
                    valuesBuilder.Append($"@{kvp.Key},");
                }
                columnsBuilder.Remove(columnsBuilder.Length - 1, 1);
                valuesBuilder.Remove(valuesBuilder.Length - 1, 1);

                return new List<string>() { columnsBuilder.ToString(), valuesBuilder.ToString()};
            }

            List<string> GenerateUpdateInputStrings()
            {
                StringBuilder colValsBuilder = new StringBuilder();

                foreach (var kvp in propPairs)
                {
                    colValsBuilder.Append($"{kvp.Key}=@{kvp.Key},");
                }
                colValsBuilder.Remove(colValsBuilder.Length - 1, 1);

                return new List<string>() { colValsBuilder.ToString() };
            }
        }
    }
}

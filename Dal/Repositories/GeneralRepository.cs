using System.Collections.Generic;
using System.Linq;
using Dal.Abstract;
using Dal.Enums;
using Dal.Interfaces;

namespace Dal.Repositories
{
    public class GeneralRepository<TEntity> : Repository<TEntity>, IGeneralRepository<TEntity> where TEntity : class, new()
    {

        public GeneralRepository() : base()
        {
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var command = DbContext.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {tableName}";
                return this.Execute(command).ToList();
            }
        }

        public IEnumerable<TEntity> GetAll(string condition)
        {
            using (var command = DbContext.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {tableName} WHERE {condition}";
                return this.Execute(command).ToList();
            }
        }

        public TEntity Get(long id)
        {
            using (var command = DbContext.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {tableName} WHERE {tEntityName}Id = @{tEntityName}Id";
                IdCommandParameters(command, id);
                
                return this.Execute(command).FirstOrDefault();
            }
        }

        public TEntity Create(TEntity entity)
        {
            using (var command = DbContext.CreateCommand())
            {
                var colVals = GenerateCommandInputStrings(entity, Operation.Create, PropertySkip.PrimaryKey);
                command.CommandText = $"INSERT INTO {tableName} ({colVals[0]}) VALUES ({colVals[1]})";
                CommandParameters(command, entity, PropertySkip.PrimaryKey);

                return this.Execute(command).FirstOrDefault();
            }
        }

        public TEntity Update(long id, TEntity entity)
        {
            using (var command = DbContext.CreateCommand())
            {
                var colVals = GenerateCommandInputStrings(entity, Operation.Update, PropertySkip.PrimaryKey);
                command.CommandText = $"UPDATE {tableName} SET {colVals[0]} WHERE {tEntityName}Id = '{id}'";
                CommandParameters(command, entity, PropertySkip.PrimaryKey);
                IdCommandParameters(command, id);

                return this.Execute(command).FirstOrDefault();
            }
        }

        public TEntity Delete(long id)
        {
            using (var command = DbContext.CreateCommand())
            {
                command.CommandText = $"DELETE FROM {tableName} WHERE {tEntityName}Id = @{tEntityName}Id";
                IdCommandParameters(command, id);

                return this.Execute(command).FirstOrDefault();
            }
        }

        public IEnumerable<TEntity> Delete(string condition)
        {
            using (var command = DbContext.CreateCommand())
            {
                command.CommandText = $"DELETE FROM {tableName} WHERE {condition}";
                return this.Execute(command).ToList();
            }
        }
    }
}

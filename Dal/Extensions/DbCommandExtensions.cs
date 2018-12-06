using System;
using System.Data;

namespace Dal.Extensions
{
    public static class DbCommandExtensions
    {
        public static void AddParameter(this IDbCommand command, string name, object value)
        {
            if (command == null) throw new ArgumentNullException($"IDbCommand input: {command}");
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException($"Wrong name input: {name}");

            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }
    }
}

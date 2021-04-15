using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLSPExecutor.Core
{
    public static class SPExecutorService
    {
        public static IDataReader Execute(this IDbConnection connection, string database, string procedureName, params SqlParameter[] parameters)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            connection.ChangeDatabase(database);
            using var command = connection.CreateCommand();
            command.CommandText = procedureName;
            command.CommandType = CommandType.StoredProcedure;
            foreach (var param in parameters)
            {
                command.Parameters.Add(param);
            }

            return command.ExecuteReader();
        }
    }
}

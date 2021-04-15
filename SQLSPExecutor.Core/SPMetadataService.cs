using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLSPExecutor.Core
{
    public static class SPMetadataService
    {
        const string DatabasesQuery = @"SELECT name FROM sys.databases;";
        const string ProceduresQuery = @"SELECT SPECIFIC_CATALOG, SPECIFIC_SCHEMA, SPECIFIC_NAME
  FROM information_schema.routines
  WHERE ROUTINE_TYPE = 'PROCEDURE'";
        public static IEnumerable<string> GetDatabases(this IDbConnection connection)
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = DatabasesQuery;
            using var result = command.ExecuteReader();

            while (result.Read())
            {
                yield return result.GetString(0);
            }
            
        }

        public static IEnumerable<string> GetProcedures(this IDbConnection connection, string database)
        {
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            connection.ChangeDatabase(database);
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = ProceduresQuery;

            using var result = command.ExecuteReader();

            while (result.Read())
            {
                yield return $"{result.GetString(1)}.{result.GetString(2)}";
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient; // NuGet: System.Data.SqlClient (or Microsoft.Data.SqlClient)

namespace StudentManagementSystem.Core.Data
{
    /// <summary>
    /// SINGLE shared entry point for all database access.
    /// Every member calls into THIS class rather than writing their own
    /// SqlConnection code, so the whole team uses one consistent pattern.
    ///
    /// TODO (team decision): swap out for Entity Framework DbContext if you
    /// decide to go that route instead of raw ADO.NET - just keep the same
    /// method names so nobody's calling code has to change much.
    /// </summary>
    public static class DatabaseHelper
    {
        // TODO: move this to a config file (App.config / appsettings.json) - never hardcode in real submissions
        private static readonly string ConnectionString =
            "Server=localhost;Database=StudentManagementDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        /// <summary>For INSERT / UPDATE / DELETE. Returns rows affected.</summary>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>For SELECT queries. Returns a DataTable the calling form can bind to a grid.</summary>
        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                var table = new DataTable();
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
                return table;
            }
        }

        /// <summary>For SELECT returning a single value (e.g. COUNT, or one field).</summary>
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }
    }
}

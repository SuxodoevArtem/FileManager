using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace file_manager_back.Data
{
    public static class ConnectionProvider
    {
    
        public static NpgsqlConnection npgsqlConnection;
        public static void Connect(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(connectionString));

            npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
        }


    }
}

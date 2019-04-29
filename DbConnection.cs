using System;

namespace PropertyDemo
{
    public class DbCommand
    {
        public DbConnection Connection { get; private set; }
        public string Query { get; set; }

        public DbCommand(DbConnection connection, string query)
        {
            if (connection is null || string.IsNullOrWhiteSpace(query))
                throw new ArgumentNullException();

            Connection = connection;
            Query = query;
        }   

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("Run Query String: {0}", Query);
            Connection.Close();
        }
    }
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException();

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}

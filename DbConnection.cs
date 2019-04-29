using System;

namespace PropertyDemo
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException();

            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}

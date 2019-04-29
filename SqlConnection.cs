using System;

namespace PropertyDemo
{
    public class SqlConnection : DbConnection
    {
        private readonly string _connectionString;

        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Close()
        {
            Console.WriteLine("Close the Sql Server database connection");
        }

        public override void Open()
        {
            Console.WriteLine("Open the Sql Server database connection");
        }
    }
}

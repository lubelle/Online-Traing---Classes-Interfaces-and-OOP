using System;

namespace PropertyDemo
{
    public class OracleConnection : DbConnection
    {
        private readonly string _connectionString;

        public OracleConnection(string connectionString) 
            : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Close()
        {
            Console.WriteLine("Close Oracle database connection");
        }

        public override void Open()
        {
            Console.WriteLine("Open Oracle database connection");
        }
    }
}

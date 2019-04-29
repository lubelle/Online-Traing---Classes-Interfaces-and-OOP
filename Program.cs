using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConn = new SqlConnection("sql server database url");
            var oracleConn = new OracleConnection("oracle database url");

            sqlConn.Open();
            // DbSet ds = queryResult;
            sqlConn.Close();

            oracleConn.Open();
            // query result;
            oracleConn.Close();

            Console.ReadLine();

        }
    }
}

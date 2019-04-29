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

            var command = new DbCommand(oracleConn, "Select * from Customer");
            command.Execute();

            Console.ReadLine();

        }
    }
}

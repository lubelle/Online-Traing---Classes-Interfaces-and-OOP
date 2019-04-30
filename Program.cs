using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace PropertyDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();

            for (var i = 0; i < 3; i++)
            {
                watch.Start();
                Thread.Sleep(i + 2000);
                watch.Stop();

                Console.WriteLine("Duration: {0}", watch.GetDuration());
                Console.WriteLine("Press enter to run the stopwatch again");
                Console.ReadLine();
            }

            //var sqlConn = new SqlConnection("sql server database url");
            //var oracleConn = new OracleConnection("oracle database url");

            //var command = new DbCommand(oracleConn, "Select * from Customer");
            //command.Execute();

            //Console.ReadLine();

        }
    }
}

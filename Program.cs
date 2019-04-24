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
            Console.WriteLine("Enter S to Start; Enter P to Stop ");
            var watch = Console.ReadLine();

            while( watch.Equals("S", StringComparison.CurrentCultureIgnoreCase) ||
                   watch.Equals("P", StringComparison.CurrentCultureIgnoreCase))
            {
                var newWatch = new Stopwatch(new DateTime());
                switch (watch)
                {
                    case "S":
                    case "s":
                        newWatch = new Stopwatch(new DateTime());
                        break;
                    case "P":
                    case "p":
                        var duration = newWatch.Stop;
                        Console.WriteLine("Duration: {0}", duration );
                        break;
                    default:
                        break;
                }
                watch = Console.ReadLine();
            }
        }
    }
}

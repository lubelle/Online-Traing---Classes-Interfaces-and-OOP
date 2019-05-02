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
            var post = new Post();
            Console.WriteLine("post created at {0} and the vote count is {1}",post.Created, post.Vote);

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            Console.WriteLine("post created at {0} and the vote count is {1}", post.Created, post.Vote);

            post.DownVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine("post created at {0} and the vote count is {1}", post.Created, post.Vote);

            Console.ReadLine();
            //var cookie = new HttpCookie();
            //cookie["name"] = "John";
            //Console.WriteLine(cookie["name"]);
            //Console.ReadLine();

            //var person = new Person(new DateTime(1998, 1, 1));

            //Console.WriteLine("Birth Date: {0}", person.Age);

            //Console.ReadLine();
            //var workflow = new WorkFlow();
            //workflow.Add(new UploadVideoTask());
            //workflow.Add(new CallVideoEncodeingAPI());
            //workflow.Add(new EmailNotificationOnProcessingStatus());
            //workflow.Add(new PersistProcessingStatusToDB());

            //var engine = new WorkFlowEngine();
            //engine.Run(workflow);

            //Console.ReadLine();

            // Design for Stack
            //var stack = new Stack();
            //for (var i = 0; i < 5; i++)
            //{
            //    stack.Push(i);
            //}

            //stack.Clear();

            //for (var i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Pop from the stack: {0}", stack.Pop());
            //}

            //Console.ReadLine();


            // Design for Stopwatch
            //var watch = new Stopwatch();

            //for (var i = 0; i < 2; i++)
            //{
            //    watch.Start();
            //    Thread.Sleep(i + 2000);
            //    watch.Stop();

            //    Console.WriteLine("Duration: {0}", watch.GetDuration());
            //    Console.WriteLine("Press enter to run the stopwatch again");
            //    Console.ReadLine();
            //}

            //var sqlConn = new SqlConnection("sql server database url");
            //var oracleConn = new OracleConnection("oracle database url");

            //var command = new DbCommand(oracleConn, "Select * from Customer");
            //command.Execute();

            //Console.ReadLine();

        }
    }
}

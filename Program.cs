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
            var post = new Post(10);
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();


            Console.WriteLine("Vote count: {0}", post.Vote);
            Console.ReadLine();
        }
    }
}

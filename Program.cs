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
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Clear();

            stack.Push(4);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadLine();

        }
    }
}

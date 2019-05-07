using System;

namespace PropertyDemo
{
    public class CallVideoEncodeingAPI : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling video encoding api ...");
        }
    }
}

using System;

namespace PropertyDemo
{
    public class PersistProcessingStatusToDB : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Updating the status field to processing ...");
        }
    }
}

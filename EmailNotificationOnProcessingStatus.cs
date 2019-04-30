using System;

namespace PropertyDemo
{
    public class EmailNotificationOnProcessingStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending email notification to video owner ...");
        }
    }
}

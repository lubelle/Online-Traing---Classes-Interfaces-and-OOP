using System;

namespace PropertyDemo
{
    public class UploadVideoTask : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video to a cloud storage...");
        }
    }
}

using System;
using System.IO;

namespace PropertyDemo
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        // StreamWriter uses a file resource. File resource is not managed by CLR. 
        // We need to dispose the resouce once we finish using that. 
        // The easiest way to do that is to wrap the block in a using statement.
        // If a exception is thrown, the compiler will close the file handler by calling 
        // the Dispose() on the StreamWriter
        // compiler includes a call to the the dispose() automatically with the using block
        
        public void LogError(string message)
        {
            Log(message, MessageType.ERROR);
        }

        public void LogInfo(string message)
        {
            Log(message, MessageType.INFO);
        }

        private void Log(string message, Enum messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}

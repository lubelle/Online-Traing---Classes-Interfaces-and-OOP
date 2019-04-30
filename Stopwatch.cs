using System;

namespace PropertyDemo
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Watch is still running ...");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Start the watch first!");

            _stopTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan GetDuration()
        {
            return _stopTime - _startTime;
        }
        
    }
}

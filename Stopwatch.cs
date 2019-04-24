using System;

namespace PropertyDemo
{
    public class Stopwatch
    {
        public DateTime Start { get; private set; }


        public Stopwatch(DateTime datetime)
        {
            Start = datetime;
        }

        public int Stop
        {
            get
            {
                var duration = DateTime.Now - Start;
                return duration.Seconds;
            }
        }
        
    }
}

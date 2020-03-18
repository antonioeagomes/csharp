using System;

namespace CSharp.Classes
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool hasStarted;
        public void Start()
        {
            if (hasStarted)
                throw new InvalidOperationException("This stopwatch is already running!");
            
            _start = DateTime.Now;
            hasStarted = true;
        }

        public void Stop() {
            _stop = DateTime.Now;
            hasStarted = false;
         }

        public TimeSpan Duration() 
        { 
            if (_start > _stop)
                throw new InvalidOperationException("This stopwatch hasn't started or stopped yet");

            return (_stop - _start);
        }
    }
}
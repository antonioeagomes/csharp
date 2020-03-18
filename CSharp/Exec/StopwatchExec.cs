using System;
using System.Threading;
using CSharp.Classes;

namespace CSharp.Exec
{
    public class StopwatchExec : IExecutable
    {
        public void Execute()
        {
            try
            {
                var sw = new Stopwatch();
                HappyPath(sw);
                StartingTwice(sw);
                NotStartedOrStopped(sw);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void HappyPath(Stopwatch sw)
        {
            sw.Start();
            Thread.Sleep(3000);
            sw.Stop();
            Console.WriteLine($"Duration: {sw.Duration().ToString()}");
        }

        public void StartingTwice(Stopwatch sw)
        {
            sw.Start();
            sw.Start();
            /* Not started or stopped */
            Console.WriteLine($"Duration: {sw.Duration().ToString()}");
        }
        public void NotStartedOrStopped(Stopwatch sw)
        {
            sw.Start();
            /* Not started or stopped */
            Console.WriteLine($"Duration: {sw.Duration().ToString()}");
        }

    }
}
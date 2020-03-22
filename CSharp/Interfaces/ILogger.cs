using System;

namespace CSharp.Interfaces
{
    public interface ILogger
    {
         void LogError(string message);
         void LogInfo(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {message}");
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"INFO: {message}");
        }
    }
}
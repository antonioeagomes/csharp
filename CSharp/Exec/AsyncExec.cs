using CSharp.Async;

namespace CSharp.Exec
{
    public class AsyncExec : IExecutable
    {
        public void Execute()
        {
            var window = new MainWindow();

            window.ButtonClick();

            window.ButtonClickAsync();
        }
    }
}
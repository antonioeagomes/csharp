using CSharp.Inheritance;

namespace CSharp.Exec
{
    public class CompositionExec : IExecutable
    {
        public void Execute()
        {
            var service = new Service(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            service.Start();
            installer.Install();

        }
    }
}
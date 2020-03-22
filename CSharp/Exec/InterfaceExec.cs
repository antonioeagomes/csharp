using CSharp.Interfaces;

namespace CSharp.Exec
{
    public class InterfaceExec : IExecutable
    {
        public void Execute()
        {
            UseILogger();
        }

        public void UseILogger()
        {
            var dbmigrator = new DBMigrator(new ConsoleLogger());
            dbmigrator.Migrate();
        }
    }
}
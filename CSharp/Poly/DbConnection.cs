using System;

namespace CSharp.Poly
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("You must provide a Connecdtion String");
            }
            _connectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }

    public class SQLServerConnection : DbConnection
    {
        public SQLServerConnection(string connectionString) : base(connectionString){ }

        public override void Close()
        {
            Console.WriteLine("SQL Server closed this connection!");
        }

        public override void Open()
        {
            Console.WriteLine("SQL Server Connection is open");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString){ }

        public override void Close()
        {
            Console.WriteLine("ORACLE: CLOSED");
        }

        public override void Open()
        {
            Console.WriteLine("ORACLE: OPEN");
        }
    }

}
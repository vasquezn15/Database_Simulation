using System;

namespace Ex1_DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new NullReferenceException("Connection string cannot be empty");
            }
            else
            {
                ConnectionString = connectionString;
            }
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection is closed");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection is closed");
        }
    }
}

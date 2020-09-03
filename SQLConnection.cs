using System;

namespace Ex1_DatabaseConnection
{
    public class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString) : base(connectionString)
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
            Console.WriteLine("SQL Connection is closed");
        }

        public override void Open()
        {
            Console.WriteLine("SQL Connection is open");
        }
    }
}

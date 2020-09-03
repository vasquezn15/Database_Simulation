using System;

namespace Ex1_DatabaseConnection
{
    public abstract class DbConnection
    {      
        public string ConnectionString{ get; set; }
        public TimeSpan TimeOut { get; set; }
    
        public DbConnection(string connectionString)
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

        public abstract void Open();
        public abstract void Close();          
    }
}

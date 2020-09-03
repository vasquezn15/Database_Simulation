using System;

namespace Ex1_DatabaseConnection
{
    public class DbCommand
    {
        DbConnection dbConnection;
        String instruction;

        public DbCommand(DbConnection dbConnection)
        {

            this.dbConnection = dbConnection;
        }

        public DbCommand(String instruction)
            
        {
            this.instruction = instruction;
        }

        public void Execute(DbConnection dbConnection)
        {
            dbConnection.Open();
            Console.WriteLine("Now connected to {0} connection", dbConnection.ConnectionString);
        }

        public void View()
        {
            Console.WriteLine("Now viewing files");
        }
    }
}
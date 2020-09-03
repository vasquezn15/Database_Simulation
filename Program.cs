using System;

namespace Ex1_DatabaseConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbCommand db;
            string commandString;

            while (true)
            {
                Console.WriteLine("Enter the database you wish to connect to (type \"end\" to exit program)");
                string connection = Console.ReadLine();
                if (String.IsNullOrEmpty(connection))
                {
                    Console.WriteLine("Cannot be null or empty");
                    
                }
                else if (connection.ToLower() == "sql")
                {
                    Console.WriteLine("Enter a connection string");
                    commandString = Console.ReadLine();
                    var sql = new SQLConnection(commandString);
                    db = new DbCommand(sql);
                }
                else if (connection.ToLower() == "oracle")
                {
                    Console.WriteLine("Enter a connection string");
                    commandString = Console.ReadLine();
                    var oracle = new OracleConnection(commandString);
                    db = new DbCommand(oracle);
                }
                
                else if (connection.ToLower() == "end")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("Enter command");
                
            }
        }
    }
}
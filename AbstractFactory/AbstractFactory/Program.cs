using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbFactory db = new SqlFactory();
            DbFactory db = new FirebaseFactory();

            var connection = db.CreateConnection();
            connection.Open();

            var command = db.CreateCommand();
            command.Execute();

            Console.ReadLine();
        }
    }
}

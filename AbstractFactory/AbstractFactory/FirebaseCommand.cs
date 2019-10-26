using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FirebaseCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("firebase executando.");
        }
    }
}

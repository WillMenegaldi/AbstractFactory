using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FirebaseConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Conexao firebase rodando.");
        }
    }
}

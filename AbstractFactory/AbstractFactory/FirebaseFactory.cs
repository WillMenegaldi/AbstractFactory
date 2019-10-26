using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FirebaseFactory : DbFactory
    {
        public override DbCommand CreateCommand()
        {
            return new FirebaseCommand();
        }

        public override DbConnection CreateConnection()
        {
            return new FirebaseConnection();
        }
    }
}

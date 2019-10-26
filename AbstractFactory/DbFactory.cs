using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class DbFactory
    {
        public abstract DbCommand CreateCommand();
        public abstract DbConnection CreateConnection();
    }
}

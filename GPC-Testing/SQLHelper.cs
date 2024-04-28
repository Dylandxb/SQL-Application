using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPC_Testing
{
    public static class SQLHelper
    {
        public static string Connection(string DBName)
        {
            //Finds the database server to connect to
            return ConfigurationManager.ConnectionStrings[DBName].ConnectionString;
        }
    }
}

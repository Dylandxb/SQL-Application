using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GPC_Testing
{
    public class DataAccess
    {
        public bool isConnected;
        //Change to xum local string
        //static string connString = ConfigurationManager.ConnectionStrings["GPC-Testing.Properties.Settings.DBConnString"].ConnectionString;
        static string connString = ConfigurationManager.ConnectionStrings["Test_Program.Properties.Settings.xumlocalConnectionString"].ConnectionString;

        //Missing <configSections> definition
        public bool ConnTest()
        {
            IDbConnection conn = new SqlConnection(connString);
            if (conn.State != ConnectionState.Open)
            {
                return isConnected = true;
            }
            return isConnected;
        }
        public List<SKU> GetSKUs(string SKUitem)
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                var displaySKUList = connection.Query<SKU>($"SELECT * FROM [SKUSDB].[dbo].[SKUTABLE] where SKU= '{SKUitem}'").ToList();
                return displaySKUList;
            }
        }
    }
}

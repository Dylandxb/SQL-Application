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
        //static string XUMServerconnString = ConfigurationManager.ConnectionStrings["Test_Program.Properties.Settings.xumlocalConnectionString"].ConnectionString;
        static string LocalConnString = ConfigurationManager.ConnectionStrings["GPC-Testing.Properties.Settings.DBConnString"].ConnectionString;
        IDbConnection conn = new SqlConnection(LocalConnString);

        public bool ConnTest()
        {
            if (conn.State != ConnectionState.Open)
            {
                return isConnected = true;
            }
            return isConnected;
        }
        public List<SKUParent> GetSKUs(string Case)
        {
            using (IDbConnection connection = conn)
            {
                //Finds the order id in the table and adds it to the nnew list
                var displaySKUList = connection.Query<SKUParent>($"select * from SKUSDB.dbo.SKUTABLE where PCCase = '{Case}'").ToList();
                return displaySKUList;

      
            }
        }
    }
}

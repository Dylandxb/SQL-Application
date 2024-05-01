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
        SKU sku = new SKU();
        public bool isConnected;
        string[] connections = new string[] { "Test_Program.Properties.Settings.xumlocalConnectionString" };
        //static string connString = ConfigurationManager.ConnectionStrings["GPC-Testing.Properties.Settings.DBConnString"].ConnectionString;
        static string XUMconnString = ConfigurationManager.ConnectionStrings["Test_Program.Properties.Settings.xumlocalConnectionString"].ConnectionString;
        //static string LocalConnString = ConfigurationManager.ConnectionStrings["Test_Program.Properties.Settings.DESKTOPConnectionString"].ConnectionString;
        //Missing <configSections> definition
        public bool ConnTest()
        {
            IDbConnection conn = new SqlConnection(XUMconnString);
            if (conn.State != ConnectionState.Open)
            {
                return isConnected = true;
            }
            return isConnected;
        }
        public List<SKU> GetSKUs(string SKUitem)
        {
           // while (isConnected)
           // {
                //sku.GetSKUs(string SKUitem)
                //Get list of all SKUs in db
                //Display list line by line
               
            //}
            using (IDbConnection connection = new SqlConnection(XUMconnString))
            {
                var displaySKUList = connection.Query<SKU>($"SELECT * FROM SKUS where SKU= '{SKUitem}'").ToList();
                return displaySKUList;
            }
        }
    }
}

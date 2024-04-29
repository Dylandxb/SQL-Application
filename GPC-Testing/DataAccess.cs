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


        static string connString = ConfigurationManager.ConnectionStrings["GPC-Testing.Properties.Settings.DBConnString"].ConnectionString;

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

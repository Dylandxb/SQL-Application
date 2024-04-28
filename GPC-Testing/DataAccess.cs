using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GPC_Testing
{
    public class DataAccess
    { 
        public List<PCManager> GetPCs(string PC)
        {
            throw new NotImplementedException();
        }

        public List<SKU> GetSKUs(string SKUitem)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.Connection("SKUDB")))
            {
                var displaySKUList = connection.Query<SKU>($"SELECT * FROM [SKUSDB].[dbo].[SKUTABLE] where SKU= '{SKUitem}'").ToList();
                return displaySKUList;
            }
        }
    }
}

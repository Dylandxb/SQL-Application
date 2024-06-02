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
        public bool orderExists;
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

        public bool ValidateOrder(int orderNumber)
        {
            //Checks if order number exists in the table, returns true
            IDbConnection conn = new SqlConnection(LocalConnString);
            conn.Open();
            using (IDbConnection connection = conn)
            {
                //Use a count with a select statement and executescalar to get the integer value
                using (SqlCommand validateCommand = new SqlCommand("SELECT * FROM dbo.SKUTABLE where orderID = @orderID", (SqlConnection)connection))
                {
                    orderNumber = (int)validateCommand.ExecuteScalar();
                    if (orderNumber > 0)
                    {
                        orderExists = true;
                    }
                }
                return orderExists;
            }

        }
        public List<SKUParent> GetSKUs(int ID)
        {
            //Initialize a new connection after using it previously
            IDbConnection conn = new SqlConnection(LocalConnString);
            using (IDbConnection connection = conn)
            {
                //Finds the order id in the table and adds it to the new list, one below is bad practice as there is SQL injection. Better to use a stored procedure taking in 1 parameter
                //var displaySKUList = connection.Query<SKUParent>($"select * from SKUSDB.dbo.SKUTABLE where orderID = '{ID}'").ToList();
                var displaySKUList = connection.Query<SKUParent>("SKUSDB.dbo.SKUTABLE_GetByOrderID @orderID", new {orderID = ID}).ToList();
                //Query needs a type SKUParent to retrieve its properties
                return displaySKUList;

      
            }
        }

        public void InsertSKU(string sku, string productCase, string mb, string cpu, string ram, string gpu, string hdd, string ssd, int idnum, string win, int order)
        {
            IDbConnection conn = new SqlConnection(LocalConnString);
            using (IDbConnection connection = conn)
            {
                //New instance of class object & add them them to a new list when assigning
                List<SKUParent> sKUs = new List<SKUParent>();
                sKUs.Add(new SKUParent
                {
                    SKU = sku,
                    PCCASE = productCase,
                    MOBO = mb,
                    CPU = cpu,
                    RAM = ram,
                    GPU = gpu,
                    HDD = hdd,
                    SSD = ssd,
                    IDnum = idnum,
                    WindowsVersion = win,
                    orderID = order
                });

                //Make a new connection to execute an insert query into each column of the table, using a sql stored procedure
                connection.Execute("SKUSDB.dbo.SKUTABLE_InsertNewSKU @SKU, @PCCase, @MOBO, @CPU, @RAM, @GPU, @HDD, @SSD, @IDnum, @WindowsVersion, @orderID", sKUs);
            }
        }
    }
}

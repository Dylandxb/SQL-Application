using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GPC_Testing
{
    public partial class Form1 : Form
    {
        DataAccess db = new DataAccess();
        List<SKUParent> skuList = new List<SKUParent>();
        public Form1()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private bool validateInput(string input)
        {
           // return input.Length == 6;
            return input.Length >= 1;
        }

        private void UpdateDisplay()
        {
            SKU_ListBox.DataSource = skuList;
            SKU_ListBox.DisplayMember = "SKU_Info";
        }

        private void LookupSKU_Button_Click(object sender, EventArgs e)
        {
            db.ConnTest();

            string userInput = Order_Input_Text.Text;
            //Checks for valid text input and DB connection is open
            if (validateInput(userInput) && db.isConnected)
            {
                MessageBox.Show("Searching & Found DB" + " " + db.isConnected);
                skuList = db.GetSKUs(userInput);
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Input a valid 6 digit order number");
            }

            Order_Input_Text.Clear();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            if (db.ConnTest() == true)
            {
                MessageBox.Show("Connection valid: " + db.isConnected);
            }
        }


    }
}

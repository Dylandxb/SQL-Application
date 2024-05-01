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
        int counter;
        public Form1()
        {
            InitializeComponent();
           // 
            SKU_ListBox.DisplayMember = "Info";
        }


        List<string> sKUs=new List<string>();

        private bool validateInput(string input)
        {
            return input.Length >= 1;
        }

        private void LookupSKU_Button_Click(object sender, EventArgs e)
        {
            db.ConnTest();

            string userInput = SKU_Input_Text.Text;
            //Checks for valid text input and DB connection is open
            if (validateInput(userInput) && db.isConnected)
            {
                MessageBox.Show("Searching & Found DB" + " " + db.isConnected);
                sKUs.Add(db.GetSKUs(SKU_Input_Text.Text)[0].Info);
                //if item is detected in db increment counter 
                SKU_ListBox.DataSource = sKUs;
               
            }
            else
            {
                MessageBox.Show("Input a valid order");
            }

            SKU_Input_Text.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ConnTest();
            if (db.ConnTest() == true)
            {
                MessageBox.Show("Connection valid" + db.isConnected);
            }
        }

        
    }
}

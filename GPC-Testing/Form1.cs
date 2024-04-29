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

        public Form1()
        {
            InitializeComponent();
            SKU_ListBox.DataSource = sKUs;
            SKU_ListBox.DisplayMember = "Info";
        }


        List<SKU> sKUs = new List<SKU>();

        private bool validateInput(string input)
        {
            return input.Length >= 1;
        }

        private void LookupSKU_Button_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string userInput = SKU_Input_Text.Text;
            if (validateInput(userInput))
            {
                //MessageBox.Show("Searching");
                db.GetSKUs(SKU_Input_Text.Text);
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Input a valid order");
            }
            sKUs = db.GetSKUs(SKU_Input_Text.Text);

            SKU_Input_Text.Clear();
        }
    }
}

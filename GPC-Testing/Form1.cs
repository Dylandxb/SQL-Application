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
using System.Runtime.InteropServices.WindowsRuntime;

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
           return input.Length == 6;

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
            //Needs to check order number exists in table before calling the function
            if (validateInput(userInput) && db.isConnected)
            {
                //if (db.ValidateOrder(userInput))
                //{

                //}
                MessageBox.Show("Searching... Found Order & DB connection status is:" + " " + db.isConnected);
                skuList = db.GetSKUs(userInput);
                UpdateDisplay();

            }
            //Else if order id is not found in table & input is 6 digits long, then message box order id doesnt exist
            //else if (validateInput(userInput) && db.GetSKUs(userInput) == null)
            //{
            //    MessageBox.Show("Couldnt find order id");
            //}
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

        private void Order_Input_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow for int inputs & backspace key
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Insert_SKU_Button_Click(object sender, EventArgs e)
        {

            
            db.InsertSKU(Input_SKU_Box.Text, Input_Case_Box.Text, Input_MOBO_Box.Text, Input_CPU_Box.Text, Input_RAM_Box.Text, Input_GPU_Box.Text,
                Input_HDD_Box.Text, Input_SSD_Box.Text, Input_IDnum_Box.Text.Length, Input_Windows_Box.Text, Input_Order_Box.Text.Length);

            //Creates an empty textbox for each item in the list
            List<TextBox> inputList = new List<TextBox>();
            inputList.Add(Input_SKU_Box);
            inputList.Add(Input_Case_Box);
            inputList.Add(Input_MOBO_Box);
            inputList.Add(Input_CPU_Box);
            inputList.Add(Input_RAM_Box);
            inputList.Add(Input_GPU_Box);
            inputList.Add(Input_HDD_Box);
            inputList.Add(Input_SSD_Box);
            inputList.Add(Input_IDnum_Box);
            inputList.Add(Input_Windows_Box);
            inputList.Add(Input_Order_Box);

            foreach (TextBox textBox in inputList)
            {
                textBox.Text = "";
            }
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPC_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = SKU_Input_Text.Text;
            if (validateInput(userInput))
            {
                MessageBox.Show("Searching");
            }
            else
            {
                MessageBox.Show("Input a valid order");
            }
            SKU_Input_Text.Clear();
        }

        private bool validateInput(string input)
        {
            return input.Length >= 1;
        }
    }
}

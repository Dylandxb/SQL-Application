namespace SQL_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Order_Input_Text = new System.Windows.Forms.TextBox();
            this.SKU_ListBox = new System.Windows.Forms.ListBox();
            this.Order_Input_Label = new System.Windows.Forms.Label();
            this.LookupSKU_Button = new System.Windows.Forms.Button();
            this.List_Label = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.Input_SKU_Box = new System.Windows.Forms.TextBox();
            this.Insert_SKU_Button = new System.Windows.Forms.Button();
            this.SKU_Label = new System.Windows.Forms.Label();
            this.CASE_Label = new System.Windows.Forms.Label();
            this.Input_Case_Box = new System.Windows.Forms.TextBox();
            this.MOBO_Label = new System.Windows.Forms.Label();
            this.Input_MOBO_Box = new System.Windows.Forms.TextBox();
            this.CPU_Label = new System.Windows.Forms.Label();
            this.Input_CPU_Box = new System.Windows.Forms.TextBox();
            this.RAM_Label = new System.Windows.Forms.Label();
            this.Input_RAM_Box = new System.Windows.Forms.TextBox();
            this.GPU_Label = new System.Windows.Forms.Label();
            this.Input_GPU_Box = new System.Windows.Forms.TextBox();
            this.HDD_Label = new System.Windows.Forms.Label();
            this.Input_HDD_Box = new System.Windows.Forms.TextBox();
            this.SSD_Label = new System.Windows.Forms.Label();
            this.Input_SSD_Box = new System.Windows.Forms.TextBox();
            this.IDnum_Label = new System.Windows.Forms.Label();
            this.Input_IDnum_Box = new System.Windows.Forms.TextBox();
            this.WIN_Label = new System.Windows.Forms.Label();
            this.Input_Windows_Box = new System.Windows.Forms.TextBox();
            this.Order_Label = new System.Windows.Forms.Label();
            this.Input_Order_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Order_Input_Text
            // 
            this.Order_Input_Text.Location = new System.Drawing.Point(12, 81);
            this.Order_Input_Text.Name = "Order_Input_Text";
            this.Order_Input_Text.Size = new System.Drawing.Size(165, 20);
            this.Order_Input_Text.TabIndex = 1;
            this.Order_Input_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Order_Input_Text_KeyPress);
            // 
            // SKU_ListBox
            // 
            this.SKU_ListBox.FormattingEnabled = true;
            this.SKU_ListBox.Location = new System.Drawing.Point(12, 168);
            this.SKU_ListBox.Name = "SKU_ListBox";
            this.SKU_ListBox.Size = new System.Drawing.Size(404, 277);
            this.SKU_ListBox.TabIndex = 2;
            // 
            // Order_Input_Label
            // 
            this.Order_Input_Label.AutoSize = true;
            this.Order_Input_Label.Location = new System.Drawing.Point(46, 65);
            this.Order_Input_Label.Name = "Order_Input_Label";
            this.Order_Input_Label.Size = new System.Drawing.Size(99, 13);
            this.Order_Input_Label.TabIndex = 3;
            this.Order_Input_Label.Text = "Search for Order ID";
            // 
            // LookupSKU_Button
            // 
            this.LookupSKU_Button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LookupSKU_Button.Location = new System.Drawing.Point(247, 69);
            this.LookupSKU_Button.Name = "LookupSKU_Button";
            this.LookupSKU_Button.Size = new System.Drawing.Size(113, 42);
            this.LookupSKU_Button.TabIndex = 4;
            this.LookupSKU_Button.Text = "Find SKU";
            this.LookupSKU_Button.UseVisualStyleBackColor = true;
            this.LookupSKU_Button.Click += new System.EventHandler(this.LookupSKU_Button_Click);
            // 
            // List_Label
            // 
            this.List_Label.AutoSize = true;
            this.List_Label.Location = new System.Drawing.Point(12, 139);
            this.List_Label.Name = "List_Label";
            this.List_Label.Size = new System.Drawing.Size(124, 13);
            this.List_Label.TabIndex = 5;
            this.List_Label.Text = "Display SKUs in List form";
            // 
            // connectionButton
            // 
            this.connectionButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.connectionButton.Location = new System.Drawing.Point(12, 12);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(75, 23);
            this.connectionButton.TabIndex = 6;
            this.connectionButton.Text = "Test Conn";
            this.connectionButton.UseVisualStyleBackColor = false;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // Input_SKU_Box
            // 
            this.Input_SKU_Box.Location = new System.Drawing.Point(586, 144);
            this.Input_SKU_Box.Name = "Input_SKU_Box";
            this.Input_SKU_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_SKU_Box.TabIndex = 7;
            // 
            // Insert_SKU_Button
            // 
            this.Insert_SKU_Button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Insert_SKU_Button.Location = new System.Drawing.Point(604, 69);
            this.Insert_SKU_Button.Name = "Insert_SKU_Button";
            this.Insert_SKU_Button.Size = new System.Drawing.Size(113, 42);
            this.Insert_SKU_Button.TabIndex = 8;
            this.Insert_SKU_Button.Text = "Insert SKU";
            this.Insert_SKU_Button.UseVisualStyleBackColor = true;
            this.Insert_SKU_Button.Click += new System.EventHandler(this.Insert_SKU_Button_Click);
            // 
            // SKU_Label
            // 
            this.SKU_Label.AutoSize = true;
            this.SKU_Label.Location = new System.Drawing.Point(495, 147);
            this.SKU_Label.Name = "SKU_Label";
            this.SKU_Label.Size = new System.Drawing.Size(56, 13);
            this.SKU_Label.TabIndex = 9;
            this.SKU_Label.Text = "Input SKU";
            // 
            // CASE_Label
            // 
            this.CASE_Label.AutoSize = true;
            this.CASE_Label.Location = new System.Drawing.Point(495, 173);
            this.CASE_Label.Name = "CASE_Label";
            this.CASE_Label.Size = new System.Drawing.Size(58, 13);
            this.CASE_Label.TabIndex = 11;
            this.CASE_Label.Text = "Input Case";
            // 
            // Input_Case_Box
            // 
            this.Input_Case_Box.Location = new System.Drawing.Point(586, 170);
            this.Input_Case_Box.Name = "Input_Case_Box";
            this.Input_Case_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_Case_Box.TabIndex = 10;
            // 
            // MOBO_Label
            // 
            this.MOBO_Label.AutoSize = true;
            this.MOBO_Label.Location = new System.Drawing.Point(495, 199);
            this.MOBO_Label.Name = "MOBO_Label";
            this.MOBO_Label.Size = new System.Drawing.Size(66, 13);
            this.MOBO_Label.TabIndex = 13;
            this.MOBO_Label.Text = "Input MOBO";
            // 
            // Input_MOBO_Box
            // 
            this.Input_MOBO_Box.Location = new System.Drawing.Point(586, 196);
            this.Input_MOBO_Box.Name = "Input_MOBO_Box";
            this.Input_MOBO_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_MOBO_Box.TabIndex = 12;
            // 
            // CPU_Label
            // 
            this.CPU_Label.AutoSize = true;
            this.CPU_Label.Location = new System.Drawing.Point(495, 225);
            this.CPU_Label.Name = "CPU_Label";
            this.CPU_Label.Size = new System.Drawing.Size(56, 13);
            this.CPU_Label.TabIndex = 15;
            this.CPU_Label.Text = "Input CPU";
            // 
            // Input_CPU_Box
            // 
            this.Input_CPU_Box.Location = new System.Drawing.Point(586, 222);
            this.Input_CPU_Box.Name = "Input_CPU_Box";
            this.Input_CPU_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_CPU_Box.TabIndex = 14;
            // 
            // RAM_Label
            // 
            this.RAM_Label.AutoSize = true;
            this.RAM_Label.Location = new System.Drawing.Point(495, 251);
            this.RAM_Label.Name = "RAM_Label";
            this.RAM_Label.Size = new System.Drawing.Size(58, 13);
            this.RAM_Label.TabIndex = 17;
            this.RAM_Label.Text = "Input RAM";
            // 
            // Input_RAM_Box
            // 
            this.Input_RAM_Box.Location = new System.Drawing.Point(586, 248);
            this.Input_RAM_Box.Name = "Input_RAM_Box";
            this.Input_RAM_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_RAM_Box.TabIndex = 16;
            // 
            // GPU_Label
            // 
            this.GPU_Label.AutoSize = true;
            this.GPU_Label.Location = new System.Drawing.Point(495, 277);
            this.GPU_Label.Name = "GPU_Label";
            this.GPU_Label.Size = new System.Drawing.Size(57, 13);
            this.GPU_Label.TabIndex = 19;
            this.GPU_Label.Text = "Input GPU";
            // 
            // Input_GPU_Box
            // 
            this.Input_GPU_Box.Location = new System.Drawing.Point(586, 274);
            this.Input_GPU_Box.Name = "Input_GPU_Box";
            this.Input_GPU_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_GPU_Box.TabIndex = 18;
            // 
            // HDD_Label
            // 
            this.HDD_Label.AutoSize = true;
            this.HDD_Label.Location = new System.Drawing.Point(495, 303);
            this.HDD_Label.Name = "HDD_Label";
            this.HDD_Label.Size = new System.Drawing.Size(58, 13);
            this.HDD_Label.TabIndex = 21;
            this.HDD_Label.Text = "Input HDD";
            // 
            // Input_HDD_Box
            // 
            this.Input_HDD_Box.Location = new System.Drawing.Point(586, 300);
            this.Input_HDD_Box.Name = "Input_HDD_Box";
            this.Input_HDD_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_HDD_Box.TabIndex = 20;
            // 
            // SSD_Label
            // 
            this.SSD_Label.AutoSize = true;
            this.SSD_Label.Location = new System.Drawing.Point(495, 329);
            this.SSD_Label.Name = "SSD_Label";
            this.SSD_Label.Size = new System.Drawing.Size(56, 13);
            this.SSD_Label.TabIndex = 23;
            this.SSD_Label.Text = "Input SSD";
            // 
            // Input_SSD_Box
            // 
            this.Input_SSD_Box.Location = new System.Drawing.Point(586, 326);
            this.Input_SSD_Box.Name = "Input_SSD_Box";
            this.Input_SSD_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_SSD_Box.TabIndex = 22;
            // 
            // IDnum_Label
            // 
            this.IDnum_Label.AutoSize = true;
            this.IDnum_Label.Location = new System.Drawing.Point(495, 355);
            this.IDnum_Label.Name = "IDnum_Label";
            this.IDnum_Label.Size = new System.Drawing.Size(80, 13);
            this.IDnum_Label.TabIndex = 25;
            this.IDnum_Label.Text = "Input IDnumber";
            // 
            // Input_IDnum_Box
            // 
            this.Input_IDnum_Box.Location = new System.Drawing.Point(586, 352);
            this.Input_IDnum_Box.Name = "Input_IDnum_Box";
            this.Input_IDnum_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_IDnum_Box.TabIndex = 24;
            // 
            // WIN_Label
            // 
            this.WIN_Label.AutoSize = true;
            this.WIN_Label.Location = new System.Drawing.Point(495, 381);
            this.WIN_Label.Name = "WIN_Label";
            this.WIN_Label.Size = new System.Drawing.Size(78, 13);
            this.WIN_Label.TabIndex = 27;
            this.WIN_Label.Text = "Input Windows";
            // 
            // Input_Windows_Box
            // 
            this.Input_Windows_Box.Location = new System.Drawing.Point(586, 378);
            this.Input_Windows_Box.Name = "Input_Windows_Box";
            this.Input_Windows_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_Windows_Box.TabIndex = 26;
            // 
            // Order_Label
            // 
            this.Order_Label.AutoSize = true;
            this.Order_Label.Location = new System.Drawing.Point(495, 407);
            this.Order_Label.Name = "Order_Label";
            this.Order_Label.Size = new System.Drawing.Size(60, 13);
            this.Order_Label.TabIndex = 29;
            this.Order_Label.Text = "Input Order";
            // 
            // Input_Order_Box
            // 
            this.Input_Order_Box.Location = new System.Drawing.Point(586, 404);
            this.Input_Order_Box.Name = "Input_Order_Box";
            this.Input_Order_Box.Size = new System.Drawing.Size(165, 20);
            this.Input_Order_Box.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Order_Label);
            this.Controls.Add(this.Input_Order_Box);
            this.Controls.Add(this.WIN_Label);
            this.Controls.Add(this.Input_Windows_Box);
            this.Controls.Add(this.IDnum_Label);
            this.Controls.Add(this.Input_IDnum_Box);
            this.Controls.Add(this.SSD_Label);
            this.Controls.Add(this.Input_SSD_Box);
            this.Controls.Add(this.HDD_Label);
            this.Controls.Add(this.Input_HDD_Box);
            this.Controls.Add(this.GPU_Label);
            this.Controls.Add(this.Input_GPU_Box);
            this.Controls.Add(this.RAM_Label);
            this.Controls.Add(this.Input_RAM_Box);
            this.Controls.Add(this.CPU_Label);
            this.Controls.Add(this.Input_CPU_Box);
            this.Controls.Add(this.MOBO_Label);
            this.Controls.Add(this.Input_MOBO_Box);
            this.Controls.Add(this.CASE_Label);
            this.Controls.Add(this.Input_Case_Box);
            this.Controls.Add(this.SKU_Label);
            this.Controls.Add(this.Insert_SKU_Button);
            this.Controls.Add(this.Input_SKU_Box);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.List_Label);
            this.Controls.Add(this.LookupSKU_Button);
            this.Controls.Add(this.Order_Input_Label);
            this.Controls.Add(this.SKU_ListBox);
            this.Controls.Add(this.Order_Input_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Order_Input_Text;
        private System.Windows.Forms.ListBox SKU_ListBox;
        private System.Windows.Forms.Label Order_Input_Label;
        private System.Windows.Forms.Button LookupSKU_Button;
        private System.Windows.Forms.Label List_Label;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox Input_SKU_Box;
        private System.Windows.Forms.Button Insert_SKU_Button;
        private System.Windows.Forms.Label SKU_Label;
        private System.Windows.Forms.Label CASE_Label;
        private System.Windows.Forms.TextBox Input_Case_Box;
        private System.Windows.Forms.Label MOBO_Label;
        private System.Windows.Forms.TextBox Input_MOBO_Box;
        private System.Windows.Forms.Label CPU_Label;
        private System.Windows.Forms.TextBox Input_CPU_Box;
        private System.Windows.Forms.Label RAM_Label;
        private System.Windows.Forms.TextBox Input_RAM_Box;
        private System.Windows.Forms.Label GPU_Label;
        private System.Windows.Forms.TextBox Input_GPU_Box;
        private System.Windows.Forms.Label HDD_Label;
        private System.Windows.Forms.TextBox Input_HDD_Box;
        private System.Windows.Forms.Label SSD_Label;
        private System.Windows.Forms.TextBox Input_SSD_Box;
        private System.Windows.Forms.Label IDnum_Label;
        private System.Windows.Forms.TextBox Input_IDnum_Box;
        private System.Windows.Forms.Label WIN_Label;
        private System.Windows.Forms.TextBox Input_Windows_Box;
        private System.Windows.Forms.Label Order_Label;
        private System.Windows.Forms.TextBox Input_Order_Box;
    }
}


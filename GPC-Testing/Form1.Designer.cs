namespace GPC_Testing
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
            this.SKU_Input_Text = new System.Windows.Forms.TextBox();
            this.SKU_ListBox = new System.Windows.Forms.ListBox();
            this.SKU_Input_Label = new System.Windows.Forms.Label();
            this.LookupSKU_Button = new System.Windows.Forms.Button();
            this.List_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SKU_Input_Text
            // 
            this.SKU_Input_Text.Location = new System.Drawing.Point(98, 131);
            this.SKU_Input_Text.Name = "SKU_Input_Text";
            this.SKU_Input_Text.Size = new System.Drawing.Size(165, 20);
            this.SKU_Input_Text.TabIndex = 1;
            this.SKU_Input_Text.Text = "Type here";
            // 
            // SKU_ListBox
            // 
            this.SKU_ListBox.FormattingEnabled = true;
            this.SKU_ListBox.Location = new System.Drawing.Point(118, 233);
            this.SKU_ListBox.Name = "SKU_ListBox";
            this.SKU_ListBox.Size = new System.Drawing.Size(578, 199);
            this.SKU_ListBox.TabIndex = 2;
            // 
            // SKU_Input_Label
            // 
            this.SKU_Input_Label.AutoSize = true;
            this.SKU_Input_Label.Location = new System.Drawing.Point(144, 113);
            this.SKU_Input_Label.Name = "SKU_Input_Label";
            this.SKU_Input_Label.Size = new System.Drawing.Size(66, 13);
            this.SKU_Input_Label.TabIndex = 3;
            this.SKU_Input_Label.Text = "SKU Search";
            // 
            // LookupSKU_Button
            // 
            this.LookupSKU_Button.Location = new System.Drawing.Point(537, 119);
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
            this.List_Label.Location = new System.Drawing.Point(115, 208);
            this.List_Label.Name = "List_Label";
            this.List_Label.Size = new System.Drawing.Size(124, 13);
            this.List_Label.TabIndex = 5;
            this.List_Label.Text = "Display SKUs in List form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List_Label);
            this.Controls.Add(this.LookupSKU_Button);
            this.Controls.Add(this.SKU_Input_Label);
            this.Controls.Add(this.SKU_ListBox);
            this.Controls.Add(this.SKU_Input_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SKU_Input_Text;
        private System.Windows.Forms.ListBox SKU_ListBox;
        private System.Windows.Forms.Label SKU_Input_Label;
        private System.Windows.Forms.Button LookupSKU_Button;
        private System.Windows.Forms.Label List_Label;
    }
}


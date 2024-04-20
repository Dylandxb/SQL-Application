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
            this.lookup_SKU = new System.Windows.Forms.Button();
            this.SKU_Input_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lookup_SKU
            // 
            this.lookup_SKU.Location = new System.Drawing.Point(496, 113);
            this.lookup_SKU.Name = "lookup_SKU";
            this.lookup_SKU.Size = new System.Drawing.Size(225, 55);
            this.lookup_SKU.TabIndex = 0;
            this.lookup_SKU.Text = "Find SKU";
            this.lookup_SKU.UseVisualStyleBackColor = true;
            this.lookup_SKU.Click += new System.EventHandler(this.button1_Click);
            // 
            // SKU_Input_Text
            // 
            this.SKU_Input_Text.Location = new System.Drawing.Point(98, 131);
            this.SKU_Input_Text.Name = "SKU_Input_Text";
            this.SKU_Input_Text.Size = new System.Drawing.Size(165, 20);
            this.SKU_Input_Text.TabIndex = 1;
            this.SKU_Input_Text.Text = "Type here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SKU_Input_Text);
            this.Controls.Add(this.lookup_SKU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lookup_SKU;
        private System.Windows.Forms.TextBox SKU_Input_Text;
    }
}


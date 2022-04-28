namespace D2_SQL
{
    partial class DisplayPage
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
            this.listBoxCustomerData = new System.Windows.Forms.ListBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCustomerData
            // 
            this.listBoxCustomerData.ColumnWidth = 388;
            this.listBoxCustomerData.FormattingEnabled = true;
            this.listBoxCustomerData.Location = new System.Drawing.Point(409, 12);
            this.listBoxCustomerData.Name = "listBoxCustomerData";
            this.listBoxCustomerData.Size = new System.Drawing.Size(379, 394);
            this.listBoxCustomerData.TabIndex = 0;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(33, 24);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(313, 124);
            this.buttonDisplay.TabIndex = 1;
            this.buttonDisplay.Text = "Display Customer Data";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 124);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.listBoxCustomerData);
            this.Name = "DisplayPage";
            this.Text = "DisplayPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCustomerData;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button button1;
    }
}
namespace IO_Classes_Lab
{
    partial class AddLicense
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
            this.lbDriver = new System.Windows.Forms.Label();
            this.lbTransportTypes = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDriver
            // 
            this.lbDriver.Location = new System.Drawing.Point(12, 2);
            this.lbDriver.Name = "lbDriver";
            this.lbDriver.Size = new System.Drawing.Size(230, 48);
            this.lbDriver.TabIndex = 0;
            this.lbDriver.Text = "label1";
            // 
            // lbTransportTypes
            // 
            this.lbTransportTypes.FormattingEnabled = true;
            this.lbTransportTypes.Location = new System.Drawing.Point(12, 54);
            this.lbTransportTypes.Name = "lbTransportTypes";
            this.lbTransportTypes.Size = new System.Drawing.Size(230, 238);
            this.lbTransportTypes.TabIndex = 1;
            this.lbTransportTypes.SelectedIndexChanged += new System.EventHandler(this.lbTransportTypes_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 71);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Create license";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 381);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTransportTypes);
            this.Controls.Add(this.lbDriver);
            this.Name = "AddLicense";
            this.Text = "AddLicense";
            this.Load += new System.EventHandler(this.AddLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDriver;
        private System.Windows.Forms.ListBox lbTransportTypes;
        private System.Windows.Forms.Button btnAdd;
    }
}
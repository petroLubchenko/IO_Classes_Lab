namespace IO_Classes_Lab
{
    partial class ShowTransportationForm
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.tbSpending = new System.Windows.Forms.TextBox();
            this.tbIncome = new System.Windows.Forms.TextBox();
            this.lbLengthinfo = new System.Windows.Forms.Label();
            this.lbIncomeinfo = new System.Windows.Forms.Label();
            this.lbSpendinginfo = new System.Windows.Forms.Label();
            this.cbTransporttype = new System.Windows.Forms.ComboBox();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnSpending = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbInfo.Location = new System.Drawing.Point(13, 13);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(386, 46);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "label1";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(138, 63);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(152, 20);
            this.tbDistance.TabIndex = 1;
            // 
            // tbSpending
            // 
            this.tbSpending.Location = new System.Drawing.Point(138, 119);
            this.tbSpending.Name = "tbSpending";
            this.tbSpending.Size = new System.Drawing.Size(152, 20);
            this.tbSpending.TabIndex = 2;
            // 
            // tbIncome
            // 
            this.tbIncome.Location = new System.Drawing.Point(138, 93);
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Size = new System.Drawing.Size(152, 20);
            this.tbIncome.TabIndex = 3;
            // 
            // lbLengthinfo
            // 
            this.lbLengthinfo.AutoSize = true;
            this.lbLengthinfo.Location = new System.Drawing.Point(12, 66);
            this.lbLengthinfo.Name = "lbLengthinfo";
            this.lbLengthinfo.Size = new System.Drawing.Size(118, 13);
            this.lbLengthinfo.TabIndex = 4;
            this.lbLengthinfo.Text = "Transportation distance";
            // 
            // lbIncomeinfo
            // 
            this.lbIncomeinfo.AutoSize = true;
            this.lbIncomeinfo.Location = new System.Drawing.Point(14, 96);
            this.lbIncomeinfo.Name = "lbIncomeinfo";
            this.lbIncomeinfo.Size = new System.Drawing.Size(112, 13);
            this.lbIncomeinfo.TabIndex = 5;
            this.lbIncomeinfo.Text = "Transportation income";
            // 
            // lbSpendinginfo
            // 
            this.lbSpendinginfo.AutoSize = true;
            this.lbSpendinginfo.Location = new System.Drawing.Point(14, 122);
            this.lbSpendinginfo.Name = "lbSpendinginfo";
            this.lbSpendinginfo.Size = new System.Drawing.Size(121, 13);
            this.lbSpendinginfo.TabIndex = 6;
            this.lbSpendinginfo.Text = "Transportation spending";
            // 
            // cbTransporttype
            // 
            this.cbTransporttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransporttype.FormattingEnabled = true;
            this.cbTransporttype.Location = new System.Drawing.Point(17, 145);
            this.cbTransporttype.Name = "cbTransporttype";
            this.cbTransporttype.Size = new System.Drawing.Size(382, 21);
            this.cbTransporttype.TabIndex = 7;
            this.cbTransporttype.SelectedIndexChanged += new System.EventHandler(this.cbTransporttype_SelectedIndexChanged);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(297, 63);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(102, 20);
            this.btnLength.TabIndex = 8;
            this.btnLength.Text = "Change";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(297, 93);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(102, 20);
            this.btnIncome.TabIndex = 9;
            this.btnIncome.Text = "Change";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnSpending
            // 
            this.btnSpending.Location = new System.Drawing.Point(297, 119);
            this.btnSpending.Name = "btnSpending";
            this.btnSpending.Size = new System.Drawing.Size(102, 20);
            this.btnSpending.TabIndex = 10;
            this.btnSpending.Text = "Change";
            this.btnSpending.UseVisualStyleBackColor = true;
            this.btnSpending.Click += new System.EventHandler(this.btnSpending_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(138, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete transportation";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ShowTransportationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 267);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSpending);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.cbTransporttype);
            this.Controls.Add(this.lbSpendinginfo);
            this.Controls.Add(this.lbIncomeinfo);
            this.Controls.Add(this.lbLengthinfo);
            this.Controls.Add(this.tbIncome);
            this.Controls.Add(this.tbSpending);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.lbInfo);
            this.Name = "ShowTransportationForm";
            this.Text = "ShowTransportationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowTransportationForm_FormClosed);
            this.Load += new System.EventHandler(this.ShowTransportationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.TextBox tbSpending;
        private System.Windows.Forms.TextBox tbIncome;
        private System.Windows.Forms.Label lbLengthinfo;
        private System.Windows.Forms.Label lbIncomeinfo;
        private System.Windows.Forms.Label lbSpendinginfo;
        private System.Windows.Forms.ComboBox cbTransporttype;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnSpending;
        private System.Windows.Forms.Button btnDelete;
    }
}
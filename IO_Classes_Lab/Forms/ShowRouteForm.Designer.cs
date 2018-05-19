namespace IO_Classes_Lab
{
    partial class ShowRouteForm
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnSetnumber = new System.Windows.Forms.Button();
            this.cbTransporttype = new System.Windows.Forms.ComboBox();
            this.lbTransportations = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbRouteshow = new System.Windows.Forms.Label();
            this.lbTransptypeshow = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbInfo.Location = new System.Drawing.Point(61, 13);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(207, 42);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Info";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(61, 59);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(116, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // btnSetnumber
            // 
            this.btnSetnumber.Location = new System.Drawing.Point(184, 59);
            this.btnSetnumber.Name = "btnSetnumber";
            this.btnSetnumber.Size = new System.Drawing.Size(84, 20);
            this.btnSetnumber.TabIndex = 2;
            this.btnSetnumber.Text = "Set number";
            this.btnSetnumber.UseVisualStyleBackColor = true;
            this.btnSetnumber.Click += new System.EventHandler(this.btnSetnumber_Click);
            // 
            // cbTransporttype
            // 
            this.cbTransporttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransporttype.FormattingEnabled = true;
            this.cbTransporttype.Location = new System.Drawing.Point(61, 86);
            this.cbTransporttype.Name = "cbTransporttype";
            this.cbTransporttype.Size = new System.Drawing.Size(207, 21);
            this.cbTransporttype.TabIndex = 3;
            this.cbTransporttype.SelectedIndexChanged += new System.EventHandler(this.cbTransporttype_SelectedIndexChanged);
            // 
            // lbTransportations
            // 
            this.lbTransportations.FormattingEnabled = true;
            this.lbTransportations.Location = new System.Drawing.Point(61, 114);
            this.lbTransportations.Name = "lbTransportations";
            this.lbTransportations.Size = new System.Drawing.Size(116, 173);
            this.lbTransportations.TabIndex = 4;
            this.lbTransportations.SelectedIndexChanged += new System.EventHandler(this.lbTransportations_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 20);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 20);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbRouteshow
            // 
            this.lbRouteshow.Location = new System.Drawing.Point(58, 290);
            this.lbRouteshow.Name = "lbRouteshow";
            this.lbRouteshow.Size = new System.Drawing.Size(210, 23);
            this.lbRouteshow.TabIndex = 7;
            this.lbRouteshow.Text = "label1";
            this.lbRouteshow.Visible = false;
            // 
            // lbTransptypeshow
            // 
            this.lbTransptypeshow.Location = new System.Drawing.Point(58, 313);
            this.lbTransptypeshow.Name = "lbTransptypeshow";
            this.lbTransptypeshow.Size = new System.Drawing.Size(210, 23);
            this.lbTransptypeshow.TabIndex = 8;
            this.lbTransptypeshow.Text = "label2";
            this.lbTransptypeshow.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(61, 363);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 36);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Delete route";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ShowRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 451);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbTransptypeshow);
            this.Controls.Add(this.lbRouteshow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbTransportations);
            this.Controls.Add(this.cbTransporttype);
            this.Controls.Add(this.btnSetnumber);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lbInfo);
            this.Name = "ShowRouteForm";
            this.Text = "ShowRoute";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowRouteForm_FormClosed);
            this.Load += new System.EventHandler(this.ShowRouteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnSetnumber;
        private System.Windows.Forms.ComboBox cbTransporttype;
        private System.Windows.Forms.ListBox lbTransportations;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRouteshow;
        private System.Windows.Forms.Label lbTransptypeshow;
        private System.Windows.Forms.Button btnRemove;
    }
}
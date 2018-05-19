namespace IO_Classes_Lab
{
    partial class ShowDriverForm
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
            this.components = new System.ComponentModel.Container();
            this.lbDriver = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbSecname = new System.Windows.Forms.TextBox();
            this.lbLicenses = new System.Windows.Forms.ListBox();
            this.btnEditfn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditroute = new System.Windows.Forms.Button();
            this.btnEditsn = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.Validator = new System.Windows.Forms.Timer(this.components);
            this.cbroute = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblicdr = new System.Windows.Forms.Label();
            this.lblictt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDriver
            // 
            this.lbDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbDriver.Location = new System.Drawing.Point(12, 9);
            this.lbDriver.Name = "lbDriver";
            this.lbDriver.Size = new System.Drawing.Size(323, 56);
            this.lbDriver.TabIndex = 0;
            this.lbDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(16, 68);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(201, 20);
            this.tbFirstname.TabIndex = 1;
            // 
            // tbSecname
            // 
            this.tbSecname.Location = new System.Drawing.Point(16, 94);
            this.tbSecname.Name = "tbSecname";
            this.tbSecname.Size = new System.Drawing.Size(201, 20);
            this.tbSecname.TabIndex = 2;
            // 
            // lbLicenses
            // 
            this.lbLicenses.FormattingEnabled = true;
            this.lbLicenses.Location = new System.Drawing.Point(16, 141);
            this.lbLicenses.Name = "lbLicenses";
            this.lbLicenses.Size = new System.Drawing.Size(201, 108);
            this.lbLicenses.TabIndex = 4;
            this.lbLicenses.SelectedIndexChanged += new System.EventHandler(this.lbLicenses_SelectedIndexChanged);
            // 
            // btnEditfn
            // 
            this.btnEditfn.Location = new System.Drawing.Point(224, 68);
            this.btnEditfn.Name = "btnEditfn";
            this.btnEditfn.Size = new System.Drawing.Size(76, 20);
            this.btnEditfn.TabIndex = 5;
            this.btnEditfn.Text = "Edit";
            this.btnEditfn.UseVisualStyleBackColor = true;
            this.btnEditfn.Click += new System.EventHandler(this.btnEditfn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 20);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditroute
            // 
            this.btnEditroute.Location = new System.Drawing.Point(223, 117);
            this.btnEditroute.Name = "btnEditroute";
            this.btnEditroute.Size = new System.Drawing.Size(76, 20);
            this.btnEditroute.TabIndex = 7;
            this.btnEditroute.Text = "Change route";
            this.btnEditroute.UseVisualStyleBackColor = true;
            this.btnEditroute.Click += new System.EventHandler(this.btnEditroute_Click);
            // 
            // btnEditsn
            // 
            this.btnEditsn.Location = new System.Drawing.Point(223, 94);
            this.btnEditsn.Name = "btnEditsn";
            this.btnEditsn.Size = new System.Drawing.Size(76, 20);
            this.btnEditsn.TabIndex = 8;
            this.btnEditsn.Text = "Edit";
            this.btnEditsn.UseVisualStyleBackColor = true;
            this.btnEditsn.Click += new System.EventHandler(this.btnEditsn_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(224, 169);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(76, 20);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Validator
            // 
            this.Validator.Enabled = true;
            this.Validator.Interval = 200;
            this.Validator.Tick += new System.EventHandler(this.Validator_Tick);
            // 
            // cbroute
            // 
            this.cbroute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbroute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbroute.FormattingEnabled = true;
            this.cbroute.Location = new System.Drawing.Point(16, 117);
            this.cbroute.Name = "cbroute";
            this.cbroute.Size = new System.Drawing.Size(201, 21);
            this.cbroute.TabIndex = 11;
            this.cbroute.SelectedIndexChanged += new System.EventHandler(this.cbroute_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 48);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete driver";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblicdr
            // 
            this.lblicdr.Location = new System.Drawing.Point(16, 256);
            this.lblicdr.Name = "lblicdr";
            this.lblicdr.Size = new System.Drawing.Size(201, 25);
            this.lblicdr.TabIndex = 13;
            this.lblicdr.Text = "label1";
            // 
            // lblictt
            // 
            this.lblictt.Location = new System.Drawing.Point(16, 285);
            this.lblictt.Name = "lblictt";
            this.lblictt.Size = new System.Drawing.Size(204, 29);
            this.lblictt.TabIndex = 14;
            this.lblictt.Text = "label2";
            // 
            // ShowDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 404);
            this.Controls.Add(this.lblictt);
            this.Controls.Add(this.lblicdr);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbroute);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEditsn);
            this.Controls.Add(this.btnEditroute);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEditfn);
            this.Controls.Add(this.lbLicenses);
            this.Controls.Add(this.tbSecname);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.lbDriver);
            this.Name = "ShowDriverForm";
            this.Text = "Show";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowDriverForm_FormClosed);
            this.Shown += new System.EventHandler(this.ShowDriverForm_Shown);
            this.Validated += new System.EventHandler(this.ShowDriverForm_Validated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDriver;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbSecname;
        private System.Windows.Forms.ListBox lbLicenses;
        private System.Windows.Forms.Button btnEditfn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditroute;
        private System.Windows.Forms.Button btnEditsn;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Timer Validator;
        private System.Windows.Forms.ComboBox cbroute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblicdr;
        private System.Windows.Forms.Label lblictt;
    }
}
namespace IO_Classes_Lab
{
    partial class AddRouteTranspAggr
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
            this.lbRoute = new System.Windows.Forms.Label();
            this.cbTransportations = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRoute
            // 
            this.lbRoute.Location = new System.Drawing.Point(12, 9);
            this.lbRoute.Name = "lbRoute";
            this.lbRoute.Size = new System.Drawing.Size(175, 37);
            this.lbRoute.TabIndex = 0;
            this.lbRoute.Text = "label1";
            // 
            // cbTransportations
            // 
            this.cbTransportations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransportations.FormattingEnabled = true;
            this.cbTransportations.Location = new System.Drawing.Point(15, 50);
            this.cbTransportations.Name = "cbTransportations";
            this.cbTransportations.Size = new System.Drawing.Size(172, 21);
            this.cbTransportations.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 126);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(112, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddRouteTranspAggr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 164);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbTransportations);
            this.Controls.Add(this.lbRoute);
            this.Name = "AddRouteTranspAggr";
            this.Text = "AddRouteTranspAggr";
            this.Load += new System.EventHandler(this.AddRouteTranspAggr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRoute;
        private System.Windows.Forms.ComboBox cbTransportations;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
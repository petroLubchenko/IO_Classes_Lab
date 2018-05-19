namespace IO_Classes_Lab
{
    partial class FibonacciForm
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
            this.tbStep = new System.Windows.Forms.TextBox();
            this.lbTextboxinfo = new System.Windows.Forms.Label();
            this.btnInputstep = new System.Windows.Forms.Button();
            this.lbRezult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(54, 15);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(143, 20);
            this.tbStep.TabIndex = 0;
            // 
            // lbTextboxinfo
            // 
            this.lbTextboxinfo.AutoSize = true;
            this.lbTextboxinfo.Location = new System.Drawing.Point(13, 18);
            this.lbTextboxinfo.Name = "lbTextboxinfo";
            this.lbTextboxinfo.Size = new System.Drawing.Size(35, 13);
            this.lbTextboxinfo.TabIndex = 1;
            this.lbTextboxinfo.Text = "Step: ";
            // 
            // btnInputstep
            // 
            this.btnInputstep.Location = new System.Drawing.Point(204, 15);
            this.btnInputstep.Name = "btnInputstep";
            this.btnInputstep.Size = new System.Drawing.Size(85, 20);
            this.btnInputstep.TabIndex = 2;
            this.btnInputstep.Text = "Submit";
            this.btnInputstep.UseVisualStyleBackColor = true;
            this.btnInputstep.Click += new System.EventHandler(this.btnInputstep_Click);
            // 
            // lbRezult
            // 
            this.lbRezult.Location = new System.Drawing.Point(16, 38);
            this.lbRezult.Name = "lbRezult";
            this.lbRezult.Size = new System.Drawing.Size(273, 23);
            this.lbRezult.TabIndex = 3;
            this.lbRezult.Text = "Press Submit";
            this.lbRezult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FibonacciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 84);
            this.Controls.Add(this.lbRezult);
            this.Controls.Add(this.btnInputstep);
            this.Controls.Add(this.lbTextboxinfo);
            this.Controls.Add(this.tbStep);
            this.Name = "FibonacciForm";
            this.Text = "FibonacciForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FibonacciForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Label lbTextboxinfo;
        private System.Windows.Forms.Button btnInputstep;
        private System.Windows.Forms.Label lbRezult;
    }
}
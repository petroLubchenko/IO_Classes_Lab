namespace IO_Classes_Lab
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbDrivers = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbTransportations = new System.Windows.Forms.ListBox();
            this.lbTransportTypes = new System.Windows.Forms.ListBox();
            this.lbRoutes = new System.Windows.Forms.ListBox();
            this.btnEditdr = new System.Windows.Forms.Button();
            this.btnEditttypes = new System.Windows.Forms.Button();
            this.btnEdittrs = new System.Windows.Forms.Button();
            this.btnEditroutes = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnAddtransporttype = new System.Windows.Forms.Button();
            this.btnAddroute = new System.Windows.Forms.Button();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewtransportation = new System.Windows.Forms.Button();
            this.btnCallFibonacci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDrivers
            // 
            this.lbDrivers.FormattingEnabled = true;
            this.lbDrivers.HorizontalScrollbar = true;
            this.lbDrivers.Location = new System.Drawing.Point(13, 54);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.ScrollAlwaysVisible = true;
            this.lbDrivers.Size = new System.Drawing.Size(286, 472);
            this.lbDrivers.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(464, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(264, 36);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbTransportations
            // 
            this.lbTransportations.FormattingEnabled = true;
            this.lbTransportations.HorizontalScrollbar = true;
            this.lbTransportations.Location = new System.Drawing.Point(597, 54);
            this.lbTransportations.Name = "lbTransportations";
            this.lbTransportations.ScrollAlwaysVisible = true;
            this.lbTransportations.Size = new System.Drawing.Size(288, 472);
            this.lbTransportations.TabIndex = 2;
            // 
            // lbTransportTypes
            // 
            this.lbTransportTypes.FormattingEnabled = true;
            this.lbTransportTypes.HorizontalScrollbar = true;
            this.lbTransportTypes.Location = new System.Drawing.Point(891, 54);
            this.lbTransportTypes.Name = "lbTransportTypes";
            this.lbTransportTypes.ScrollAlwaysVisible = true;
            this.lbTransportTypes.Size = new System.Drawing.Size(288, 472);
            this.lbTransportTypes.TabIndex = 3;
            // 
            // lbRoutes
            // 
            this.lbRoutes.FormattingEnabled = true;
            this.lbRoutes.HorizontalScrollbar = true;
            this.lbRoutes.Location = new System.Drawing.Point(305, 54);
            this.lbRoutes.Name = "lbRoutes";
            this.lbRoutes.ScrollAlwaysVisible = true;
            this.lbRoutes.Size = new System.Drawing.Size(286, 472);
            this.lbRoutes.TabIndex = 4;
            // 
            // btnEditdr
            // 
            this.btnEditdr.Location = new System.Drawing.Point(158, 532);
            this.btnEditdr.Name = "btnEditdr";
            this.btnEditdr.Size = new System.Drawing.Size(141, 35);
            this.btnEditdr.TabIndex = 5;
            this.btnEditdr.Text = "Show and Edit driver";
            this.btnEditdr.UseVisualStyleBackColor = true;
            this.btnEditdr.Click += new System.EventHandler(this.btnEditdr_Click);
            // 
            // btnEditttypes
            // 
            this.btnEditttypes.Location = new System.Drawing.Point(1038, 532);
            this.btnEditttypes.Name = "btnEditttypes";
            this.btnEditttypes.Size = new System.Drawing.Size(141, 35);
            this.btnEditttypes.TabIndex = 6;
            this.btnEditttypes.Text = "Show and edit transport type";
            this.btnEditttypes.UseVisualStyleBackColor = true;
            this.btnEditttypes.Click += new System.EventHandler(this.btnEditttypes_Click);
            // 
            // btnEdittrs
            // 
            this.btnEdittrs.Location = new System.Drawing.Point(744, 533);
            this.btnEdittrs.Name = "btnEdittrs";
            this.btnEdittrs.Size = new System.Drawing.Size(141, 35);
            this.btnEdittrs.TabIndex = 8;
            this.btnEdittrs.Text = "Show and edit transportation";
            this.btnEdittrs.UseVisualStyleBackColor = true;
            this.btnEdittrs.Click += new System.EventHandler(this.btnEdittrs_Click);
            // 
            // btnEditroutes
            // 
            this.btnEditroutes.Location = new System.Drawing.Point(450, 533);
            this.btnEditroutes.Name = "btnEditroutes";
            this.btnEditroutes.Size = new System.Drawing.Size(141, 35);
            this.btnEditroutes.TabIndex = 10;
            this.btnEditroutes.Text = "Show and edit route";
            this.btnEditroutes.UseVisualStyleBackColor = true;
            this.btnEditroutes.Click += new System.EventHandler(this.btnEditroutes_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(13, 532);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(141, 35);
            this.btnAddDriver.TabIndex = 11;
            this.btnAddDriver.Text = "Add new driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnAddtransporttype
            // 
            this.btnAddtransporttype.Location = new System.Drawing.Point(891, 533);
            this.btnAddtransporttype.Name = "btnAddtransporttype";
            this.btnAddtransporttype.Size = new System.Drawing.Size(141, 35);
            this.btnAddtransporttype.TabIndex = 12;
            this.btnAddtransporttype.Text = "Add new transport type";
            this.btnAddtransporttype.UseVisualStyleBackColor = true;
            this.btnAddtransporttype.Click += new System.EventHandler(this.btnAddtransporttype_Click);
            // 
            // btnAddroute
            // 
            this.btnAddroute.Location = new System.Drawing.Point(303, 532);
            this.btnAddroute.Name = "btnAddroute";
            this.btnAddroute.Size = new System.Drawing.Size(141, 35);
            this.btnAddroute.TabIndex = 13;
            this.btnAddroute.Text = "Add route";
            this.btnAddroute.UseVisualStyleBackColor = true;
            this.btnAddroute.Click += new System.EventHandler(this.btnAddroute_Click);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(IO_Classes_Lab.Driver);
            // 
            // btnNewtransportation
            // 
            this.btnNewtransportation.Location = new System.Drawing.Point(597, 532);
            this.btnNewtransportation.Name = "btnNewtransportation";
            this.btnNewtransportation.Size = new System.Drawing.Size(141, 35);
            this.btnNewtransportation.TabIndex = 14;
            this.btnNewtransportation.Text = "Add new transportation";
            this.btnNewtransportation.UseVisualStyleBackColor = true;
            this.btnNewtransportation.Click += new System.EventHandler(this.btnNewtransportation_Click);
            // 
            // btnCallFibonacci
            // 
            this.btnCallFibonacci.Location = new System.Drawing.Point(1083, 12);
            this.btnCallFibonacci.Name = "btnCallFibonacci";
            this.btnCallFibonacci.Size = new System.Drawing.Size(97, 36);
            this.btnCallFibonacci.TabIndex = 15;
            this.btnCallFibonacci.Text = "Fibonacci creator";
            this.btnCallFibonacci.UseVisualStyleBackColor = true;
            this.btnCallFibonacci.Click += new System.EventHandler(this.btnCallFibonacci_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 573);
            this.Controls.Add(this.btnCallFibonacci);
            this.Controls.Add(this.btnNewtransportation);
            this.Controls.Add(this.btnAddroute);
            this.Controls.Add(this.btnAddtransporttype);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.btnEditroutes);
            this.Controls.Add(this.btnEdittrs);
            this.Controls.Add(this.btnEditttypes);
            this.Controls.Add(this.btnEditdr);
            this.Controls.Add(this.lbRoutes);
            this.Controls.Add(this.lbTransportTypes);
            this.Controls.Add(this.lbTransportations);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbDrivers);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.Validated += new System.EventHandler(this.MainForm_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDrivers;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lbTransportations;
        private System.Windows.Forms.ListBox lbTransportTypes;
        private System.Windows.Forms.ListBox lbRoutes;
        private System.Windows.Forms.Button btnEditdr;
        private System.Windows.Forms.Button btnEditttypes;
        private System.Windows.Forms.Button btnEdittrs;
        private System.Windows.Forms.Button btnEditroutes;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnAddtransporttype;
        private System.Windows.Forms.Button btnAddroute;
        private System.Windows.Forms.Button btnNewtransportation;
        private System.Windows.Forms.Button btnCallFibonacci;
    }
}


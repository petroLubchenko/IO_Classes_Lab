using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Classes_Lab
{
    public partial class ShowTransportType : Form
    {
        public ShowTransportType(TransportType transporttype, MainForm mainform)
        {
            InitializeComponent();
            mf = mainform;
            this.transporttype = transporttype;
        }
        private MainForm mf;
        private TransportType transporttype;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
                tbName.Text = tbCargo.Text;
            if (String.IsNullOrWhiteSpace(tbCargo.Text))
                tbCargo.Text = tbName.Text;
            transporttype.ChangeData(tbName.Text, tbCargo.Text);
        }

        private void ShowTransportType_Shown(object sender, EventArgs e)
        {
            ShowData();
        }
        private void ShowData()
        {
            tbName.Text = transporttype.Name;
            tbCargo.Text = transporttype.Cargo;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TransportType.Delete(transporttype);
            Close();
        }

        private void ShowTransportType_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Show();
            mf.Validate();
        }
    }
}

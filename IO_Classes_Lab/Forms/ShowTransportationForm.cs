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
    public partial class ShowTransportationForm : Form
    {
        public ShowTransportationForm(Transportation transportation, MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.transportation = transportation;
        }
        MainForm mf;
        Transportation transportation;

        private void cbTransporttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            transportation.TransportType = (TransportType)cbTransporttype.SelectedItem;
        }




        private void ShowData()
        {
            lbInfo.Text = transportation.ToString();
            tbDistance.Text = transportation.Length.ToString();
            tbIncome.Text = transportation.Income.ToString();
            tbSpending.Text = transportation.Spending.ToString();
            cbTransporttype.Items.Clear();
            cbTransporttype.Items.AddRange(TransportType.TransportTypes.ToArray());
            if (transportation.TransportType != null)
                cbTransporttype.Text = transportation.TransportType.ToString();
        }

        private void ShowTransportationForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            try
            {
                transportation.ChangeLength(Int32.Parse(tbDistance.Text));
                transportation.ChangeIncome(Decimal.Parse(tbIncome.Text));
                transportation.ChangeSpending(Decimal.Parse(tbSpending.Text));
            }
            catch { }
            finally{
                ShowData();
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            try
            {
                transportation.ChangeLength(Int32.Parse(tbDistance.Text));
                transportation.ChangeIncome(Decimal.Parse(tbIncome.Text));
                transportation.ChangeSpending(Decimal.Parse(tbSpending.Text));
            }
            catch { }
            finally
            {
                ShowData();
            }
        }

        private void btnSpending_Click(object sender, EventArgs e)
        {
            try
            {
                transportation.ChangeLength(Int32.Parse(tbDistance.Text));
                transportation.ChangeIncome(Decimal.Parse(tbIncome.Text));
                transportation.ChangeSpending(Decimal.Parse(tbSpending.Text));
            }
            catch { }
            finally
            {
                ShowData();
            }
        }

        private void ShowTransportationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Show();
            mf.Validate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Transportation.Delete(transportation);
            Close();
        }
    }
}

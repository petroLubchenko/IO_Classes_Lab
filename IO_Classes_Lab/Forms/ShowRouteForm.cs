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
    public partial class ShowRouteForm : Form
    {
        public ShowRouteForm(Route route, MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.route = route;
        }
        private MainForm mf;
        private Route route;

        private void ShowRouteForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ShowInfo()
        {
            lbInfo.Text = route.ToString();
            tbNumber.Text = route.Number.ToString();
            ShowTransportTypes();
            ShowAgreements();
        }
        private void ShowTransportTypes()
        {
            cbTransporttype.Items.Clear();
            if (TransportType.TransportTypes != null)
                cbTransporttype.Items.AddRange(TransportType.TransportTypes.ToArray());
            cbTransporttype.Text = route.TransportType != null ? route.TransportType.ToString() : "";
        }
        private void ShowAgreements()
        {
            lbTransportations.Items.Clear();
            bool isEqual = true;
            if (lbTransportations.Items.Count != route.GetTransportations().Count)
            {
                isEqual = false;
                foreach (var l in lbTransportations.Items)
                    if (route.GetTransportations().IndexOf(((RouteTransportationAgreement)l).Transportation) == -1)
                    {
                        isEqual = false;
                        break;
                    };
            }
            if (!isEqual)
                lbTransportations.Items.AddRange(route.GetTransportations().ToArray());
        }

        private void ShowRouteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Show();
            mf.Validate();
        }

        private void btnSetnumber_Click(object sender, EventArgs e)
        {
            try
            {
                route.ChangeNumber(Convert.ToInt32(tbNumber.Text));
            }
            catch
            {
            }
            finally
            {
                ShowInfo();
            }
        }

        private void cbTransporttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransporttype.SelectedItem != route.TransportType)
                foreach (var rta in route.GetTransportations())
                    RouteTransportationAgreement.Delete(rta);
            route.SetTransportType((TransportType)cbTransporttype.SelectedItem);
        }

        private void lbTransportations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTransportations.SelectedIndex == -1)
            {
                lbRouteshow.Visible = false;
                lbTransptypeshow.Visible = false;
                lbRouteshow.Text = String.Empty;
                lbTransptypeshow.Text = String.Empty;
            }
            else
            {
                RouteTransportationAgreement rta = (RouteTransportationAgreement)lbTransportations.SelectedItem;
                lbRouteshow.Visible = true;
                lbTransptypeshow.Visible = true;
                lbRouteshow.Text = rta.Route.ToString();
                lbTransptypeshow.Text = rta.Transportation.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbTransportations.SelectedItem != null)
                RouteTransportationAgreement.Delete((RouteTransportationAgreement)lbTransportations.SelectedItem);
            ShowInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRouteTranspAggr arta = new AddRouteTranspAggr(route);
            arta.ShowDialog();
            ShowInfo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Route.Remove(route);
        }
    }
}

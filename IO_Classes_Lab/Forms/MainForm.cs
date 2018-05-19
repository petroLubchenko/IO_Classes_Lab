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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        



        private void FillLBs()
        {
            lbDrivers.BeginUpdate();
            ClearLBs();
            foreach (Driver dr in Driver.Drivers)
                lbDrivers.Items.Add(dr);
            foreach (var r in Route.Routes)
                lbRoutes.Items.Add(r);
            foreach (var tr in Transportation.Transportations)
                lbTransportations.Items.Add(tr);
            foreach (var tt in TransportType.TransportTypes)
                lbTransportTypes.Items.Add(tt);
            lbDrivers.EndUpdate() ;
        }
        private void ClearLBs()
        {
            lbDrivers.Items.Clear();
            lbRoutes.Items.Clear();
            lbTransportations.Items.Clear();
            lbTransportTypes.Items.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillLBs();
        }

        private void btnEditdr_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedItem != null) {
                ShowDriverForm showdr = new ShowDriverForm((Driver) lbDrivers.SelectedItem, this);
                Hide();
                showdr.ShowDialog();
            }
        }

        private void MainForm_Validated(object sender, EventArgs e)
        {
            FillLBs();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            FillLBs();
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            // Deleting drivers with white names
            if (this.Visible == true)
                foreach (Driver dr in Driver.Drivers)
                    if (String.IsNullOrWhiteSpace(dr.FirstName) && String.IsNullOrWhiteSpace(dr.SecondName))
                        Driver.Drivers.Remove(dr);

            // Deleting 'white' transporttypes 
            if (this.Visible == true)
                foreach (TransportType tt in TransportType.TransportTypes)
                    if (String.IsNullOrWhiteSpace(tt.Name) && String.IsNullOrWhiteSpace(tt.Cargo))
                        TransportType.TransportTypes.Remove(tt);

            // Deleting 'white' routes
            if (this.Visible == true)
                foreach (Route rt in Route.Routes)
                    if (rt.TransportType == null)
                        Route.Routes.Remove(rt);

            // Deleting 'white' transportations
            if (this.Visible == true)
                foreach (Transportation tr in Transportation.Transportations)
                    if (tr.TransportType == null && tr.Income == 0 && tr.Spending == 0 && tr.Length == 0)
                        Transportation.Transportations.Remove(tr);

            FillLBs();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            ShowDriverForm showdr = new ShowDriverForm(new Driver(" ", " "), this);
            Hide();
            showdr.ShowDialog();
        }

        private void btnEditttypes_Click(object sender, EventArgs e)
        {
            if (lbTransportTypes.SelectedItem != null)
            {
                ShowTransportType showdr = new ShowTransportType((TransportType)lbTransportTypes.SelectedItem, this);
                Hide();
                showdr.ShowDialog();
            }
        }

        private void btnAddtransporttype_Click(object sender, EventArgs e)
        {
            ShowTransportType showtt = new ShowTransportType(new TransportType(), this);
            Hide();
            showtt.ShowDialog();
        }

        private void btnEditroutes_Click(object sender, EventArgs e)
        {
            if (lbRoutes.SelectedItem != null)
            {
                ShowRouteForm srf = new ShowRouteForm((Route) lbRoutes.SelectedItem, this);
                Hide();
                srf.ShowDialog();
            }
        }

        private void btnAddroute_Click(object sender, EventArgs e)
        {
            ShowRouteForm srf = new ShowRouteForm(new Route((string)null), this);
            Hide();
            srf.ShowDialog();
        }

        private void btnEdittrs_Click(object sender, EventArgs e)
        {
            if (lbTransportations.SelectedItem != null)
            {
                ShowTransportationForm stf = new ShowTransportationForm((Transportation)lbTransportations.SelectedItem, this);
                Hide();
                stf.ShowDialog();
            }
        }

        private void btnNewtransportation_Click(object sender, EventArgs e)
        {
            ShowTransportationForm stf = new ShowTransportationForm(new Transportation(0, 0, 0), this);
            Hide();
            stf.ShowDialog();
        }

        private void btnCallFibonacci_Click(object sender, EventArgs e)
        {
            /*FibonacciForm ff = new FibonacciForm(this);
            Hide();
            ff.ShowDialog();*/
            GC.Collect();
        }
    }
}

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
    public partial class AddRouteTranspAggr : Form
    {
        public AddRouteTranspAggr(Route route)
        {
            InitializeComponent();
            this.route = route;
        }
        private Route route;

        private void ShowData()
        {
            lbRoute.Text = route.ToString();
            List<Transportation> trion = new List<Transportation>();
            if (route.TransportType != null)
                foreach (var tion in Transportation.Transportations)
                    if (route.TransportType == tion.TransportType)
                        trion.Add(tion);
            cbTransportations.Items.AddRange(trion.ToArray());
        }

        private void AddRouteTranspAggr_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbTransportations.SelectedItem != null)
            {
                new RouteTransportationAgreement(route, (Transportation)cbTransportations.SelectedItem);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

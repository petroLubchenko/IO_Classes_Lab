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
    public partial class ShowDriverForm : Form
    {
        public ShowDriverForm(Driver driver, MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.driver = driver;
            Validate();
        }
        private MainForm mf;
        private Driver driver;
        private void ShowDriverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            mf.Show();
            mf.Validate();
        }

        private void ShowDriverForm_Shown(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void ShowDriverForm_Validated(object sender, EventArgs e)
        {
            ShowInfo();
        }
        private void ShowInfo()
        {
            lbDriver.Text = driver.ToString();
            tbFirstname.Text = driver.FirstName;
            tbSecname.Text = driver.SecondName;
            GenerateRoutes();
            ShowLicenses();
        }
        private void GenerateRoutes()
        {
            
            List<Route> rt = new List<Route>();
            foreach(Route r in Route.Routes)
            {
                if (driver.TransportTypes.IndexOf(r.TransportType) != -1 && cbroute.Items.IndexOf(r) == -1)
                    rt.Add(r);

            }
            cbroute.Items.AddRange(rt.ToArray());
            Route rs = driver.Route;
            if (rs != null)
            {
                int index = cbroute.Items.IndexOf(rs);
                cbroute.Text = rs.ToString();
            }
        }
        private void ShowLicenses()
        {
            lbLicenses.Items.Clear();
            bool isEqual = true;
            if (lbLicenses.Items.Count != driver.Licenses.Count)
            {
                isEqual = false;
                foreach (var l in lbLicenses.Items)
                    if (driver.Licenses.IndexOf((License)l) == -1)
                    {
                        isEqual = false;
                        break;
                    };
            }
            if (!isEqual)
                lbLicenses.Items.AddRange(driver.Licenses.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddLicense addlic = new AddLicense(driver);
            addlic.ShowDialog();
            Validate();
        }

        private void Validator_Tick(object sender, EventArgs e)
        {
            /*Validate();*/
            ShowLicenses();
            GenerateRoutes();
        }

        private void btnEditfn_Click(object sender, EventArgs e)
        {
            driver.ChangeName(tbFirstname.Text, tbSecname.Text);
            ShowInfo();
        }

        private void btnEditsn_Click(object sender, EventArgs e)
        {
            driver.ChangeName(tbFirstname.Text, tbSecname.Text);
            ShowInfo();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbLicenses.SelectedItem != null)
                License.Delete((License)lbLicenses.SelectedItem);
            lbLicenses.Items.Clear();
            ShowLicenses();
        }

        private void btnEditroute_Click(object sender, EventArgs e)
        { }

        private void cbroute_SelectedIndexChanged(object sender, EventArgs e)
        {
            driver.SetRoute((Route)cbroute.SelectedItem);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                Driver.Delete(driver);
                Close();
        }

        private void lbLicenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            License lic = (License)lbLicenses.SelectedItem;
            if (lic == null)
            {
                lblicdr.Text = "";
                lblictt.Text = "";
            }
            else
            {
                lblicdr.Text = lic.Driver.ToString();
                lblictt.Text = lic.TransportType.ToString();
            }
        }
    }
}

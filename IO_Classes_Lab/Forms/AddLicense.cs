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
    public partial class AddLicense : Form
    {
        public AddLicense(Driver driver)
        {
            InitializeComponent();
            this.driver = driver;
        }
        private Driver driver;

        private void AddLicense_Load(object sender, EventArgs e)
        {
            lbDriver.Text = driver.ToString();
            lbTransportTypes.Items.AddRange(TransportType.TransportTypes.ToArray());
        }

        private void lbTransportTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTransportTypes.SelectedIndex == -1)
            {
                btnAdd.Visible = false;
            } else
            {
                btnAdd.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TransportType tt = (TransportType)lbTransportTypes.SelectedItem;
            if (driver.GetId() != null && tt.GetId() != null && !License.IsExist(driver, tt))
            {
                new License(driver, tt);
                Close();
            }
        }
    }
}

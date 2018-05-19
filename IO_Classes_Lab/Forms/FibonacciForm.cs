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
    public partial class FibonacciForm : Form
    {
        public FibonacciForm(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }
        private MainForm mf;

        private void FibonacciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Show();
        }

        private Int32 Fibonacci(int prev, int now, int step, int waitedstep)
        {
            if (step == waitedstep)
                return prev + now;
            return Fibonacci(now, prev + now, step + 1, waitedstep);
        }
        private Int32 Fibonacci(int waitedstep)
        {
            if (waitedstep < 0)
                return -1;
            if (waitedstep == 0)
                return 0;
            if (waitedstep <= 2)
                return 1;
            return Fibonacci(1, 1, 3, waitedstep);
        }

        private void btnInputstep_Click(object sender, EventArgs e)
        {
            try
            {
                lbRezult.Text = Fibonacci(Int32.Parse(tbStep.Text)).ToString();
            }
            catch {
                lbRezult.Text = "Error";
            }
        }
    }
}

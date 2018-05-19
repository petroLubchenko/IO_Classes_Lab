using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Classes_Lab
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Driver("Vasya", "iavnov");
            new Route(new TransportType("Passengers", "Passengers"));
            new Transportation(369, 900, 899, TransportType.TransportTypes[0]);

            Application.Run(new MainForm());
        }
    }
}

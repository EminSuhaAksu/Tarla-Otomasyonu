using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SefForm());
            Application.Run(new LogingForm());
            //Application.Run(new SefUrunEkle());
            //Application.Run(new MuhasebeForm());
            //Application.Run(new YoneticiForm());
        }
    }
}

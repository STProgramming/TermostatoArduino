using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Domus
{
    static class Program 
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Form1 myObj = new Form1();
            while(!string.IsNullOrEmpty(myObj.Mainport))
            {
                Application.Run(new Form2());
                
            }
        }
    }
}

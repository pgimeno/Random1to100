using Dark.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random1to100
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDarkNet darkNet = DarkNet.Instance;
            Theme processTheme = Theme.Dark;
            darkNet.SetCurrentProcessTheme(processTheme);
            

            Form mainForm = new Form1();
            Theme windowTheme = Theme.Auto;
            darkNet.SetWindowThemeForms(mainForm, windowTheme);     

         
            Application.Run(mainForm);
        }
    }
}

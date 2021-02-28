

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    static class Program
    {
        /// <summary>
        /// La función Main es el punto de inicio de nuestra aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // // muestra  la ventana  nueva forma 1.
            Application.Run(new Form1());
        }
    }
}

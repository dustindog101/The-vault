using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_vault
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
            if (Internals.checklogin() == true)//if the users are logged in
            {

                MessageBox.Show($"Welcome back, {Internals.grabusername()}!", "Welcome!");
                Application.Run(new MainForm());//start main form
               
            }
            else
            {
                Application.Run(new Login());//start login form
            }
            
        }
    }
}

/* Carlos E. Gonzalez
 * Danessa Yip
 * Virginia Gonzalez
 * 
 * Final Project - Delicioso E-Ristorante Menu
 * 05/28/2021
 */

using System;
using System.Windows.Forms;

namespace Delicioso_E_Ristorante_Menu
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
            Application.Run(new frmMenu());
        }
    }
}

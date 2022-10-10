/* Carlos E. Gonzalez
 * Danessa Yip
 * Virginia Gonzalez
 * 
 * Final Project - Delicioso E-Ristorante Menu
 * 05/28/2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delicioso_E_Ristorante_Menu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function runs when the form first loads. Used for initial setups.
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplashWindow splash = new frmSplashWindow();
            splash.ShowDialog();
            splash.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

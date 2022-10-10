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
    public partial class frmSplashWindow : Form
    {
        public frmSplashWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Splash window's initialization.
        /// </summary>
        private void frmSplashWindow_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None; // Boderless
            WindowState = FormWindowState.Maximized; // Start maximized
            tmrSplash.Interval = 4000; // 4000 milliseconds, e.i, 4 seconds.
            tmrSplash.Start();
        }

        /// <summary>
        /// This code runs for every time interval that the timer's ticks. Closes the window after four seconds.
        /// </summary>
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class frmSplashWindow : Form
    {
        public frmSplashWindow()
        {
            InitializeComponent();
        }

        /// <summary> This code runs when the form first loads and is used for initial setup. </summary>
        private void frmSplashWindow_Load(object sender, EventArgs e)
        {
            tmrSplash.Interval = 4000; // 4000 milliseconds, e.i, 4 seconds.
            tmrSplash.Start();
        }

        /// <summary> This code runs every time that the timer's interval ticks. </summary>
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            Close(); // Closes the window after four seconds.
        }
    }
}

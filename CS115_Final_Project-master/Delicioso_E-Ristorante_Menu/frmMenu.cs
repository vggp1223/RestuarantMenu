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
    public partial class frmMenu : Form
    {
        public frmMenu()
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

            #region Create a placeholder image. Delete later.
            Bitmap temp = new Bitmap(256, 256);
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                    temp.SetPixel(i, j, System.Drawing.Color.DarkTurquoise);

            pictureBox1.Image = temp;
            pictureBox2.Image = temp;
            pictureBox3.Image = temp;
            pictureBox4.Image = temp;
            #endregion
        }
    }
}

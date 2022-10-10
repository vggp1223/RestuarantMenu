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
    public partial class frmMain : Form
    {
        /// <summary> This variable is used to keep track of the current receipt number. </summary>
        internal static int receiptNumber = 0;
        
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary> This function runs when the form first loads. Used for initial setups. </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Display the splash page to the user before the main form.
            frmSplashWindow splash = new frmSplashWindow();
            splash.ShowDialog();
        }

        /// <summary> Display the Menu form. </summary>
        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        /// <summary> Display the Order form. </summary>
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.ShowDialog();
        }

        /// <summary> Display the Receipt form. </summary>
        private void btnViewReceipt_Click(object sender, EventArgs e)
        {
            if (frmOrder.orderSubmitted) // Check that user made an order before showing them the receipt.
            {
                frmViewReceipt receipt = new frmViewReceipt();
                receipt.ShowDialog();
            }
            else // If they haven't display an error message.
                MessageBox.Show("An order has not been made yet.\nUnable to display receipt.");
        }

        /// <summary> Display the Payment form. </summary>
        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            if (frmOrder.orderSubmitted) // Check that user made an order before showing them the payment window.
            {
                frmPayment payment = new frmPayment();
                payment.ShowDialog();
            }
            else // If they haven't display an error message.
                MessageBox.Show("An order has not been made yet.\nUnable to display payment window.");
        }

        /// <summary> This method performs the necesary setups to accept a new order. </summary>
        internal static void newOrder()
        {
            frmOrder.orderSubmitted = false; // Set order submitted back to false.
            frmOrder.custumerName = "Custumer"; // Set the name to the default Custumer.
            frmOrder.currentOrder = new ListBox(); // Assign to currentOrder the reference of a new ListBox object.
            frmOrder.mainDishOrders = new int[frmOrder.NUMBER_MAIN_DISHES]; // Assign to the Orders int arrays a reference to a new int array object.
            frmOrder.saladOrders = new int[frmOrder.NUMBER_SALADS];
            frmOrder.beverageOrders = new int[frmOrder.NUMBER_BEVERAGES];
            frmOrder.dessertOrders = new int[frmOrder.NUMBER_DESSERTS];
            frmViewReceipt.tipAmount = 0; // Set tip amount to 0.
            frmViewReceipt.currentReceipt = new ListBox(); // Assign to currentReceipt the reference of a new ListBox object.
            receiptNumber++; // Increment the receipt number.
        }
    }
}

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
    public partial class frmViewReceipt : Form
    {
        /// <summary> Constant double for the percentage of sales taxes charges. </summary>
        private const double SALES_TAX = 0.095;
        private double subtotal = 0;
        private double salesTax = 0;
        private double total = 0;
        internal static double tipAmount = 0;

        /// <summary> ListBox object used to keep track of the user's most recent receipt for printing. </summary>
        internal static ListBox currentReceipt = new ListBox();

        public frmViewReceipt()
        {
            InitializeComponent();
        }

        /// <summary> This code runs when the form first loads and is used for initial setup. </summary>
        private void frmViewReceipt_Load(object sender, EventArgs e)
        {
            // When the View Receipt form loads, it determines what and how much the user has ordered of each item.

            for (frmMenu.mainDish i = 0; i <= frmMenu.mainDish.zitiAlForno; i++)
            {
                if (frmOrder.mainDishOrders[(int)i] > 0) // If any element in the Orders arrays is greater than 0...
                {
                    for (byte j = 0; j < frmOrder.mainDishOrders[(int)i]; j++) // the corresponding item is added to the bill individually.
                    {
                        lstItemizedBill.Items.Add(String.Format("{0}{1}", // We display the item name and price.
                            frmMenu.mainDishTitles[(int)i].PadRight(40, '.'), frmMenu.mainDishesPrices[(int)i].ToString("C2")));

                        subtotal += frmMenu.mainDishesPrices[(int)i]; // The running total is updated.
                    }
                }
            }

            // We do the same operation as above for each menu category.

            for (frmMenu.salad i = 0; i <= frmMenu.salad.bocconcini; i++)
            {
                if (frmOrder.saladOrders[(int)i] > 0)
                {
                    for (byte j = 0; j < frmOrder.saladOrders[(int)i]; j++)
                    {
                        lstItemizedBill.Items.Add(String.Format("{0}{1}",
                            frmMenu.saladsTitles[(int)i].PadRight(40, '.'), frmMenu.saladsPrices[(int)i].ToString("C2")));

                        subtotal += frmMenu.saladsPrices[(int)i];
                    }
                }
            }

            for (frmMenu.beverage i = 0; i <= frmMenu.beverage.bellini; i++)
            {
                if (frmOrder.beverageOrders[(int)i] > 0)
                {
                    for (byte j = 0; j < frmOrder.beverageOrders[(int)i]; j++)
                    {
                        lstItemizedBill.Items.Add(String.Format("{0}{1}",
                            frmMenu.beveragesTitles[(int)i].PadRight(40, '.'), frmMenu.beveragesPrices[(int)i].ToString("C2")));

                        subtotal += frmMenu.beveragesPrices[(int)i];
                    }
                }
            }

            for (frmMenu.dessert i = 0; i <= frmMenu.dessert.semifreddo; i++)
            {
                if (frmOrder.dessertOrders[(int)i] > 0)
                {
                    for (byte j = 0; j < frmOrder.dessertOrders[(int)i]; j++)
                    {
                        lstItemizedBill.Items.Add(String.Format("{0}{1}",
                            frmMenu.dessertsTitles[(int)i].PadRight(40, '.'), frmMenu.dessertsPrices[(int)i].ToString("C2")));

                        subtotal += frmMenu.dessertsPrices[(int)i];
                    }
                }
            }

            // By this point we already now the order subtotal.
            lblSubtotalValue.Text = subtotal.ToString("C2"); // We display the subtotal.
            salesTax = subtotal * SALES_TAX; // We calculate the sales tax.
            lblSalesTaxesValue.Text = salesTax.ToString("C2"); // We display the sales tax.

            if (tipAmount > 0) // If a tip amount was previously selected by the custumer...
            {
                radOther.Checked = true; // We select the Other Amount radial button
                txtTipAmount.Text = tipAmount.ToString("F2"); // We put that tip amount in the TipAmount text box.
                txtTipAmount.Enabled = true; // And we enable said text box and the Confirm Tip button.
                btnComfirmTip.Enabled = true;

            }

            lblTipValue.Text = tipAmount.ToString("C2"); // We display the tip
            total = subtotal + salesTax + tipAmount; // We calculate the total
            lblTotalValue.Text = total.ToString("C2"); // And finally we display the total
            makeReceipt(); // Update the current receipt for printing.
        }

        /// <summary> This method updates the currentReceipt ListBox object so that it may be printed in the Payment form. </summary>
        private void makeReceipt()
        {
            currentReceipt.Items.Clear(); // Clear the currentReceipt of any items to avoid duplicates.
            currentReceipt.Items.AddRange(lstItemizedBill.Items); // Copy the elements of the ItemizedBill listbox onto currentReceipt.
            currentReceipt.Items.Add("");
            currentReceipt.Items.Add("".PadRight(46, '-'));
            currentReceipt.Items.Add(""); // Add the contents of the variables
            currentReceipt.Items.Add("Subtotal:".PadRight(40, '.') + subtotal.ToString("C2"));
            currentReceipt.Items.Add("Sales tax:".PadRight(40, '.') + salesTax.ToString("C2"));
            currentReceipt.Items.Add("Tip:".PadRight(40, '.') + tipAmount.ToString("C2"));
            currentReceipt.Items.Add("Total:".PadRight(40, '.') + total.ToString("C2"));
        }

        // Below are the event handlers for when the radial buttons change.

        private void radNoTip_CheckedChanged(object sender, EventArgs e)
        {
            if (radNoTip.Checked) // We check each button to see if the button has changecdto this button.
            {
                tipAmount = 0.0; // Set the appropiate tip amount.
                total = subtotal + salesTax + tipAmount; // Recalculate the total to reflect the new tip.
                lblTipValue.Text = tipAmount.ToString("C2"); // Display the new tip amount.
                lblTotalValue.Text = total.ToString("C2"); // Display the new total.

                // Disable the TipAmount textbox and ConfirmTip button.
                txtTipAmount.Enabled = false;
                btnComfirmTip.Enabled = false;
                makeReceipt(); // Update the receipt for printing.
            }
        }

        // The remainer of the radial buttons, with the exception of radOther, are identical to the one above.
        // The only difference is the formula to calculate the tip amount depending of which button is used.

        private void radFivePercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radFivePercent.Checked)
            {
                tipAmount = 0.05 * subtotal; // 5%
                total = subtotal + salesTax + tipAmount;
                lblTipValue.Text = tipAmount.ToString("C2");
                lblTotalValue.Text = total.ToString("C2");

                txtTipAmount.Enabled = false;
                btnComfirmTip.Enabled = false;
                makeReceipt();
            }
        }

        private void radTenPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenPercent.Checked)
            {
                tipAmount = 0.1 * subtotal; // 10%
                total = subtotal + salesTax + tipAmount;
                lblTipValue.Text = tipAmount.ToString("C2");
                lblTotalValue.Text = total.ToString("C2");

                txtTipAmount.Enabled = false;
                btnComfirmTip.Enabled = false;
                makeReceipt();
            }
        }

        private void radFifteenPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radFifteenPercent.Checked)
            {
                tipAmount = 0.15 * subtotal; // 15%
                total = subtotal + salesTax + tipAmount;
                lblTipValue.Text = tipAmount.ToString("C2");
                lblTotalValue.Text = total.ToString("C2");

                txtTipAmount.Enabled = false;
                btnComfirmTip.Enabled = false;
                makeReceipt();
            }
        }

        private void radTwentyFivePercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radTwentyFivePercent.Checked)
            {
                tipAmount = 0.25 * subtotal; // 25%
                total = subtotal + salesTax + tipAmount;
                lblTipValue.Text = tipAmount.ToString("C2");
                lblTotalValue.Text = total.ToString("C2");

                txtTipAmount.Enabled = false;
                btnComfirmTip.Enabled = false;
                makeReceipt();
            }
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            // This button allows the user to enter whatever amount (not a percentage) they want to give as tip.
            
            if (radOther.Checked)
            {
                total = subtotal + salesTax + tipAmount;
                lblTipValue.Text = tipAmount.ToString("C2");
                lblTotalValue.Text = total.ToString("C2");

                // Enable the TipAmount textbox and the ConfirmTip button.
                txtTipAmount.Enabled = true;
                btnComfirmTip.Enabled = true;
            }
        }

        /// <summary> This button confirms the user input for tip amount. </summary>
        private void btnComfirmTip_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtTipAmount.Text, out tipAmount)) // Try to parse the user input amout.
            {
                if (tipAmount > 0) // Ensure the quantity is not negative.
                {
                    // If the user's input amount is valid, we recalculate the total and display the new total and tip amount.
                    total = subtotal + salesTax + tipAmount;
                    lblTipValue.Text = tipAmount.ToString("C2");
                    lblTotalValue.Text = total.ToString("C2");
                    makeReceipt(); // Update the receipt for printing.
                }
                else
                    MessageBox.Show("Tip amount cannot be a negative number."); // Display an error message is the input amount is negative.
            }
            else
                MessageBox.Show("Please enter a numerical value for the tip amount."); // Display an error message if the input amount is not numerical.
        }
    }
}

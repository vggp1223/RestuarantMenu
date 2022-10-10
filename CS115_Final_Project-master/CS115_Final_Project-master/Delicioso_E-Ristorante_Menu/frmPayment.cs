/* Carlos E. Gonzalez
 * Danessa Yip
 * Virginia Gonzalez
 * 
 * Final Project - Delicioso E-Ristorante Menu
 * 05/28/2021
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace Delicioso_E_Ristorante_Menu
{
    public partial class frmPayment : Form
    {
        /// <summary> Enum for the methods of payments that the restaurant accepts. </summary>
        enum paymentMethod { cash, credit, debit }

        /// <summary> Variable used to determine what method of payment the custumer used. </summary>
        paymentMethod payment;

        public frmPayment()
        {
            InitializeComponent();
        }

        /// <summary> This code runs when the form first loads and is used for initial setup. </summary>
        private void frmPayment_Load(object sender, EventArgs e)
        {
            // If the user has not already seen their receipt, show it to them before accepting payment.
            if (frmViewReceipt.currentReceipt.Items.Count == 0)
            {
                frmViewReceipt receipt = new frmViewReceipt();
                receipt.ShowDialog();
            }
        }

        /// <summary> Method to obtain selected payment option. </summary>
        private void getPaymentOption()
        {
            if (radCash.Checked)
            {
                MessageBox.Show("Please wait shortly for your waiter to collect your payment.\nThank you!");
                payment = paymentMethod.cash;

                printReceipt(); // Print the receipt to a text file.
                frmMain.newOrder(); // Perform the necessary setup to accept a new order.
                Close(); // Close the payment form.
            }

            else
            {
                // If any card option is selected, then prompt for card details
                gbxCardDetails.Visible = true;

                // Assigns the first value from each list to their respective combo box 
                cmbxExpMonth.SelectedIndex = 0;
                cmbxExpYear.SelectedIndex = 0;

                // If Debit card is selected, then the pin number option is displayed
                if (radDebit.Checked)
                {
                    lblPinNumber.Visible = true;
                    txtPinNumber.Visible = true;
                }
            }
        }

        private void btnSubmitPaymentMethod_Click(object sender, EventArgs e)
        {
            getPaymentOption();
            gbxPayment.Visible = false;
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            long cardNum = 0; // To hold the user's card number
            int pinNum = 0; // To hold the user's pin number

            // Set max length on user input
            txtCardNumber.MaxLength = 16; // Max digits for a credit card
            txtPinNumber.MaxLength = 3; // Max digits for a pin number

            // Error checks for any card number
            if (!long.TryParse(txtCardNumber.Text, out cardNum) || (txtCardNumber.TextLength < txtCardNumber.MaxLength))
            {
                MessageBox.Show("Please enter 16 digits for the card number.");
            }
            else
            {
                // Error checks for debit card only
                if (radDebit.Checked)
                {
                    if ((!int.TryParse(txtPinNumber.Text, out pinNum)) || txtPinNumber.TextLength < txtPinNumber.MaxLength)
                        MessageBox.Show("Please enter 3 digits for the pin number.");
                    // Display success message for debit card
                    else
                    {
                        MessageBox.Show("Debit card payment is processing...");
                        MessageBox.Show("Payment Accepted!");
                        payment = paymentMethod.debit;

                        printReceipt(); // Print the receipt to a text file.
                        frmMain.newOrder(); // Perform the necessary setup to accept a new order.
                        Close(); // Close the payment form.
                    }
                }
                // If not a debit card then it displays a success message for credit card
                else
                {
                    MessageBox.Show("Credit card payment is processing...");
                    MessageBox.Show("Payment Accepted!");
                    payment = paymentMethod.debit;

                    printReceipt(); // Print the receipt to a text file.
                    frmMain.newOrder(); // Perform the necessary setup to accept a new order.
                    Close(); // Close the payment form.
                }
            }
        }

        /// <summary> This method is responsible for printing the receipt to a text file when the user makes a payment. </summary>
        private void printReceipt()
        {
            TextWriter outputFile = null; // File handler for output text file.
            DateTime receiptDateTime = DateTime.Now;// DateTime object initialized to the day and time the receipt was made.

            try
            {
                // Attempt to create a text file for output using the receipt number.
                outputFile = File.CreateText("receipt_" + frmMain.receiptNumber.ToString("D4") + ".txt");
                
                outputFile.WriteLine("Delicioso E-Ristorante"); // Restaurant's name
                outputFile.WriteLine("Rceipt date: " + receiptDateTime.ToString()); // Receipt's date and time
                outputFile.WriteLine("Custumer's name: " + frmOrder.custumerName); // Custumer's name
                outputFile.WriteLine("Receipt #" + frmMain.receiptNumber.ToString("D4") + '\n'); // Receipt #
                outputFile.WriteLine("".PadRight(46, '-') + '\n');

                foreach (var item in frmViewReceipt.currentReceipt.Items) // List all the items on the custumer's order
                    outputFile.WriteLine(item.ToString());


                outputFile.Write("\nPayment method: ");
                switch (payment) // Determine which payment method the custumer use.
                {
                    case paymentMethod.cash:
                        outputFile.WriteLine("Cash"); // Write the appropiate text depending on the payment method.
                        break;

                    case paymentMethod.credit:
                        outputFile.WriteLine("Credit card XXXX-XXXX-XXXX-" + txtCardNumber.Text.Substring(12, 4));
                        break; // For cards, use only the last four digits.

                    case paymentMethod.debit:
                        outputFile.WriteLine("Debit card XXXX-XXXX-XXXX-" + txtCardNumber.Text.Substring(12, 4));
                        break; // No default case needed.
                }
                
                outputFile.Close(); // Close the file handler.
            }
            catch // If an error occurred during file output, display an error message.
            {
                MessageBox.Show("Error Printing Receipt.");
            }
            finally // In the event that an exception was thrown before the file handler was closed, close it in the finally clause.
            {
                if (outputFile != null)
                    outputFile.Close();
            }
        }
    }
}

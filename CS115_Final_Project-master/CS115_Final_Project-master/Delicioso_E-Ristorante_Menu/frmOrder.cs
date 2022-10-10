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
    public partial class frmOrder : Form
    {
        // Byte constants that represent the number of items in each menu category.
        internal const byte NUMBER_MAIN_DISHES = 10;
        internal const byte NUMBER_SALADS = 5;
        internal const byte NUMBER_BEVERAGES = 5;
        internal const byte NUMBER_DESSERTS = 5;

        /// <summary> This string stores the custumer's name for the current order. Defaults to Custumer. </summary>
        internal static string custumerName = "Custumer";
        /// <summary> Bool that determines if an order has been made. </summary>
        internal static bool orderSubmitted = false;
        /// <summary> ListBox object used to keep track of the user's current Order. </summary>
        internal static ListBox currentOrder = new ListBox();

        // These arrays represent the number of each item that have already been ordered.
        // When an user submits an order, they may add more of any item, but not remove items already ordered.
        internal static int[] mainDishOrders = new int[NUMBER_MAIN_DISHES];
        internal static int[] saladOrders = new int[NUMBER_SALADS];
        internal static int[] beverageOrders = new int[NUMBER_BEVERAGES];
        internal static int[] dessertOrders = new int[NUMBER_DESSERTS];

        // These arrays represent the user's current order.
        // When an order is submitted they are compared to the above arrays to determine if the order has changed.
        private int[] mainDishCurrent = (int[])mainDishOrders.Clone();
        private int[] saladCurrent = (int[])saladOrders.Clone();
        private int[] beverageCurrent = (int[])beverageOrders.Clone();
        private int[] dessertCurrent = (int[])dessertOrders.Clone();
        
        public frmOrder()
        {
            InitializeComponent();
        }

        /// <summary> This code runs when the form first loads and is used for initial setup. </summary>
        private void frmOrder_Load(object sender, EventArgs e)
        {
            txtCustumersName.Text = custumerName; // Set the text in the CustumersName textbox.
            lstOrder.Items.AddRange(currentOrder.Items); // Display the current order in the list box.
            refreshComboBoxes(); // Refresh the combo boxes to reflect the current order.
        }

        /// <summary> This method is reponsible for updating the combo boxes to show the user's current order. </summary>
        private void refreshComboBoxes()
        {
            // For each combo box, set its selected index to that of the int found in the appropiate element in the Orders array.
            // A manual cast from enum to int is performed each time.
            cmbxArugulaSalad.SelectedIndex = saladOrders[(int)frmMenu.salad.arugula];
            cmbxBocconciniSalad.SelectedIndex = saladOrders[(int)frmMenu.salad.bocconcini];
            cmbxCannoli.SelectedIndex = dessertOrders[(int)frmMenu.dessert.cannoli];
            cmbxCapreseSalad.SelectedIndex = saladOrders[(int)frmMenu.salad.caprese];
            cmbxChickenAlfredo.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.chickenAlfreado];
            cmbxChickenPrunesOlives.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.chicken];
            cmbxChocolateGelato.SelectedIndex = dessertOrders[(int)frmMenu.dessert.gelato];
            cmbxEggplantParmigiana.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.eggplantParmigiana];
            cmbxHoneySemifreddo.SelectedIndex = dessertOrders[(int)frmMenu.dessert.semifreddo];
            cmbxItalianSoda.SelectedIndex = beverageOrders[(int)frmMenu.beverage.soda];
            cmbxMacchiatoCoffee.SelectedIndex = beverageOrders[(int)frmMenu.beverage.macciato];
            cmbxMeatballSandwich.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.meatballSandwich];
            cmbxNegrini.SelectedIndex = beverageOrders[(int)frmMenu.beverage.negrini];
            cmbxPeachBellini.SelectedIndex = beverageOrders[(int)frmMenu.beverage.bellini];
            cmbxPorkChopsItaliano.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.porkChopsItaliano];
            cmbxPrimoAmoreMoscato.SelectedIndex = beverageOrders[(int)frmMenu.beverage.moscato];
            cmbxRoastedTomatoSalad.SelectedIndex = saladOrders[(int)frmMenu.salad.roastedTomato];
            cmbxShrimpScampi.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.shrimpScampi];
            cmbxStrawberryMascarpone.SelectedIndex = dessertOrders[(int)frmMenu.dessert.mascarpone];
            cmbxTagliatelle.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.tagliatelle];
            cmbxTilapiaScaloppine.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.tilapiaScaloppine];
            cmbxTiramisu.SelectedIndex = dessertOrders[(int)frmMenu.dessert.tiramisu];
            cmbxTortelliniSalad.SelectedIndex = saladOrders[(int)frmMenu.salad.tortellini];
            cmbxVeganSpaghetti.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.spaghetti];
            cmbxZitiAlForno.SelectedIndex = mainDishOrders[(int)frmMenu.mainDish.zitiAlForno];
        }

        /// <summary> This is the code that runs when the user presses the Submit Order button. </summary>
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (!orderChanged()) // Determine if nothing in the order has changed.
            {
                // If so display a message to the user.
                if (orderSubmitted)
                    MessageBox.Show("Please edit your order before updating it.");
                else
                    MessageBox.Show("Please edit your order before submitting it.");
            }
            else if (goodOrder()) // Determine if a valid order change has been made.
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo; // Buttons for a MessageBox
                DialogResult result; // The result of said MessageBox

                // Below we display a MessageBox to the user prompting them to confirm that they want to submit/update their order.
                // The first string argument is the message, the second is the caption, and the third argument
                // determines which type of buttons to display to the user, in this case: Yes/No.

                if (orderSubmitted) // If an ordered has previously been submitted, use this MessageBox
                    result = MessageBox.Show("Are you sure you want to update your order?", "Order Comfirmation", buttons);
                else // Else use this one.
                    result = MessageBox.Show("Are you sure you want to submit your order?", "Order Comfirmation", buttons);

                if (result == DialogResult.Yes) // We evaluate the result of the MessageBox dialogue.
                {
                    // For each menu category, we check their corresponding Current array to check if the user has ordered anything.
                    for (frmMenu.mainDish i = 0; i <= frmMenu.mainDish.zitiAlForno; i++)
                    {
                        if (mainDishCurrent[(int)i] > 0) // If so, we add that item to the Order list in a formatted string.
                            lstOrder.Items.Add(String.Format("{0}{1}",
                                frmMenu.mainDishTitles[(int)i].PadRight(40, '.'), "x" + mainDishCurrent[(int)i]));
                    }

                    for (frmMenu.salad i = 0; i <= frmMenu.salad.bocconcini; i++)
                    {
                        if (saladCurrent[(int)i] > 0)
                            lstOrder.Items.Add(String.Format("{0}{1}",
                                frmMenu.saladsTitles[(int)i].PadRight(40, '.'), "x" + saladCurrent[(int)i]));
                    }

                    for (frmMenu.beverage i = 0; i <= frmMenu.beverage.bellini; i++)
                    {
                        if (beverageCurrent[(int)i] > 0)
                            lstOrder.Items.Add(String.Format("{0}{1}",
                                frmMenu.beveragesTitles[(int)i].PadRight(40, '.'), "x" + beverageCurrent[(int)i]));
                    }

                    for (frmMenu.dessert i = 0; i <= frmMenu.dessert.semifreddo; i++)
                    {
                        if (dessertCurrent[(int)i] > 0)
                            lstOrder.Items.Add(String.Format("{0}{1}",
                                frmMenu.dessertsTitles[(int)i].PadRight(40, '.'), "x" + dessertCurrent[(int)i]));
                    }

                    // Update the Orders arrays to reflect the new order. The Clone method returns an Object.
                    // So an int[] cast is needed to assign the Objects to the Orders arrays.
                    mainDishOrders = (int[])mainDishCurrent.Clone();
                    saladOrders = (int[])saladCurrent.Clone();
                    beverageOrders = (int[])beverageCurrent.Clone();
                    dessertOrders = (int[])dessertCurrent.Clone();

                    currentOrder.Items.Clear(); // Clear the currentOrder list to avoid duplicates.
                    currentOrder.Items.AddRange(lstOrder.Items); // Update the currentOrder.
                    orderSubmitted = true; // Set the orderSubmitted flag to true.
                }
            }
            else // If a valid order was not made, inform the user and refresh the combo boxes.
            {
                MessageBox.Show("Cannot remove items that have already been ordered.\nPlease refer to your Current Order.");
                refreshComboBoxes();
            }

        }

        /// <summary> This method determines if the user has made a valid order change. </summary>
        private bool goodOrder()
        {
            bool goodOrder = true; // Assume the order change is good.

            // Compare each element from each Current array to the corresponding element of the corresponding Orders array.
            // If the element in the Currents array is less than that of the Orders array, the user is attempting to remove
            // an item that they've already ordered, and is therefore an invalid order change.

            for (frmMenu.mainDish i = 0; i <= frmMenu.mainDish.zitiAlForno; i++)
            {
                if (mainDishCurrent[(int)i] < mainDishOrders[(int)i])
                {
                    goodOrder = false; // If the above condition is true, set goodOrder to false.
                }
            }

            // Do the same for the other menu categories.

            for (frmMenu.salad i = 0; i <= frmMenu.salad.bocconcini; i++)
            {
                if (saladCurrent[(int)i] < saladOrders[(int)i])
                {
                    goodOrder = false;
                }
            }

            for (frmMenu.beverage i = 0; i <= frmMenu.beverage.bellini; i++)
            {
                if (beverageCurrent[(int)i] < beverageOrders[(int)i])
                {
                    goodOrder = false;
                }
            }

            for (frmMenu.dessert i = 0; i <= frmMenu.dessert.semifreddo; i++)
            {
                if (dessertCurrent[(int)i] < dessertOrders[(int)i])
                {
                    goodOrder = false;
                }
            }

            return goodOrder;
        }

        /// <summary> This method determines if the user has made a change to their order. </summary>
        private bool orderChanged()
        {
            // Compare all index to their corresponding Orders array element. If any of them has changed, returns true.

            return
            cmbxArugulaSalad.SelectedIndex != saladOrders[(int)frmMenu.salad.arugula] ||
            cmbxBocconciniSalad.SelectedIndex != saladOrders[(int)frmMenu.salad.bocconcini] ||
            cmbxCannoli.SelectedIndex != dessertOrders[(int)frmMenu.dessert.cannoli] ||
            cmbxCapreseSalad.SelectedIndex != saladOrders[(int)frmMenu.salad.caprese] ||
            cmbxChickenAlfredo.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.chickenAlfreado] ||
            cmbxChickenPrunesOlives.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.chicken] ||
            cmbxChocolateGelato.SelectedIndex != dessertOrders[(int)frmMenu.dessert.gelato] ||
            cmbxEggplantParmigiana.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.eggplantParmigiana] ||
            cmbxHoneySemifreddo.SelectedIndex != dessertOrders[(int)frmMenu.dessert.semifreddo] ||
            cmbxItalianSoda.SelectedIndex != beverageOrders[(int)frmMenu.beverage.soda] ||
            cmbxMacchiatoCoffee.SelectedIndex != beverageOrders[(int)frmMenu.beverage.macciato] ||
            cmbxMeatballSandwich.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.meatballSandwich] ||
            cmbxNegrini.SelectedIndex != beverageOrders[(int)frmMenu.beverage.negrini] ||
            cmbxPeachBellini.SelectedIndex != beverageOrders[(int)frmMenu.beverage.bellini] ||
            cmbxPorkChopsItaliano.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.porkChopsItaliano] ||
            cmbxPrimoAmoreMoscato.SelectedIndex != beverageOrders[(int)frmMenu.beverage.moscato] ||
            cmbxRoastedTomatoSalad.SelectedIndex != saladOrders[(int)frmMenu.salad.roastedTomato] ||
            cmbxShrimpScampi.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.shrimpScampi] ||
            cmbxStrawberryMascarpone.SelectedIndex != dessertOrders[(int)frmMenu.dessert.mascarpone] ||
            cmbxTagliatelle.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.tagliatelle] ||
            cmbxTilapiaScaloppine.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.tilapiaScaloppine] ||
            cmbxTiramisu.SelectedIndex != dessertOrders[(int)frmMenu.dessert.tiramisu] ||
            cmbxTortelliniSalad.SelectedIndex != saladOrders[(int)frmMenu.salad.tortellini] ||
            cmbxVeganSpaghetti.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.spaghetti] ||
            cmbxZitiAlForno.SelectedIndex != mainDishOrders[(int)frmMenu.mainDish.zitiAlForno];
        }

        /// <summary> This is the code that runs when the user presses the Reset Order button. </summary>
        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            // This button simply calls the refreshComboBoxes method to reset them to the current order.
            refreshComboBoxes();
        }

        /// <summary> This code runs when the text of the CustumerName textbox changes. It updates the custumerName string. </summary>
        private void txtCustumersName_TextChanged(object sender, EventArgs e)
        {
            custumerName = txtCustumersName.Text;
        }

        // Below are the event handlers for all the combo boxes in the Order form.
        // They simply update the Current arrays to reflect the user's changes.
        // Because all combo boxes have only integers has elements, the parses are guaranteed to succeed.

        private void cmbxVeganSpaghetti_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.spaghetti] = int.Parse(cmbxVeganSpaghetti.SelectedItem.ToString());
        }

        private void cmbxChickenAlfredo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.chickenAlfreado] = int.Parse(cmbxChickenAlfredo.SelectedItem.ToString());
        }

        private void cmbxTilapiaScaloppine_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.tilapiaScaloppine] = int.Parse(cmbxTilapiaScaloppine.SelectedItem.ToString());
        }

        private void cmbxPorkChopsItaliano_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.porkChopsItaliano] = int.Parse(cmbxPorkChopsItaliano.SelectedIndex.ToString());
        }

        private void cmbxMeatballSandwich_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.meatballSandwich] = int.Parse(cmbxMeatballSandwich.SelectedIndex.ToString());
        }

        private void cmbxShrimpScampi_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.shrimpScampi] = int.Parse(cmbxShrimpScampi.SelectedIndex.ToString());
        }

        private void cmbxChickenPrunesOlives_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.chicken] = int.Parse(cmbxChickenPrunesOlives.SelectedIndex.ToString());
        }

        private void cmbxTagliatelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.tagliatelle] = int.Parse(cmbxTagliatelle.SelectedIndex.ToString());
        }

        private void cmbxEggplantParmigiana_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.eggplantParmigiana] = int.Parse(cmbxEggplantParmigiana.SelectedIndex.ToString());
        }

        private void cmbxZitiAlForno_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDishCurrent[(int)frmMenu.mainDish.zitiAlForno] = int.Parse(cmbxZitiAlForno.SelectedIndex.ToString());
        }

        private void cmbxTortelliniSalad_SelectedIndexChanged(object sender, EventArgs e)
        {
            saladCurrent[(int)frmMenu.salad.tortellini] = int.Parse(cmbxTortelliniSalad.SelectedIndex.ToString());
        }

        private void cmbxRoastedTomatoSalad_SelectedIndexChanged(object sender, EventArgs e)
        {
            saladCurrent[(int)frmMenu.salad.roastedTomato] = int.Parse(cmbxRoastedTomatoSalad.SelectedIndex.ToString());
        }

        private void cmbxCapreseSalad_SelectedIndexChanged(object sender, EventArgs e)
        {
            saladCurrent[(int)frmMenu.salad.caprese] = int.Parse(cmbxCapreseSalad.SelectedIndex.ToString());
        }

        private void cmbxArugulaSalad_SelectedIndexChanged(object sender, EventArgs e)
        {
            saladCurrent[(int)frmMenu.salad.arugula] = int.Parse(cmbxArugulaSalad.SelectedIndex.ToString());
        }

        private void cmbxBocconciniSalad_SelectedIndexChanged(object sender, EventArgs e)
        {
            saladCurrent[(int)frmMenu.salad.bocconcini] = int.Parse(cmbxBocconciniSalad.SelectedIndex.ToString());
        }

        private void cmbxPrimoAmoreMoscato_SelectedIndexChanged(object sender, EventArgs e)
        {
            beverageCurrent[(int)frmMenu.beverage.moscato] = int.Parse(cmbxPrimoAmoreMoscato.SelectedIndex.ToString());
        }

        private void cmbxMacchiatoCoffee_SelectedIndexChanged(object sender, EventArgs e)
        {
            beverageCurrent[(int)frmMenu.beverage.macciato] = int.Parse(cmbxMacchiatoCoffee.SelectedIndex.ToString());
        }

        private void cmbxNegrini_SelectedIndexChanged(object sender, EventArgs e)
        {
            beverageCurrent[(int)frmMenu.beverage.negrini] = int.Parse(cmbxNegrini.SelectedIndex.ToString());
        }

        private void cmbxItalianSoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            beverageCurrent[(int)frmMenu.beverage.soda] = int.Parse(cmbxItalianSoda.SelectedIndex.ToString());
        }

        private void cmbxPeachBellini_SelectedIndexChanged(object sender, EventArgs e)
        {
            beverageCurrent[(int)frmMenu.beverage.bellini] = int.Parse(cmbxPeachBellini.SelectedIndex.ToString());
        }

        private void cmbxChocolateGelato_SelectedIndexChanged(object sender, EventArgs e)
        {
            dessertCurrent[(int)frmMenu.dessert.gelato] = int.Parse(cmbxChocolateGelato.SelectedIndex.ToString());
        }

        private void cmbxStrawberryMascarpone_SelectedIndexChanged(object sender, EventArgs e)
        {
            dessertCurrent[(int)frmMenu.dessert.mascarpone] = int.Parse(cmbxStrawberryMascarpone.SelectedIndex.ToString());
        }

        private void cmbxCannoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            dessertCurrent[(int)frmMenu.dessert.cannoli] = int.Parse(cmbxCannoli.SelectedIndex.ToString());
        }

        private void cmbxTiramisu_SelectedIndexChanged(object sender, EventArgs e)
        {
            dessertCurrent[(int)frmMenu.dessert.tiramisu] = int.Parse(cmbxTiramisu.SelectedIndex.ToString());
        }

        private void cmbxHoneySemifreddo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dessertCurrent[(int)frmMenu.dessert.semifreddo] = int.Parse(cmbxHoneySemifreddo.SelectedIndex.ToString());
        }
    }
}

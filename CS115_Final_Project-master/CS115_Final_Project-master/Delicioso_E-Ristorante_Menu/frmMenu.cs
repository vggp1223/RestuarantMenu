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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        #region Main Dishes
        /// <summary> This array contains the main dishes' titles. </summary>
        internal static readonly string[] mainDishTitles =
        {
            "Vegan Spaghetti Bolognese", "Chicken Alfreado", "Tilapia Scaloppine", "Pork Chops Italiano", "Meatball Sandwich",
            "Shrimp Scampi", "Chicken With Prunes And Olives", "Tagliatelle With Coriander Pesto", "Eggplant Parmigiana",
            "Five Cheese Ziti al Forno"
        };

        /// <summary> This array contains the main dishes' descriptions. </summary>
        private static readonly string[] mainDishDescriptions =
        {
            // Vegan Spaghetti.
            "This spaghetti is made of thin wheat noodles and topped with Roma sauce." +
                " It is suitable for vegan and vegetarian people as it does not contain meat." +
                " Enjoy a roasted taste in the marinara sauce that is topped off with garnish.",
            // Chicken Alfreado
            "Exquisite dish made with fettuccine pasta, prime quality chicken breast, and creamy Alfreado sauce." +
                " Garnished with grated parmesan cheese to taste.",
            // Tilapia Scaloppine
            "A chicken-inspired dish with tilapia fish and Italian dressings." +
                "  Comes with olive oil, mushrooms, lemon juice, and butter.  Topped with white wine and capers. ",
            // Pork Chops.
            "Tender pork chops with olive oil and flavoring.  Well-suited with other Italian dishes." +
                "\nMushrooms decorate the pork chops along with tomatoes and herbs. ",
            // Meatball Sandwich
            "Artisan bread with tomato paste and herb-flavored meatballs." +
                "  Contains oregano and parsley with melted Parmesan cheese.  Great for a quick bite. ",
            // Shrimp Scampi
            "A simple yet elegant shrimp dish.  Angel-haired pasta and white wine are mixed to create this tasty shrimp sauce." +
                "  Combined with (not pictured) garlic bread and pairs well with salad. ",
            // Chicken with Prunes and Olives
            "This main dish is centered around herb-flavored chicken, as well as prunes and olives." +
                "  It is dipped in vinegars and sauces and will satisfy a hungry customer looking for flavorful food to eat. ",
            // Tagliatelle with Coriander Pesto
            "This tagliatelle pasta is mixed with pine nuts, olive oils, and lemon juice." +
                "  It packs a powerful punch with its different flavors," +
                " and is an authentic dish for any Italian lunch and dinner aficionado. ",
            // Eggplant Parmigiana
            "This eggplant dish with provolone and parmesan comes with herbs, breadcrumbs, and Mozzarella cheese." +
                "  It contains virgin olive oil, and plum tomatoes.  A wonderful dish for eggplant enthusiasts. ",
            // Five Cheese Ziti al Forno
            "This five cheese pasta is appealing to those with a taste for cheese." +
                "  It contains five cheeses: mozzarella, ricotta, provolone, Romano, and parmesan cheese." +
                "  It is topped with marinara and Alfredo sauce. "
        };

        /// <summary> This enum is the order that the main dishes appear, left to right. Enumerated starting from 0. </summary>
        internal enum mainDish
        {
            spaghetti, chickenAlfreado, tilapiaScaloppine, porkChopsItaliano, meatballSandwich,
            shrimpScampi, chicken, tagliatelle, eggplantParmigiana, zitiAlForno
        }

        /// <summary> This array contains the main dishes' prices. </summary> // Test prices, change later.
        internal static readonly double[] mainDishesPrices = { 11.99, 14.99, 19.99, 14.99, 7.50, 19.99, 9.99, 12.99, 12.99, 14.99 };

        /// <summary> This mainDish variable is used to keep track of which item of this category is displayed to the user. </summary>
        private mainDish mainDishIndex = 0; //  Set to the first item.
        #endregion

        #region Salads
        /// <summary> This array contains the salads' titles. </summary>
        internal static readonly string[] saladsTitles =
        {
            "Tortellini Salad", "Roasted Tomato Salad", "Caprese Salad", "Arugula Salad", "Bocconcini Salad"
        };

        /// <summary> This array contains the salads' descriptions. </summary>
        private static readonly string[] saladsDescriptions =
        {
            // Tortellini
            "This salad is full of Mediterranean flavors and tossed with Italian dressing." +
                "  It is made with tortellini, vegetables, salami, and artichokes to enhance the flavor." +
                "  It can be eaten with any main course.",
            // Roasted Tomato
            "This salad contains roasted plum tomatoes, a savory flavored tomato famous in Italy." +
                "  It is mixed with garlic and olive oil to increase its flavors.",
            // Caprese
            "This light salad is made with fresh vegetables and mozzarella cheese.  It contains cherry tomatoes and fresh basil." +
                "  It can serve as an accompaniment to any meal.  ",
            // Arugula
            "A great seasonal salad that comes with lemon dressing.  It has arugula, fennel bulbs, pine nuts, and grape tomatoes.",
            // Bocconcini
            "This salad is full of bocconcinis, which are bite-sized white balls of Mozzarella cheese." +
                "  This cheese is made from buffalo milk, which makes it creamier than cheese made from cow’s milk." +
                "  It has an assortment of vegetables: tomatoes, bell peppers, endive leaves, and arugula."
        };

        /// <summary> This enum is the order that the salads appear, left to right. Enumerated starting from 0. </summary>
        internal enum salad { tortellini, roastedTomato, caprese, arugula, bocconcini }

        /// <summary> This array contains the salads' prices. </summary>
        internal static readonly double[] saladsPrices = { 5.99, 6.99, 5.99, 7.99, 7.99 }; // Test prices, change later.

        /// <summary> This salad variable is used to keep track of which item of this category is displayed to the user. </summary>
        salad saladIndex = 0; // Set to the first item.
        #endregion

        #region Beverages
        /// <summary> This array contains the beverages' titles. </summary>
        internal static readonly string[] beveragesTitles =
            { "Primo Amore Moscato", "Macchiato Coffee", "Negrini", "Italian Soda", "Peach Bellini" };

        /// <summary> This array contains the beverages' descriptions. </summary>
        private static readonly string[] beveragesDescriptions =
        {
            // Moscato
            "This wine comes from the grapes of the vineyards in Puglia in Southern Italy." +
                "  It is a sparkling sweet Moscato wine that pairs well with desserts or may be consumed alone." +
                "  It is crisp and refreshing, and sold at a low price.  *Must be 21 or above to order.   ",
            // Macchiato
            "This macchiato drink will satisfy any coffee drinkers.  It is an espresso with a dash of decorative milk." +
                "  It has a powerful taste, with a touch of creaminess from the milk that is contained in the drink. ",
            // Negrini
            "This alcoholic mixed drink is a classic cocktail.  It contains gin, Campari, and sweet vermouth." +
                "  It is known as a bitter apertitif.  It is often paired with lemon, and can be shaken or stirred." +
                " *Must be 21 or above to order. ",
            // Soda
            "This fun and fruity drink contains torani syrup and sparkling water.  This gives it a fizzy feel when it is consumed." +
                "  Perfect for kids or teenagers who would like a sweet beverage to enjoy. ",
            // Bellini
            "This is made of Italian Prosecco wine and peach puree and nectar.  It is a fruity cocktail that can be enjoyed in" +
                " seasonal weather.  *Must be 21 or above to order. "
        };

        /// <summary> This enum is the order that the beverages appear, left to right. Enumerated starting from 0. </summary>
        internal enum beverage { moscato, macciato, negrini, soda, bellini }

        /// <summary> This array contains the beverages' prices. </summary>
        internal static readonly double[] beveragesPrices = { 15.99, 5.99, 9.99, 2.99, 9.99 };

        /// <summary> This beverage variable is used to keep track of which item of this category is displayed to the user. </summary>
        beverage beverageIndex = 0; // Set to the first item.
        #endregion

        #region Desserts
        /// <summary> This array contains the desserts' titles. </summary>
        internal static readonly string[] dessertsTitles =
            { "Chocolate Gelato", "Strawberry Mascarpone", "Cannoli", "Tiramisu", "Honey Semifreddo" };

        /// <summary> This array contains the desserts' descriptions. </summary>
        private static readonly string[] dessertsDescriptions =
        {
            // Gelato
            "This famous Italian ice cream is chocolate flavored and comes with cream and a brownie cake." +
                "  It is perfect for those who are younger and have a sweet tooth.  It also pairs well for adults who have eaten dinner" +
                " or have ordered a cocktail.",
            // Mascarpone
            "A creamy cheesecake topped with strawberries.  It is mixed with light acids such as a sprinkle of lemon and some vinegars." +
                "  It is soft and flavorful and pairs well with any main Italian course. ",
            // Cannoli
            "Italian pastries that are made of tube-shaped shells from fried pastry dough with a sweet, creamy filling containing ricotta." +
                "  This is a famous dish in Sicily.",
            // Tiramisu
            "This is coffee-flavored dessert sprinkled with cocoa.  It is made of eggs, sugar, and mascarpone cheese, topped with rum." +
                "  It is a classic dessert enjoyed throughout the world. ",
            // Semifreddo
            "This is smooth, soft, almost chilled cream that is similar to ice cream but is not.  It has a sweet taste and honey covering." +
                "  Comes with toasty pine nuts and pudding. "
        };

        /// <summary> This enum is the order that the desserts appear, left to right. Enumerated starting from 0. </summary>
        internal enum dessert { gelato, mascarpone, cannoli, tiramisu, semifreddo }

        /// <summary> This array contains the desserts' prices. </summary>
        internal static readonly double[] dessertsPrices = { 7.99, 6.99, 5.99, 4.99, 4.99 }; // Test prices, change later

        /// <summary> This dessert variable is used to keep track of which item of this category is displayed to the user. </summary>
        dessert dessertIndex = 0; // Set to the first item.
        #endregion

        /// <summary> This function runs when the form first loads. Used for initial setups. </summary>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            // Bring the first item of each category to the front and display the appropiate title, desc., and price.

            picVeganSpaghettiBolognese.BringToFront();
            lblMainDishTitle.Text = mainDishTitles[0];
            lblMainDishDescription.Text = mainDishDescriptions[0];
            txtMainDishPrice.Text = mainDishesPrices[0].ToString("C2");


            picTortellini.BringToFront();
            lblSaladTitle.Text = saladsTitles[0];
            lblSaladDescription.Text = saladsDescriptions[0];
            txtSaladPrice.Text = saladsPrices[0].ToString("C2");

            picMoscato.BringToFront();
            lblBeverageTitle.Text = beveragesTitles[0];
            lblBeverageDescription.Text = beveragesDescriptions[0];
            txtBeveragePrice.Text = beveragesPrices[0].ToString("C2");

            picChocolateGelato.BringToFront();
            lblDessertTitle.Text = dessertsTitles[0];
            lblDessertDescription.Text = dessertsDescriptions[0];
            txtDessertPrice.Text = dessertsPrices[0].ToString("C2");
        }

        /// <summary> This is code that run when the user presses the left button under the Main Dishes tab. </summary>
        private void btnMainDishesLeft_Click(object sender, EventArgs e)
        {
            if (mainDishIndex > mainDish.spaghetti) // Check that the user is not at the left-most item
            {
                mainDishIndex--; // If not, then decrement the main dish index
                refreshMainDishes(); // Refresh the menu to reflect the new index
                lblMainDishTitle.Text = mainDishTitles[(int)mainDishIndex]; // C# does not implicitly convert enums to ints...
                txtMainDishPrice.Text = mainDishesPrices[(int)mainDishIndex].ToString("C2"); // so an explicit cast is needed.
                lblMainDishDescription.Text = mainDishDescriptions[(int)mainDishIndex];
            }
        }

        /// <summary> This is code that run when the user presses the right button under the Main Dishes tab. </summary>
        private void btnMainDishesRight_Click(object sender, EventArgs e)
        {
            if (mainDishIndex < mainDish.zitiAlForno) // Check that the user is not at the right-most item.
            {
                mainDishIndex++; // If not, then increment the main dish index
                refreshMainDishes(); // Perform the same operations as above.
                lblMainDishTitle.Text = mainDishTitles[(int)mainDishIndex];
                lblMainDishDescription.Text = mainDishDescriptions[(int)mainDishIndex];
                txtMainDishPrice.Text = mainDishesPrices[(int)mainDishIndex].ToString("C2");
            }
        }

        /// <summary> This method is responsible for refreshing the Main Dish tab when either of the above buttons are pressed. </summary>
        private void refreshMainDishes()
        {
            // To refresh the menu we evaluate the mainDishIndex (declared at the class scope) on a switch statement.
            switch (mainDishIndex)
            {
                case mainDish.spaghetti: // Once we determine which item index we are at...
                    picVeganSpaghettiBolognese.BringToFront(); // we bring that item's picture to the front.
                    break; // This hides the ones behind it, giving the illusion that the pictures are flipping.
                case mainDish.chickenAlfreado:
                    picChickenAlfredo.BringToFront();
                    break;
                case mainDish.tilapiaScaloppine:
                    picTilapiaScaloppine.BringToFront();
                    break;
                case mainDish.porkChopsItaliano:
                    picPorkChopsItaliano.BringToFront();
                    break;
                case mainDish.meatballSandwich:
                    picMeatballSandwich.BringToFront();
                    break;
                case mainDish.shrimpScampi:
                    picShrimpScampi.BringToFront();
                    break;
                case mainDish.chicken:
                    picChicken.BringToFront();
                    break;
                case mainDish.tagliatelle:
                    picTagliatelleWithCorianderPesto.BringToFront();
                    break;
                case mainDish.eggplantParmigiana:
                    picEggplantParmigiana.BringToFront();
                    break;
                case mainDish.zitiAlForno:
                    picFiveCheeseZitialForno.BringToFront();
                    break; // No default case provided given that the above checks prevent the user from going out of bounds.
            }
        }

        // Below is the code for the other menu categories: salads, beverages, and desserts.
        // They are identical to that of the main dishes, only using the appropiate variables and pictures.

        private void btnSaladsLeft_Click(object sender, EventArgs e)
        {
            if (saladIndex > salad.tortellini)
            {
                saladIndex--;
                refreshSalads();
                lblSaladTitle.Text = saladsTitles[(int)saladIndex];
                lblSaladDescription.Text = saladsDescriptions[(int)saladIndex];
                txtSaladPrice.Text = saladsPrices[(int)saladIndex].ToString("C2");
            }
        }

        private void btnSaladsRight_Click(object sender, EventArgs e)
        {
            if (saladIndex < salad.bocconcini)
            {
                saladIndex++;
                refreshSalads();
                lblSaladTitle.Text = saladsTitles[(int)saladIndex];
                lblSaladDescription.Text = saladsDescriptions[(int)saladIndex];
                txtSaladPrice.Text = saladsPrices[(int)saladIndex].ToString("C2");
            }
        }

        private void refreshSalads()
        {
            switch (saladIndex)
            {
                case salad.tortellini:
                    picTortellini.BringToFront();
                    break;
                case salad.roastedTomato:
                    picRoastedTomato.BringToFront();
                    break;
                case salad.caprese:
                    picCaprese.BringToFront();
                    break;
                case salad.arugula:
                    picArugula.BringToFront();
                    break;
                case salad.bocconcini:
                    picBocconcini.BringToFront();
                    break;
            }
        }

        private void btnBeveragesLeft_Click(object sender, EventArgs e)
        {
            if (beverageIndex > beverage.moscato)
            {
                beverageIndex--;
                refreshBeverages();
                lblBeverageTitle.Text = beveragesTitles[(int)beverageIndex];
                lblBeverageDescription.Text = beveragesDescriptions[(int)beverageIndex];
                txtBeveragePrice.Text = beveragesPrices[(int)beverageIndex].ToString("C2");
            }
        }

        private void btnBeveragesRight_Click(object sender, EventArgs e)
        {
            if (beverageIndex < beverage.bellini)
            {
                beverageIndex++;
                refreshBeverages();
                lblBeverageTitle.Text = beveragesTitles[(int)beverageIndex];
                lblBeverageDescription.Text = beveragesDescriptions[(int)beverageIndex];
                txtBeveragePrice.Text = beveragesPrices[(int)beverageIndex].ToString("C2");
            }
        }

        private void refreshBeverages()
        {
            switch (beverageIndex)
            {
                case beverage.moscato:
                    picMoscato.BringToFront();
                    break;
                case beverage.macciato:
                    picMacchiato.BringToFront();
                    break;
                case beverage.negrini:
                    picNegroni.BringToFront();
                    break;
                case beverage.soda:
                    picItalianSoda.BringToFront();
                    break;
                case beverage.bellini:
                    picPeachBellini.BringToFront();
                    break;
            }
        }

        private void btnDessertsLeft_Click(object sender, EventArgs e)
        {
            if (dessertIndex > dessert.gelato)
            {
                dessertIndex--;
                refreshDesserts();
                lblDessertTitle.Text = dessertsTitles[(int)dessertIndex];
                lblDessertDescription.Text = dessertsDescriptions[(int)dessertIndex];
                txtDessertPrice.Text = dessertsPrices[(int)dessertIndex].ToString("C2");
            }
        }

        private void btnDessertsRight_Click(object sender, EventArgs e)
        {
            if (dessertIndex < dessert.semifreddo)
            {
                dessertIndex++;
                refreshDesserts();
                lblDessertTitle.Text = dessertsTitles[(int)dessertIndex];
                lblDessertDescription.Text = dessertsDescriptions[(int)dessertIndex];
                txtDessertPrice.Text = dessertsPrices[(int)dessertIndex].ToString("C2");
            }
        }

        private void refreshDesserts()
        {
            switch (dessertIndex)
            {
                case dessert.gelato:
                    picChocolateGelato.BringToFront();
                    break;
                case dessert.mascarpone:
                    picStrawberryMascarpone.BringToFront();
                    break;
                case dessert.cannoli:
                    picCannoli.BringToFront();
                    break;
                case dessert.tiramisu:
                    picTiramisu.BringToFront();
                    break;
                case dessert.semifreddo:
                    picHoneySemifreddo.BringToFront();
                    break;
            }
        }
    }
}

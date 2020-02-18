using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1JeremiahMacDougall
{
    /* [Windows Icon]. Retrieved from http://www.iconarchive.com/search?q=food 
     
        Minor revisions v2020.01.15 - ensured student info was locked, updated the name field on the final total, added a version tracker to main form.

         */

    public partial class BillCalculator : Form
    {
        public BillCalculator()
        {
            InitializeComponent();
        }
        double subTotal = 0.00;
        double taxes = 0.00;
        double total = 0.00;
        double taxRate = 0.13;
        // create the lists
        string[] menuBeveragesDescriptions = { "Soda", "Tea", "Coffee", "Mineral Water", "Juice" };
        double[] menuBeveragesPrices = { 1.95, 1.50, 1.25, 2.95, 2.50 };

        string[] menuAppetizerDescriptions = { "Buffalo Wings", "Buffalo Fingers", "Nachos", "Mushroom Caps", "Chips and Salsa" };
        double[] menuAppetizerPrices = { 5.95, 6.95, 8.95, 10.95, 6.95 };

        string[] menuMainCourseDescriptions = { "Chicken Alfredo", "Turkey Club", "Prime Rib", "Turkey Dinner", "Stuffed Chicken" };
        double[] menuMainCoursePrices = { 13.95, 11.95, 20.95, 13.95, 14.95 };

        string[] menuDessertDescriptions = { "Apple Pie", "Sundae", "Carrot Cake", "Apple Crisp" };
         double[] menuDessertPrices = { 5.95, 3.95, 5.95, 5.95 };


        private void frmTableBill_Load(object sender, EventArgs e)
        {
            // setup the starting totals
            txtStudentInfo.Text = "Name: Jeremiah MacDougall\nStudent ID: 991-531-555";
            
            txtSubtotal.Text = subTotal.ToString("C2");
            txtTax.Text = taxes.ToString("C2");
            txtTotal.Text = total.ToString("C2");
            
            lblTax.Text += " @ "+taxRate.ToString("P0")+":";

            /* create the drop down menus.   

               The idea will be to concatenate the description - price in the menus.
               This can probably be achieved using a foreach loop and using the values 
               from each set of lists.

                */

            // create beverage list

            cmbBeverages.Items.Insert(0, "Select Beverages");
            cmbBeverages.SelectedIndex = 0;
            for (int x = 0; x < menuBeveragesDescriptions.Length; x++)
            {
                string temp = menuBeveragesDescriptions[x] + " - " + menuBeveragesPrices[x].ToString("C2");
                
                Console.WriteLine(menuBeveragesDescriptions[x] + " - " + menuBeveragesPrices[x].ToString("C2")); // the output looks ok
                
                cmbBeverages.Items.Add(temp);
            }

            // create appetizer list
            cmbAppetizers.Items.Insert(0, "Select Appetizers");
            cmbAppetizers.SelectedIndex = 0;

            for (int x = 0; x < menuAppetizerDescriptions.Length; x++)
            {
                string temp = menuAppetizerDescriptions[x] + " - " + menuAppetizerPrices[x].ToString("C2");
                
                Console.WriteLine(menuAppetizerDescriptions[x] + " - " + menuAppetizerPrices[x].ToString("C2")); // the output looks ok
                
                cmbAppetizers.Items.Add(temp);
            }
            // create main course list
            cmbMainCourse.Items.Insert(0, "Select Main Courses");
            cmbMainCourse.SelectedIndex = 0;

            for (int x = 0; x < menuMainCourseDescriptions.Length; x++)
            {
                string temp = menuMainCourseDescriptions[x] + " - " + menuMainCoursePrices[x].ToString("C2");

                Console.WriteLine(menuMainCourseDescriptions[x] + " - " + menuMainCoursePrices[x].ToString("C2")); // the output looks ok

                cmbMainCourse.Items.Add(temp);
            }
            // create dessert list
            cmbDesserts.Items.Insert(0, "Select Desserts");
            cmbDesserts.SelectedIndex = 0;

            for (int x = 0; x < menuDessertDescriptions.Length; x++)
            {
                string temp = menuDessertDescriptions[x] + " - " + menuDessertPrices[x].ToString("C2");

                Console.WriteLine(menuDessertDescriptions[x] + " - " + menuDessertPrices[x].ToString("C2")); // the output looks ok

                cmbDesserts.Items.Add(temp);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        { // this method will clear the form of all listings and totals
            if (listSelections.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear the bill?", "Clear Bill", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        // insert code here to clear all lists and values
                        subTotal = 0.00;
                        total = 0.00;
                        taxes = 0.00;
                        listSelections.Items.Clear();
                        txtSubtotal.Text = "$0.00";
                        txtTax.Text = "$0.00";
                        txtTotal.Text = "$0.00";
                        cmbMainCourse.SelectedIndex = 0;
                        cmbDesserts.SelectedIndex = 0;
                        cmbAppetizers.SelectedIndex = 0;
                        cmbBeverages.SelectedIndex = 0;
                        break;
                    case DialogResult.No:
                        break;
                   
                }
            }
            else
                MessageBox.Show("There is nothing to clear!","Error",MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        private void cmbBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBeverages.SelectedIndex > 0)
            {
                UpdateMainForm(cmbBeverages.Text, menuBeveragesPrices[cmbBeverages.SelectedIndex - 1]);
                cmbBeverages.SelectedIndex = 0;
            }
        }

        private void cmbAppetizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAppetizers.SelectedIndex > 0)
            {
                UpdateMainForm(cmbAppetizers.Text, menuAppetizerPrices[cmbAppetizers.SelectedIndex - 1]);
                cmbAppetizers.SelectedIndex = 0;
            }
            
        }

        
        private void UpdateMainForm(string desc, double price) {
            // this method will update the form regardless of which dropdown is being used - reduce code duplication

            listSelections.Items.Add(desc);
            
            double itemTax = price * taxRate;

            // update main totals
            subTotal += price;
            taxes += itemTax;
            total += (price + itemTax);
            // update text fields

            txtSubtotal.Text = subTotal.ToString("C2");
            txtTax.Text = taxes.ToString("C2");
            txtTotal.Text = total.ToString("C2");

        }
        
        private void cmbMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainCourse.SelectedIndex > 0)
            {
                UpdateMainForm(cmbMainCourse.Text, menuMainCoursePrices[cmbMainCourse.SelectedIndex - 1]);
                cmbMainCourse.SelectedIndex = 0;
            }
            
        }

        private void cmbDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesserts.SelectedIndex > 0)
            {
                UpdateMainForm(cmbDesserts.Text, menuDessertPrices[cmbDesserts.SelectedIndex - 1]);
                cmbDesserts.SelectedIndex = 0;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (listSelections.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("You have items listed. Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                    Close();
            }
            else
                Close();

        }
    }

}

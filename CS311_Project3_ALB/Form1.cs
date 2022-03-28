using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project3_ALB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double total = 0.0; //keeps track of the total, easier to have access across all methods
        public static String size = ""; //size string
        public static String crustT = ""; //crust string
        public static String toppingsList = ""; //toppings string, appended with list, then subtracted the last line return

        /**
         * Combo box to pick your pizza
        */
        private void cboPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = cboPizzaSize.GetItemText(cboPizzaSize.SelectedItem); 
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {

        }

        /**
         * Button click does the work! Technically he bothers me because you can't add two pizzas, but that's anothe project. 
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {
                crustT = "Thick";
            }

            if (rbRegular.Checked)
            {
                crustT = "Regular";
            }

            if (rbThin.Checked)
            {
                crustT = "Thin";
            }
            toppingsChecker();
            Summarize(total);


        }

        public void Summarize(double tot)
        {
            double tax = tot * .06;
            double finalTotal = tax + tot;

            rtfOutput.SelectionFont = new Font("Times New Roman", 14);
            
            rtfOutput.SelectedText = "You ordered a " + size + " pizza with a " + crustT + " crust and with the following toppings: \n";

            rtfOutput.SelectionBullet = true;
            rtfOutput.SelectedText = toppingsList;

            txtbSubtotal.Text = "$" + tot.ToString() + ".00"; //might be lazy but it works okay fine i know im a senior it's fine it's fine
            txtbTax.Text = "$" + tax.ToString();
            txtbTotal.Text = "$" + finalTotal.ToString();


        }//end summarize

        /**
         * This does a little bit more than build the toppings string. It builds the total as well, figured this was worth a separate method due to 
         * how annoying the if statements look.
        */
        public void toppingsChecker()
        {

            if (size == "Small")
                total += 2.00;
            if (size == "Medium")
                total += 5.00;
            if (size == "Large")
                total += 10.00;
            if (size == "X-Large")
                total += 15.00;
            if (size == "Ginormous")
                total += 20.00;

            if (cbBananaPeppers.Checked)
            {
                toppingsList += "Banana Peppers\n";
                total += 1.00;
            }

            if (cbBlackOlives.Checked)
            {
                toppingsList += "Black Olives\n";
                total += 1.00;
            }

            if (cbCanadianBacon.Checked)
            {
                toppingsList += "Canadian Bacon\n";
                total += 1.00;
            }

            if (cbExtraCheese.Checked)
            {
                toppingsList += "Extra Cheese\n";
                total += 1.00;
            }

            if (cbGreenOlives.Checked)
            {
                toppingsList += "Green Olives\n";
                total += 1.00;
            }

            if (cbGreenPepper.Checked)
            {
                toppingsList += "Green Peppers\n";
                total += 1.00;
            }
            if (cbJalapenos.Checked)
            {
                toppingsList += "Jalapenos\n";
                total += 1.00;
            }

            if (cbMushrooms.Checked)
            {
                toppingsList += "Mushrooms\n";
                total += 1.00;
            }

            if (cbOnion.Checked)
            {
                toppingsList += "Onion\n";
                total += 1.00;
            }

            if (cbPepperoni.Checked)
            {
                toppingsList += "Pepperoni\n";
                total += 2.00;
            }

            if (cbSausage.Checked)
            {
                toppingsList += "Sausage\n";
                total += 2.00;
            }
            if (cbSpicyItalian.Checked)
            {
                toppingsList += "Spicy Italian\n";
                total += 2.00;
            }
            toppingsList = toppingsList.Substring(0, toppingsList.Length - 1);
        }

        //Everything below this I don't really understand why I need per se? I accidentally double clicked them into existence and now removing them makes 
        // my robot mad

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbSpicyItalian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboThick_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

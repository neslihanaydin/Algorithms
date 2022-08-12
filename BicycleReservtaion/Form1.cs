using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neslihan300359919Bicycle
{
    public partial class Form1 : Form
    {

        String userName; 
        int numberOfDays;
        bool isSenior; // It's true if the Senior button is checked.
        bool isMember; // It's true if the Member button is checked.
        // The prices of Models
        const int model1Price = 14; 
        const int model2Price = 12; 
        const int model3Price = 10;

        int priceForChosenModel; // hold the price for chosen model by user.
        double total = 0.0; // total bill

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //A picture should be displayed for every model option.
        private void radioModel1_CheckedChanged(object sender, EventArgs e)
        {
            //Model 1 checked
            pictureBoxBicycle.Image = Properties.Resources.Model1;
        }
        //A picture should be displayed for every model option.

        private void radioModel2_CheckedChanged(object sender, EventArgs e)
        {
            //Model 2 checked
            pictureBoxBicycle.Image = Properties.Resources.Model2;
        }
        //A picture should be displayed for every model option.

        private void radioModel3_CheckedChanged(object sender, EventArgs e)
        {
            //Model 3 checked
            pictureBoxBicycle.Image = Properties.Resources.Model3;
        }

        //The user will press compute and the program will output the total.
        private void btnCompute_Click(object sender, EventArgs e)
        {

            try
            {
                userName = textBoxCustName.Text;
                numberOfDays = int.Parse(textBoxNumOfDays.Text);
                isSenior = checkSenior.Checked;
                isMember = checkMember.Checked;

                // First catch the bicycle model
                if (radioModel1.Checked)
                {
                    priceForChosenModel = model1Price;
                }
                else if (radioModel2.Checked)
                {
                    priceForChosenModel = model2Price;
                }
                else if (radioModel3.Checked)
                {
                    priceForChosenModel = model3Price;
                }


                // Calculate the price for chosen model, number of days times
                total = numberOfDays * priceForChosenModel;
                if (numberOfDays >= 6 && numberOfDays <= 10) //If the user rents for 6 to 10 days, a discount of 8 % is given.
                {
                    total = total - (total * 0.08);
                }
                else if (numberOfDays > 10) //If the user rents for more than 10 days, a discount of 15 percent is given.
                {
                    total = total - (total * 0.15);
                }
                //Then do more discounts for Senior and Members.
                if (isSenior)  //Additional discounts are given for senior citizens 10%
                {
                    total = total - (total * 0.10);
                }
                else if (isMember) //for members 12%.
                {
                    total = total - (total * 0.12);
                }
                else if (isSenior && isMember) //If the user is both a member and a senior
                {
                    double tempTotal = total - (total * 0.10); //First apply the senior discount
                    total = tempTotal - (tempTotal * 0.12); //Then apply the member discount
                }
                lblComputeResult.Text = "Hey " + textBoxCustName.Text.ToString() + " your total bill is " + total + " Thank you!"; //There is a label beside compute where the results is shown.


            }
            catch (System.FormatException e1) //if the user don't enter number of days
            {
                e1.Message.ToString();
                MessageBox.Show("You have to enter number of days.");
            }
         }

       
        //This method checks the validation for number of days
        private void textBoxNumOfDays_TextChanged(object sender, EventArgs e)
        {

           // Provide validations for entries.
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNumOfDays.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numeric values.");
                textBoxNumOfDays.Text = textBoxNumOfDays.Text.Remove(textBoxNumOfDays.Text.Length - 1);
            }
        }


        
    }
}

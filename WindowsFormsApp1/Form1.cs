using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<uint, user> userDictionary = new Dictionary<uint, user>();


        public Form1()
        {
            InitializeComponent();
        }

        private void createUser_button_Click(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName= "";
            string birthDate = "";
            string maleOrFemale = "";


            //check the user has entered a first and last name
            if (userFirstNameText.Text != null && userLastNameText != null)
            {
                //if they have lets assign what they entered to the first and last name
                firstName = userFirstNameText.Text;
                lastName = userLastNameText.Text;
            }
            else
            {
                outputBox.Text = "Please enter a first and last name";
            }
            //clear the output
            outputBox.Clear();

            //check to ensure they checked either "male" or "female"
            if(maleRadioButton.Checked || femaleRadioButton.Checked)
            {
                //if they had then assign the correct gender depending on what is checked
                if (maleRadioButton.Checked)
                {
                    maleOrFemale = "male";
                }
                else if (femaleRadioButton.Checked)
                {
                    maleOrFemale = "female";
                }
            }
            else
            {
                outputBox.Text = "Please check whether male or female";
            }
            //clear the output
            outputBox.Clear();

            //check to ensure they entereed a birthday, if so assign it to birthdate
            if (birthDateTextBox.Text != null)
            {
                birthDate = birthDateTextBox.Text;
            }
            else
            {
                outputBox.Text = "Please enter a birthdate"; 
            }

            //generate a random ID
            Random randomID = new Random();
            uint userID = (uint)randomID.Next(00000000, 100000000);

            //create a new user and add to the dictionary
            user newUser = new user(userID, firstName, lastName, birthDate, maleOrFemale);
            userDictionary.Add(userID, newUser);
        }

        //loads the next page when button clicked
        private void loadNextForm_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }
    }
}

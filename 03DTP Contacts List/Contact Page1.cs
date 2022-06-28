using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;


namespace _03DTP_Contacts_List
{
    public partial class Contact_Page1 : Form
    {
        // Blank values used to gather new contact information
        public static string name = string.Empty;
        public static string number = string.Empty;
        public static string age = string.Empty;

        // Ensures all buttons and features are working correctly.
        public Contact_Page1()
        {
            InitializeComponent();
            editName.Enabled = false;
            editNumber.Enabled = false;
            editAge.Enabled = false;
            name = string.Empty;
            number = string.Empty;
            age = string.Empty;
        }

        // Enables the Name textbox for user input
        private void btnName_Click(object sender, EventArgs e)
        {
            editName.Enabled = true;
            this.ActiveControl = editName;
            editName.Text = string.Empty;
        }

        // Readies the contact name to be passed into Form1 
        private void okName_Click(object sender, EventArgs e)
        {
            editName.Enabled = false;
            name = editName.Text;
            displayName.Text = name;
        }

        // Enables the Number textbox for user input
        private void btnNumber_Click(object sender, EventArgs e)
        {
            editNumber.Enabled = true;
            this.ActiveControl = editNumber;
            editNumber.Text = string.Empty;

        }

        // Readies the contact number to be passed into Form1
        private void okNumber_Click(object sender, EventArgs e)
        {
            // Ensures the contact number is inputted by the user in the correct format (numbers and spaces only)
            number = editNumber.Text;

            // Secures newly entered value as the correct variable
            if (Regex.IsMatch(number, @"^[\d\s]+$"))
            {
                displayNumber.Text = number;
                editNumber.Enabled = false;
            }

            // Resets the Number textbox for editing
            else
            {
                editNumber.Text = string.Empty;
                this.ActiveControl = editNumber;
            }
        }

        // Enables the Age textbox for user input
        private void btnAge_Click(object sender, EventArgs e)
        {
            editAge.Enabled = true;
            this.ActiveControl = editAge;
            editAge.Text = string.Empty;
        }

        // Readies the contact age to be passed into Form1
        private void okAge_Click(object sender, EventArgs e)
        {
            // Ensures the contact age is inputted by the user in the correct format (numbers only)
            age = editAge.Text;

            // Secures newly entered value as the correct variable
            if (Regex.IsMatch(age, @"^[\d\s]+$"))
            {
                displayAge.Text = ("Age: [ " + age + " ]");
                editAge.Enabled = false;
            }

            // Resets the Age textbox for editing
            else
            {
                editAge.Text = string.Empty;
                this.ActiveControl = editAge;
            }
        }

        // Passes all newly gathered contact information to Form1
        private void okAdd_Click(object sender, EventArgs e)
        {
            // Checks all values have been entered correctly
            if (name != string.Empty && number != string.Empty && age != string.Empty)
            {
                // Passes all newly gathered contact information to Form1
                Form1.contactName = name;
                Form1.contactNum = number;
                Form1.contactAge = age;

                // Resumes all Form1 processes
                Form1.createConfirm = true;
                this.Close();
            }
            // Sends an error window to inform the user of false inputs, engages edit boxes
            else
            {
                MessageBox.Show("Please input all required values.", "INVALID INPUTS");
                // Checks Age status
                if (age == string.Empty)
                {
                    editAge.Enabled = true;
                    this.ActiveControl = editAge;
                }

                // Checks Number status
                if (number == string.Empty)
                {
                    editNumber.Enabled = true;
                    editAge.Enabled = false;
                    this.ActiveControl = editNumber;
                }
                
                // Checks Name status
                if (name == string.Empty)
                {
                    editName.Enabled = true;
                    editAge.Enabled = false;
                    editNumber.Enabled = false;
                    this.ActiveControl = editName;
                }
            }
            
        }
    }
}

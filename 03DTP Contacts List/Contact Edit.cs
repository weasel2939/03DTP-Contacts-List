﻿using System;
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
    public partial class Contact_Edit : Form
    {
        // Blank values used to gather new contact information
        public static string name = Form1.edit_contactName;
        public static string number = Form1.edit_contactNum;
        public static string age = Form1.edit_contactAge;

        // Ensures all data is correctly gathered from Form1, and displayed on the proper textboxes
        public Contact_Edit()
        {
            InitializeComponent();
            // Pulls information from Form1
            name = Form1.edit_contactName;
            number = Form1.edit_contactNum;
            age = Form1.edit_contactAge;

            // Displays information in the correct boxes
            displayName.Text = name;
            displayNumber.Text = number;
            displayAge.Text = ("Age: [ " + age + " ]");

            // Ensures all values are set correctly
            editName.Text = name;
            editNumber.Text = number;
            editAge.Text = age;
        }

        // Activates the Name textbox
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
        private void okEdit_Click(object sender, EventArgs e)
        {
            Form1.edit_contactName = name;
            Form1.edit_contactNum = number;
            Form1.edit_contactAge = age;

            // Resumes all Form1 processes
            Form1.editConfirm = true;
            this.Close();
        }
    }
}

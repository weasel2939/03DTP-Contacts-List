using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03DTP_Contacts_List
{
    public partial class Contact_Page1 : Form
    {
        public static string name = "";
        public static int number = 0;
        public static int age = 0;

        public Contact_Page1()
        {
            InitializeComponent();
            editName.Enabled = false;
            editNumber.Enabled = false;
        }

        // use a writefile instead

        private void btnName_Click(object sender, EventArgs e)
        {
            editName.Enabled = true;
            this.ActiveControl = editName;
            editName.Text = "";

        }
        private void okName_Click(object sender, EventArgs e)
        {
            editName.Enabled = false;
            string name = editName.Text;
            displayName.Text = name;
            // need to add to the form1 list
            // use writefile instead, push to the list in Form1
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            editNumber.Enabled = true;
            this.ActiveControl = editNumber;
            editNumber.Text = "";

        }

        private void okNumber_Click(object sender, EventArgs e)
        {
            number = 0;
            bool isNumber = false;
            isNumber = int.TryParse(editNumber.Text, out number);

            if (!isNumber)
            {
                editNumber.Text = "";
                this.ActiveControl = editNumber;
            }
            else
            {
                displayNumber.Text = editNumber.Text;
                editNumber.Enabled = false;
                number = int.Parse(editNumber.Text);

            }

        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            editAge.Enabled = true;
            this.ActiveControl = editAge;
            editAge.Text = "";
        }

        private void okAge_Click(object sender, EventArgs e)
        {
            age = 0;
            bool isNumber = false;
            isNumber = int.TryParse(editAge.Text, out age);

            if (!isNumber)
            {
                editAge.Text = "";
                this.ActiveControl = editAge;
            }
            else
            {
                editAge.Enabled = false;
                displayAge.Text = ("Age: [ " + age + " ]");
                age = int.Parse(editAge.Text);
            }
        }

        private void okAdd_Click(object sender, EventArgs e)
        {
            Form1.contactName = name;
            Form1.contactNum = number;
            Form1.contactAge = age;
            Form1.createConfirm = true;
            this.Close();
        }
    }
}

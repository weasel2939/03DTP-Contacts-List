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
        public Contact_Page1()
        {
            InitializeComponent();
            editName.Enabled = false;
            editNumber.Enabled = false;
        }

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
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            editNumber.Enabled = true;
            this.ActiveControl = editNumber;
            editNumber.Text = "";

        }

        private void okNumber_Click(object sender, EventArgs e)
        {
            int number = 0;
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
    }
}

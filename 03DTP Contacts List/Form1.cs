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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] contactName = new string[global.contactCount];
        }
        public class global
        {
            public static int contactCount = 0;
            public static int num = contactCount;
        }

        private void contactNew_Click_1(object sender, EventArgs e)
        {
            // Creates the form
            global.num++;
            Form form = new Contact_Page1();
            form.Text = ("Contact " + global.num);
            form.Show();
            if (global.num > 1)
            {
                global.contactCount++;
            }
            // need to store data
        }
    }
}

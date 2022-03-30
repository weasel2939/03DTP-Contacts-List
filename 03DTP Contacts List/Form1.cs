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
        }
        public class global
        {
            public static int contactCount = 0;
        }

        private void contactNew_Click_1(object sender, EventArgs e)
        {
            // Creates the form

            Form form = new Contact_Page1();
            int num = global.contactCount + 1;
            form.Text = ("Contact " + num);
            form.Show();
            global.contactCount++;
        }
    }
}

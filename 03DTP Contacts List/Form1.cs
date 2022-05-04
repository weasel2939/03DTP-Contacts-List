using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _03DTP_Contacts_List
{
    public partial class Form1 : Form
    {
        public static bool editConfirm = false;
        public static bool createConfirm = false;
        public static string contactName = string.Empty;
        public static string contactNum = "";
        public static int contactAge = 0;
        // For editing
        public static string edit_contactName = string.Empty;
        public static string edit_contactNum = "";
        public static int edit_contactAge = 0;

        string filePath = @"contactStorage.txt";


        // For counting purposes, might have to remove.
        public class global
        {
            public static int contactCount = 0;
            public static int num = contactCount;
        }
        
        // Ensures all buttons are working correctly.
        public Form1()
        {
            InitializeComponent();
            contactDelete.Enabled = false;
            contactEdit.Enabled = false;
            this.ActiveControl = contactNew;
        }

        // writes to filepath
        public void createContact()
        {
            ListViewItem lvi = new ListViewItem(contactName);
            lvi.SubItems.Add(contactNum);
            lvi.SubItems.Add(contactAge.ToString());
            listView1.Items.Add(lvi);

            File.AppendAllText(filePath, $"{contactName},{contactNum},{contactAge.ToString()}\n");
        }

        // reads from filepath
        public void LoadContacts()
        {
            listView1.Items.Clear();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] sections = line.Split(',');

                ListViewItem lvi = new ListViewItem(sections[0]);
                lvi.SubItems.Add(sections[1]);
                lvi.SubItems.Add(sections[2]);
                listView1.Items.Add(lvi);
            }
        }
        // Creates new Contact_Page1 and pauses Form1.
        private void contactNew_Click_1(object sender, EventArgs e)
        {
            
            global.num++;

            Form newContact = new Contact_Page1();
            newContact.Text = ("Contact " + global.num);

            newContact.ShowDialog();

            if (createConfirm)
            {
                createContact();
            }

            if (global.num > 1)
            {
                global.contactCount++;
            }
        }

        // Runs after createContact is closed, pulling information from Contact_Page1 into Form1.
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        // Mainly for debugging, will probably remove in later versions.
        private void contactsLoad_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void contactEdit_Click(object sender, EventArgs e)
        {
            // make new contact_page but name it contact edit
            // do the opposite of when you make a contact, pull info from form1 and set the display boxes
            // allow the user to edit info, but don't override if it isn't needed, just send the variables back over

            edit_contactName = listView1.FocusedItem.SubItems[0].ToString();
            edit_contactNum = listView1.FocusedItem.SubItems[1].ToString();
            // this needs to be parsed diferently
            edit_contactAge = int.Parse(listView1.FocusedItem.SubItems[2].ToString());

            Form contactEdit = new Contact_Edit();
            contactEdit.Text = ("Contact " + global.num);

            contactEdit.ShowDialog();

            if (editConfirm)
            {
                // take the new information and reinsert it into the list and filepath
            }
        }


        // Allows for the contact to be edited/deleted.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactDelete.Enabled = true;
            contactEdit.Enabled = true;
        }

        // Removes the contact from both contactStorage and listView1.
        private void contactDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.FocusedItem.Index;
            List<string> allLines = File.ReadAllLines(filePath).ToList();

            allLines.RemoveAt(selectedIndex);

            File.WriteAllLines(filePath, allLines);
            LoadContacts();

            global.num--;
            global.contactCount--;
            contactDelete.Enabled = false;
        }

        // Clears all text from contactStorage.txt.
        private void contactsClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            File.WriteAllText(filePath, $"{string.Empty}");
            global.num = 0;
            global.contactCount = 0;
        }
    }
}

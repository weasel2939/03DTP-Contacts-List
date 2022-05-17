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
        public static string contactAge = "";
        // For editing
        public static string edit_contactName = string.Empty;
        public static string edit_contactNum = "";
        public static string edit_contactAge = "";

        public static int selectedIndex = 0;

        string filePath = @"C:\\contactStorage.txt";


        // For counting purposes, might have to remove.
        public class global
        {
            public static string[] lines = { "placeholder" };
            public static int contactCount = lines.Count();
            public static int num = contactCount;

        }
        
        // Ensures all buttons are working correctly.
        public Form1()
        {
            InitializeComponent();
            LoadContacts();
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

            global.lines = File.ReadAllLines(filePath);
            global.contactCount = global.lines.Count();
            global.num = global.contactCount;

            // Disables the user's Edit & Delete buttons.
            contactEdit.Enabled = false;
            contactDelete.Enabled = false;
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
                createConfirm = false;
                if (global.num > 1)
                {
                global.contactCount++;
                }
            }
            else
            {
                global.num--;
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
            // Creates new form based on Contact_Edit.
            // Selects and assigns the correct value for each contact.
            Form contactEditform = new Contact_Edit();
            int editNumber = selectedIndex + 1;
            contactEditform.Text = (edit_contactName);

            // Pauses Form1 and initiates Contact_Edit.
            contactEditform.ShowDialog();

            LoadContacts();

            if (editConfirm)
            {
                // takes the new information and reinsert it into the list and filepath
                List<string> allLines = File.ReadAllLines(filePath).ToList();

                allLines.RemoveAt(selectedIndex);
                allLines.Insert(selectedIndex, $"{edit_contactName},{edit_contactNum},{edit_contactAge.ToString()}");
                //
                File.WriteAllLines(filePath, allLines);
                selectedIndex = 0;
                LoadContacts();
                //
            }
        }


        // Allows for the contact to be edited/deleted.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactDelete.Enabled = true;

            // For editing.
            contactEdit.Enabled = true;
            selectedIndex = listView1.FocusedItem.Index;
            edit_contactName = listView1.FocusedItem.SubItems[0].Text;
            edit_contactNum = listView1.FocusedItem.SubItems[1].Text;
            edit_contactAge = listView1.FocusedItem.SubItems[2].Text;
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

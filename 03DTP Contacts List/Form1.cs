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
        // Values used to check confirmation on creation and editing of selected contacts
        public static bool editConfirm = false;
        public static bool createConfirm = false;
        // Blanks values which allow contact creation to be dynamic and infinite
        public static string contactName = string.Empty;
        public static string contactNum = string.Empty;
        public static string contactAge = string.Empty;
        // Temporary values used to edit a selected contact
        public static string edit_contactName = string.Empty;
        public static string edit_contactNum = string.Empty;
        public static string edit_contactAge = string.Empty;
        // Allows for a more controlled use of selectedIndex, removes chance of related errors
        public static int selectedIndex = 0;
        // Location for contact storage
        string filePath = @"contactStorage.txt";

        // Allows for proper indexing of contacts, ensures the number of contacts is always available for referal
        public class global
        {
            public static string[] lines = { "placeholder" };
            public static int contactCount = lines.Count();
            public static int num = contactCount;
        }
        
        // Ensures all buttons and features are working correctly.
        public Form1()
        {
            InitializeComponent();
            LoadContacts();
            contactDelete.Enabled = false;
            contactEdit.Enabled = false;
            this.ActiveControl = contactNew;

        }

        // Runs after createContact is closed, pulling information from Contact_Page1 into Form1.
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        // Takes recently aquired contact information and writes it into the filepath
        public void createContact()
        {
            // Assigns values as items in listView1
            ListViewItem lvi = new ListViewItem(string.Empty);
            lvi.SubItems.Add(contactName);
            lvi.SubItems.Add(contactNum);
            lvi.SubItems.Add(contactAge.ToString());
            listView1.Items.Add(lvi);

            // Writes values to filepath
            File.AppendAllText(filePath, $"{string.Empty},{contactName},{contactNum},{contactAge.ToString()}\n");
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
                lvi.SubItems.Add(sections[3]);
                listView1.Items.Add(lvi);
            }

            global.lines = File.ReadAllLines(filePath);
            global.contactCount = global.lines.Count();
            global.num = global.contactCount;

            // Disables the user's Edit & Delete buttons.
            contactEdit.Enabled = false;
            contactDelete.Enabled = false;
        }

        private void contactNew_Click_1(object sender, EventArgs e)
        {
            // Ensures the title of the creation window is the correct index
            global.num++;
            
            // Creates a new copy of "Contact Page1"
            Form newContact = new Contact_Page1();
            newContact.Text = ("Contact " + global.num);

            // Opens the new creation window and pauses the main form
            newContact.ShowDialog();

            // Checks if the user clicked the "Create Contact" button in the creation form
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

        // Mainly for debugging, will probably remove in later versions.
        private void contactsLoad_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void contactEdit_Click(object sender, EventArgs e)
        {
            // Creates new form based on Contact_Edit.
            Form contactEditform = new Contact_Edit();
            int editNumber = selectedIndex + 1;
            contactEditform.Text = (edit_contactName);

            // Pauses Form1 and initiates Contact_Edit.
            contactEditform.ShowDialog();

            // Checks if the user clicked the "Confirm Edits" button in the edit window
            if (editConfirm)
            {
                // Takes the new information and reinserts it into the list and filepath
                List<string> allLines = File.ReadAllLines(filePath).ToList();

                allLines.RemoveAt(selectedIndex);
                allLines.Insert(selectedIndex, $"{string.Empty},{edit_contactName},{edit_contactNum},{edit_contactAge.ToString()}");
                //
                File.WriteAllLines(filePath, allLines);
                // Clears the selected index to avoid program confusion, reloads the contact list
                selectedIndex = 0;
                LoadContacts();
            }
        }

        // Allows for the selected contact to be edited/deleted.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactDelete.Enabled = true;

            // For editing.
            contactEdit.Enabled = true;
            selectedIndex = listView1.FocusedItem.Index;
            edit_contactName = listView1.FocusedItem.SubItems[1].Text;
            edit_contactNum = listView1.FocusedItem.SubItems[2].Text;
            edit_contactAge = listView1.FocusedItem.SubItems[3].Text;
        }

        // Removes the selected contact from both contactStorage.txt and listView1.
        private void contactDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.FocusedItem.Index;
            List<string> allLines = File.ReadAllLines(filePath).ToList();

            allLines.RemoveAt(selectedIndex);

            File.WriteAllLines(filePath, allLines);
            LoadContacts();

            // Redefines the amount of contacts to correct any title issues
            global.num--;
            global.contactCount--;
            contactDelete.Enabled = false;
        }

        // Clears all text from contactStorage.txt.
        private void contactsClear_Click(object sender, EventArgs e)
        {
            // Confirmation window
            DialogResult clearContacts = MessageBox.Show(this, "Remove all contacts?", "Contact List Modification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (clearContacts == DialogResult.OK)
            {
                listView1.Items.Clear();
                File.WriteAllText(filePath, $"{string.Empty}");
                global.num = 0;
                global.contactCount = 0;
            }
            else if (clearContacts == DialogResult.Cancel)
            {
                // Does nothing, closes confirmation window
            }
        }
    }
}

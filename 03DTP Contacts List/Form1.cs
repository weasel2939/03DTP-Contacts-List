﻿using System;
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
        public static int contactNum = 0;
        public static int contactAge = 0;

        string filePath = @"contactStorage.txt";

        // writes to filepath
        public void createContact()
        {
            ListViewItem lvi = new ListViewItem(contactName);
            lvi.SubItems.Add(contactNum.ToString());
            lvi.SubItems.Add(contactAge.ToString());
            listView1.Items.Add(lvi);

            File.AppendAllText(filePath, $"{contactName},{contactNum.ToString()},{contactAge.ToString()}\n");
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

        public Form1()
        {
            InitializeComponent();
        }

        // For counting purposes, might have to remove.
        public class global
        {
            public static int contactCount = 0;
            public static int num = contactCount;
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

        }
    }
}

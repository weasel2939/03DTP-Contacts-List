﻿
namespace _03DTP_Contacts_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactNew = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.placeholder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactsLoad = new System.Windows.Forms.Button();
            this.contactEdit = new System.Windows.Forms.Button();
            this.contactDelete = new System.Windows.Forms.Button();
            this.contactsClear = new System.Windows.Forms.Button();
            this.contactDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contactNew
            // 
            this.contactNew.BackColor = System.Drawing.SystemColors.Control;
            this.contactNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.contactNew.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.contactNew.Location = new System.Drawing.Point(12, 12);
            this.contactNew.Name = "contactNew";
            this.contactNew.Size = new System.Drawing.Size(381, 28);
            this.contactNew.TabIndex = 1;
            this.contactNew.Text = "New Contact";
            this.contactNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.contactNew.UseVisualStyleBackColor = false;
            this.contactNew.Click += new System.EventHandler(this.contactNew_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placeholder,
            this.contName,
            this.contNum,
            this.contAge});
            this.listView1.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 313);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // placeholder
            // 
            this.placeholder.Text = "";
            this.placeholder.Width = 0;
            // 
            // contName
            // 
            this.contName.Text = "Name";
            this.contName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contName.Width = 183;
            // 
            // contNum
            // 
            this.contNum.Text = "Phone Number";
            this.contNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contNum.Width = 138;
            // 
            // contAge
            // 
            this.contAge.Text = "Age";
            this.contAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contAge.Width = 56;
            // 
            // contactsLoad
            // 
            this.contactsLoad.BackColor = System.Drawing.SystemColors.Control;
            this.contactsLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.contactsLoad.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsLoad.Location = new System.Drawing.Point(12, 404);
            this.contactsLoad.Name = "contactsLoad";
            this.contactsLoad.Size = new System.Drawing.Size(113, 23);
            this.contactsLoad.TabIndex = 4;
            this.contactsLoad.Text = "Refresh Page";
            this.contactsLoad.UseVisualStyleBackColor = false;
            this.contactsLoad.Click += new System.EventHandler(this.contactsLoad_Click);
            // 
            // contactEdit
            // 
            this.contactEdit.BackColor = System.Drawing.SystemColors.Control;
            this.contactEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.contactEdit.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactEdit.Location = new System.Drawing.Point(12, 365);
            this.contactEdit.Name = "contactEdit";
            this.contactEdit.Size = new System.Drawing.Size(102, 23);
            this.contactEdit.TabIndex = 5;
            this.contactEdit.Text = "Edit Contact";
            this.contactEdit.UseVisualStyleBackColor = false;
            this.contactEdit.Click += new System.EventHandler(this.contactEdit_Click);
            // 
            // contactDelete
            // 
            this.contactDelete.BackColor = System.Drawing.SystemColors.Control;
            this.contactDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.contactDelete.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactDelete.Location = new System.Drawing.Point(291, 365);
            this.contactDelete.Name = "contactDelete";
            this.contactDelete.Size = new System.Drawing.Size(102, 23);
            this.contactDelete.TabIndex = 6;
            this.contactDelete.Text = "Delete Contact";
            this.contactDelete.UseVisualStyleBackColor = false;
            this.contactDelete.Click += new System.EventHandler(this.contactDelete_Click);
            // 
            // contactsClear
            // 
            this.contactsClear.BackColor = System.Drawing.SystemColors.Control;
            this.contactsClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.contactsClear.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsClear.Location = new System.Drawing.Point(280, 404);
            this.contactsClear.Name = "contactsClear";
            this.contactsClear.Size = new System.Drawing.Size(113, 23);
            this.contactsClear.TabIndex = 7;
            this.contactsClear.Text = "Clear All Contacts";
            this.contactsClear.UseVisualStyleBackColor = false;
            this.contactsClear.Click += new System.EventHandler(this.contactsClear_Click);
            // 
            // contactDisplay
            // 
            this.contactDisplay.Location = new System.Drawing.Point(120, 366);
            this.contactDisplay.Name = "contactDisplay";
            this.contactDisplay.ReadOnly = true;
            this.contactDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contactDisplay.Size = new System.Drawing.Size(165, 20);
            this.contactDisplay.TabIndex = 8;
            this.contactDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(405, 433);
            this.Controls.Add(this.contactDisplay);
            this.Controls.Add(this.contactsClear);
            this.Controls.Add(this.contactDelete);
            this.Controls.Add(this.contactEdit);
            this.Controls.Add(this.contactsLoad);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.contactNew);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Contact Storage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contactNew;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader contName;
        private System.Windows.Forms.ColumnHeader contNum;
        private System.Windows.Forms.ColumnHeader contAge;
        private System.Windows.Forms.Button contactsLoad;
        private System.Windows.Forms.Button contactEdit;
        private System.Windows.Forms.Button contactDelete;
        private System.Windows.Forms.Button contactsClear;
        private System.Windows.Forms.ColumnHeader placeholder;
        private System.Windows.Forms.TextBox contactDisplay;
    }
}


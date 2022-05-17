
namespace _03DTP_Contacts_List
{
    partial class Contact_Edit
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
            this.okEdit = new System.Windows.Forms.Button();
            this.displayAge = new System.Windows.Forms.Label();
            this.okAge = new System.Windows.Forms.Button();
            this.editAge = new System.Windows.Forms.TextBox();
            this.btnAge = new System.Windows.Forms.Button();
            this.okNumber = new System.Windows.Forms.Button();
            this.editNumber = new System.Windows.Forms.TextBox();
            this.displayNumber = new System.Windows.Forms.Label();
            this.displayName = new System.Windows.Forms.Label();
            this.okName = new System.Windows.Forms.Button();
            this.editName = new System.Windows.Forms.TextBox();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okEdit
            // 
            this.okEdit.BackColor = System.Drawing.SystemColors.Control;
            this.okEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okEdit.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okEdit.Location = new System.Drawing.Point(15, 301);
            this.okEdit.Name = "okEdit";
            this.okEdit.Size = new System.Drawing.Size(225, 32);
            this.okEdit.TabIndex = 10;
            this.okEdit.Text = "Confirm Edits";
            this.okEdit.UseVisualStyleBackColor = false;
            this.okEdit.Click += new System.EventHandler(this.okEdit_Click);
            // 
            // displayAge
            // 
            this.displayAge.AutoSize = true;
            this.displayAge.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAge.Location = new System.Drawing.Point(27, 64);
            this.displayAge.Name = "displayAge";
            this.displayAge.Size = new System.Drawing.Size(52, 20);
            this.displayAge.TabIndex = 37;
            this.displayAge.Text = "Age: [ x ]";
            // 
            // okAge
            // 
            this.okAge.BackColor = System.Drawing.SystemColors.Control;
            this.okAge.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okAge.Location = new System.Drawing.Point(165, 251);
            this.okAge.Name = "okAge";
            this.okAge.Size = new System.Drawing.Size(75, 20);
            this.okAge.TabIndex = 9;
            this.okAge.Text = "OK";
            this.okAge.UseVisualStyleBackColor = false;
            this.okAge.Click += new System.EventHandler(this.okAge_Click);
            // 
            // editAge
            // 
            this.editAge.Enabled = false;
            this.editAge.Location = new System.Drawing.Point(15, 251);
            this.editAge.Name = "editAge";
            this.editAge.Size = new System.Drawing.Size(122, 20);
            this.editAge.TabIndex = 8;
            // 
            // btnAge
            // 
            this.btnAge.BackColor = System.Drawing.SystemColors.Control;
            this.btnAge.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnAge.Location = new System.Drawing.Point(15, 226);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(75, 23);
            this.btnAge.TabIndex = 7;
            this.btnAge.Text = "Edit Age";
            this.btnAge.UseVisualStyleBackColor = false;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // okNumber
            // 
            this.okNumber.BackColor = System.Drawing.SystemColors.Control;
            this.okNumber.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okNumber.Location = new System.Drawing.Point(165, 182);
            this.okNumber.Name = "okNumber";
            this.okNumber.Size = new System.Drawing.Size(75, 20);
            this.okNumber.TabIndex = 6;
            this.okNumber.Text = "OK";
            this.okNumber.UseVisualStyleBackColor = false;
            this.okNumber.Click += new System.EventHandler(this.okNumber_Click);
            // 
            // editNumber
            // 
            this.editNumber.Enabled = false;
            this.editNumber.Location = new System.Drawing.Point(15, 182);
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(122, 20);
            this.editNumber.TabIndex = 5;
            // 
            // displayNumber
            // 
            this.displayNumber.AutoSize = true;
            this.displayNumber.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNumber.Location = new System.Drawing.Point(25, 42);
            this.displayNumber.Name = "displayNumber";
            this.displayNumber.Size = new System.Drawing.Size(93, 20);
            this.displayNumber.TabIndex = 31;
            this.displayNumber.Text = "Contact Number";
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.displayName.Location = new System.Drawing.Point(15, 15);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(96, 29);
            this.displayName.TabIndex = 30;
            this.displayName.Text = "Edit Contact";
            // 
            // okName
            // 
            this.okName.BackColor = System.Drawing.SystemColors.Control;
            this.okName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okName.Location = new System.Drawing.Point(165, 121);
            this.okName.Name = "okName";
            this.okName.Size = new System.Drawing.Size(75, 20);
            this.okName.TabIndex = 3;
            this.okName.Text = "OK";
            this.okName.UseVisualStyleBackColor = false;
            this.okName.Click += new System.EventHandler(this.okName_Click);
            // 
            // editName
            // 
            this.editName.Enabled = false;
            this.editName.Location = new System.Drawing.Point(15, 121);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(122, 20);
            this.editName.TabIndex = 2;
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.SystemColors.Control;
            this.btnNumber.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnNumber.Location = new System.Drawing.Point(15, 157);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(75, 23);
            this.btnNumber.TabIndex = 4;
            this.btnNumber.Text = "Edit Number";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.SystemColors.Control;
            this.btnName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnName.Location = new System.Drawing.Point(15, 96);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "Edit Name";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // Contact_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 353);
            this.Controls.Add(this.okEdit);
            this.Controls.Add(this.displayAge);
            this.Controls.Add(this.okAge);
            this.Controls.Add(this.editAge);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.okNumber);
            this.Controls.Add(this.editNumber);
            this.Controls.Add(this.displayNumber);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.okName);
            this.Controls.Add(this.editName);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnName);
            this.Name = "Contact_Edit";
            this.Text = "Contact_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okEdit;
        private System.Windows.Forms.Label displayAge;
        private System.Windows.Forms.Button okAge;
        private System.Windows.Forms.TextBox editAge;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.Button okNumber;
        private System.Windows.Forms.TextBox editNumber;
        private System.Windows.Forms.Label displayNumber;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Button okName;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button btnName;
    }
}
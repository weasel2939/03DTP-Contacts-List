
namespace _03DTP_Contacts_List
{
    partial class Contact_Page1
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
            this.editName = new System.Windows.Forms.TextBox();
            this.okName = new System.Windows.Forms.Button();
            this.displayName = new System.Windows.Forms.Label();
            this.displayNumber = new System.Windows.Forms.Label();
            this.okNumber = new System.Windows.Forms.Button();
            this.editNumber = new System.Windows.Forms.TextBox();
            this.okAge = new System.Windows.Forms.Button();
            this.editAge = new System.Windows.Forms.TextBox();
            this.displayAge = new System.Windows.Forms.Label();
            this.okAdd = new System.Windows.Forms.Button();
            this.warnNumber = new System.Windows.Forms.Label();
            this.warnAge = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editName
            // 
            this.editName.Location = new System.Drawing.Point(15, 113);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(122, 20);
            this.editName.TabIndex = 2;
            // 
            // okName
            // 
            this.okName.BackColor = System.Drawing.SystemColors.Control;
            this.okName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okName.Location = new System.Drawing.Point(165, 113);
            this.okName.Name = "okName";
            this.okName.Size = new System.Drawing.Size(75, 20);
            this.okName.TabIndex = 3;
            this.okName.Text = "OK";
            this.okName.UseVisualStyleBackColor = false;
            this.okName.Click += new System.EventHandler(this.okName_Click);
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.displayName.Location = new System.Drawing.Point(15, 15);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(102, 29);
            this.displayName.TabIndex = 4;
            this.displayName.Text = "New Contact";
            // 
            // displayNumber
            // 
            this.displayNumber.AutoSize = true;
            this.displayNumber.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNumber.Location = new System.Drawing.Point(25, 42);
            this.displayNumber.Name = "displayNumber";
            this.displayNumber.Size = new System.Drawing.Size(93, 20);
            this.displayNumber.TabIndex = 5;
            this.displayNumber.Text = "Contact Number";
            // 
            // okNumber
            // 
            this.okNumber.BackColor = System.Drawing.SystemColors.Control;
            this.okNumber.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okNumber.Location = new System.Drawing.Point(165, 166);
            this.okNumber.Name = "okNumber";
            this.okNumber.Size = new System.Drawing.Size(75, 20);
            this.okNumber.TabIndex = 6;
            this.okNumber.Text = "OK";
            this.okNumber.UseVisualStyleBackColor = false;
            this.okNumber.Click += new System.EventHandler(this.okNumber_Click);
            // 
            // editNumber
            // 
            this.editNumber.Location = new System.Drawing.Point(15, 166);
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(122, 20);
            this.editNumber.TabIndex = 5;
            // 
            // okAge
            // 
            this.okAge.BackColor = System.Drawing.SystemColors.Control;
            this.okAge.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okAge.Location = new System.Drawing.Point(165, 234);
            this.okAge.Name = "okAge";
            this.okAge.Size = new System.Drawing.Size(75, 20);
            this.okAge.TabIndex = 9;
            this.okAge.Text = "OK";
            this.okAge.UseVisualStyleBackColor = false;
            this.okAge.Click += new System.EventHandler(this.okAge_Click);
            // 
            // editAge
            // 
            this.editAge.Location = new System.Drawing.Point(15, 234);
            this.editAge.Name = "editAge";
            this.editAge.Size = new System.Drawing.Size(122, 20);
            this.editAge.TabIndex = 8;
            // 
            // displayAge
            // 
            this.displayAge.AutoSize = true;
            this.displayAge.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAge.Location = new System.Drawing.Point(27, 64);
            this.displayAge.Name = "displayAge";
            this.displayAge.Size = new System.Drawing.Size(52, 20);
            this.displayAge.TabIndex = 11;
            this.displayAge.Text = "Age: [ x ]";
            // 
            // okAdd
            // 
            this.okAdd.BackColor = System.Drawing.SystemColors.Control;
            this.okAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.okAdd.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okAdd.Location = new System.Drawing.Point(15, 289);
            this.okAdd.Name = "okAdd";
            this.okAdd.Size = new System.Drawing.Size(225, 32);
            this.okAdd.TabIndex = 10;
            this.okAdd.Text = "Create New Contact";
            this.okAdd.UseVisualStyleBackColor = false;
            this.okAdd.Click += new System.EventHandler(this.okAdd_Click);
            // 
            // warnNumber
            // 
            this.warnNumber.AutoSize = true;
            this.warnNumber.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnNumber.ForeColor = System.Drawing.Color.DarkRed;
            this.warnNumber.Location = new System.Drawing.Point(16, 187);
            this.warnNumber.Name = "warnNumber";
            this.warnNumber.Size = new System.Drawing.Size(84, 20);
            this.warnNumber.TabIndex = 12;
            this.warnNumber.Text = "Warning Label";
            // 
            // warnAge
            // 
            this.warnAge.AutoSize = true;
            this.warnAge.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnAge.ForeColor = System.Drawing.Color.DarkRed;
            this.warnAge.Location = new System.Drawing.Point(16, 257);
            this.warnAge.Name = "warnAge";
            this.warnAge.Size = new System.Drawing.Size(84, 20);
            this.warnAge.TabIndex = 13;
            this.warnAge.Text = "Warning Label";
            // 
            // labelNum
            // 
            this.labelNum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelNum.Location = new System.Drawing.Point(29, 143);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(86, 20);
            this.labelNum.TabIndex = 15;
            this.labelNum.Text = "Edit Number";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAge
            // 
            this.labelAge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelAge.Location = new System.Drawing.Point(31, 211);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(69, 20);
            this.labelAge.TabIndex = 16;
            this.labelAge.Text = "Edit Age";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelName.Location = new System.Drawing.Point(31, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(69, 20);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Edit Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Contact_Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(254, 332);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.warnAge);
            this.Controls.Add(this.warnNumber);
            this.Controls.Add(this.okAdd);
            this.Controls.Add(this.displayAge);
            this.Controls.Add(this.okAge);
            this.Controls.Add(this.editAge);
            this.Controls.Add(this.okNumber);
            this.Controls.Add(this.editNumber);
            this.Controls.Add(this.displayNumber);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.okName);
            this.Controls.Add(this.editName);
            this.Name = "Contact_Page1";
            this.Text = "Contact_Page1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Button okName;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Label displayNumber;
        private System.Windows.Forms.Button okNumber;
        private System.Windows.Forms.TextBox editNumber;
        private System.Windows.Forms.Button okAge;
        private System.Windows.Forms.TextBox editAge;
        private System.Windows.Forms.Label displayAge;
        private System.Windows.Forms.Button okAdd;
        private System.Windows.Forms.Label warnNumber;
        private System.Windows.Forms.Label warnAge;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
    }
}


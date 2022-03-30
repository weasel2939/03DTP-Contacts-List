
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
            this.btnName = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.editName = new System.Windows.Forms.TextBox();
            this.okName = new System.Windows.Forms.Button();
            this.displayName = new System.Windows.Forms.Label();
            this.displayNumber = new System.Windows.Forms.Label();
            this.okNumber = new System.Windows.Forms.Button();
            this.editNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(22, 34);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Edit Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(22, 116);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(75, 23);
            this.btnNumber.TabIndex = 1;
            this.btnNumber.Text = "Edit Number";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // editName
            // 
            this.editName.Enabled = false;
            this.editName.Location = new System.Drawing.Point(22, 63);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(122, 20);
            this.editName.TabIndex = 2;
            // 
            // okName
            // 
            this.okName.Location = new System.Drawing.Point(165, 63);
            this.okName.Name = "okName";
            this.okName.Size = new System.Drawing.Size(75, 20);
            this.okName.TabIndex = 3;
            this.okName.Text = "OK";
            this.okName.UseVisualStyleBackColor = true;
            this.okName.Click += new System.EventHandler(this.okName_Click);
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.Location = new System.Drawing.Point(480, 34);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(109, 21);
            this.displayName.TabIndex = 4;
            this.displayName.Text = "Contact Name";
            // 
            // displayNumber
            // 
            this.displayNumber.AutoSize = true;
            this.displayNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNumber.Location = new System.Drawing.Point(492, 63);
            this.displayNumber.Name = "displayNumber";
            this.displayNumber.Size = new System.Drawing.Size(97, 16);
            this.displayNumber.TabIndex = 5;
            this.displayNumber.Text = "Contact Number";
            // 
            // okNumber
            // 
            this.okNumber.Location = new System.Drawing.Point(165, 145);
            this.okNumber.Name = "okNumber";
            this.okNumber.Size = new System.Drawing.Size(75, 20);
            this.okNumber.TabIndex = 7;
            this.okNumber.Text = "OK";
            this.okNumber.UseVisualStyleBackColor = true;
            this.okNumber.Click += new System.EventHandler(this.okNumber_Click);
            // 
            // editNumber
            // 
            this.editNumber.Enabled = false;
            this.editNumber.Location = new System.Drawing.Point(22, 145);
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(122, 20);
            this.editNumber.TabIndex = 6;
            // 
            // Contact_Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okNumber);
            this.Controls.Add(this.editNumber);
            this.Controls.Add(this.displayNumber);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.okName);
            this.Controls.Add(this.editName);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnName);
            this.Name = "Contact_Page1";
            this.Text = "Contact_Page1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Button okName;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Label displayNumber;
        private System.Windows.Forms.Button okNumber;
        private System.Windows.Forms.TextBox editNumber;
    }
}


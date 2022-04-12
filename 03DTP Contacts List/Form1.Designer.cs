
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
            this.contName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // contactNew
            // 
            this.contactNew.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNew.Location = new System.Drawing.Point(74, 25);
            this.contactNew.Name = "contactNew";
            this.contactNew.Size = new System.Drawing.Size(160, 29);
            this.contactNew.TabIndex = 1;
            this.contactNew.Text = "New Contact";
            this.contactNew.UseVisualStyleBackColor = true;
            this.contactNew.Click += new System.EventHandler(this.contactNew_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contName,
            this.contNum,
            this.contAge});
            this.listView1.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(240, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(251, 287);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // contName
            // 
            this.contName.Text = "Name";
            this.contName.Width = 73;
            // 
            // contNum
            // 
            this.contNum.Text = "Phone Number";
            this.contNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contNum.Width = 116;
            // 
            // contAge
            // 
            this.contAge.Text = "Age";
            this.contAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contAge.Width = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.contactNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contactNew;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader contName;
        private System.Windows.Forms.ColumnHeader contNum;
        private System.Windows.Forms.ColumnHeader contAge;
    }
}


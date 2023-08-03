namespace ContactFormManagementSystem
{
    partial class ContactForm
    {
        private System.ComponentModel.IContainer components = null;

         // ContactForm.Designer.cs
 protected override void Dispose(bool disposing)
 {
     if (disposing && (components != null))
     {
         components.Dispose();
     }
     base.Dispose(disposing);
 }


        private void InitializeComponent()
        {
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnViewContacts = new System.Windows.Forms.Button();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(12, 12);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(100, 30);
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            
            // 
            // btnViewContacts
            // 
            this.btnViewContacts.Location = new System.Drawing.Point(12, 48);
            this.btnViewContacts.Name = "btnViewContacts";
            this.btnViewContacts.Size = new System.Drawing.Size(100, 30);
            this.btnViewContacts.Text = "View Contacts";
            this.btnViewContacts.Click += new System.EventHandler(this.btnViewContacts_Click);
            
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Location = new System.Drawing.Point(12, 84);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateContact.Text = "Update Contact";
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(130, 48);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 22);
            
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 16;
            this.lstContacts.Location = new System.Drawing.Point(12, 120);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(268, 292);
            
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 420);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateContact);
            this.Controls.Add(this.btnViewContacts);
            this.Controls.Add(this.btnAddContact);
            this.Name = "ContactForm";
            this.Text = "Contact Management System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnViewContacts;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ListBox lstContacts;
    }
}

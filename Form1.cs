using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactFormManagementSystem
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public ContactForm()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;

            contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber, Email = email });
            MessageBox.Show("Contact added successfully!");
            ClearInputFields();
        }

        private void btnViewContacts_Click(object sender, EventArgs e)
        {
            if (contacts.Count == 0)
            {
                MessageBox.Show("No contacts found.");
                return;
            }

            string contactList = "Contacts:\n\n";
            foreach (var contact in contacts)
            {
                contactList += $"Name: {contact.Name}\n";
                contactList += $"Phone: {contact.PhoneNumber}\n";
                contactList += $"Email: {contact.Email}\n\n";
            }

            MessageBox.Show(contactList);
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstContacts.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < contacts.Count)
            {
                string name = txtName.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string email = txtEmail.Text;

                contacts[selectedIndex].Name = name;
                contacts[selectedIndex].PhoneNumber = phoneNumber;
                contacts[selectedIndex].Email = email;

                MessageBox.Show("Contact updated successfully!");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please select a contact to update.");
            }
        }

        private void ClearInputFields()
        {
            txtName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }

    class Contact
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrganizerB.Forms
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()=>
            InitializeComponent();

        ContactsProcesses contacts = new ContactsProcesses();

        private void AddButton_Click(object sender, EventArgs e)
        {
            contacts.Add(NameT.Text, PhoneT.Text);
            ContactsForm_Shown(this,e);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            List<ContactsRow> contactsList;
            if (FindT.Text.Length!=0)
            {
                if (Char.IsDigit(Convert.ToChar(FindT.Text[0])))
                    contactsList = contacts.findByPhone(FindT.Text);
                else
                    contactsList = contacts.findByName(FindT.Text);
            }
            else
            {
                contactsList = contacts.GetContacts();
            }

            ContactsView.Rows.Clear();
            foreach (ContactsRow row in contactsList)
                ContactsView.Rows.Add(row.ID, row.name, row.phone);


        }

        private void ContactsForm_Shown(object sender, EventArgs e)
        {
            ContactsView.Rows.Clear();
            foreach(ContactsRow row in contacts.GetContacts())
                ContactsView.Rows.Add(row.ID,row.name,row.phone);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ContactsView.SelectedRows.Count == 1)
                contacts.deleteContact((string)ContactsView.SelectedRows[0].Cells[0].Value);
            else 
                MessageBox.Show("Выберите одну строку и повторите попытку", "Ошибка удаления");
        }
    }
}

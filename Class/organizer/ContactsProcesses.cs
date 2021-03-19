using System;
using System.Collections.Generic;

namespace OrganizerB
{
    class ContactsProcesses
    {
        private DeleteContact delete = new DeleteContact();
        private FindContacts find = new FindContacts();
        private GetAllContacts get = new GetAllContacts();
        private AddContact add = new AddContact();
        
        
        public void Add(string name,string phone)
        {
            ContactsRow contact = new ContactsRow();
            contact.name = name;
            contact.phone = phone;
            add.Add(contact);
        }

        public List<ContactsRow> GetContacts()
        {
            return get.Get();
        }

        public List<ContactsRow>findByName(string name)
        {
            return find.FindByName(name);
        }

        public List<ContactsRow>findByPhone(string phone)
        {
            return find.FindByPhone(phone);
        }

        public void deleteContact(string id)
        {
            ContactsRow contact = new ContactsRow();
            contact.ID = Convert.ToInt32(id);
            delete.Delete(contact);
        }
      
    }
}

using System;
using System.Collections.Generic;

namespace addressBook
{
    public class AddressBook 
    {
        // Dictionary of contacts
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        // two methods 
        // AddContact
        public void AddContact(Contact contact) {
            try 
            {
                addressBook.Add(contact.Email, contact);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"This contact was already added {ex.Message}");
            }
        }

        // GetByEmail
        public Contact GetByEmail(string email) 
        {
            return addressBook[email];
        }

    }
}


using System.Collections.Generic;
using System.Threading.Tasks;
namespace BlazorApp1.Models
{
	public class ContactService
	{

		private static List<Contact> items = new List<Contact>();

		public ContactService()
        {
			items.Add(new  Contact() { Id = 1, FirstName = "Alaa", LastName = "almasri", Email = "alaalmasri272@gmail.com", PhoneNumber = "123-456-7890" });
			items.Add(new Contact() { Id = 2, FirstName = "isam", LastName = "mohammad", Email = "isammohammad@gmail.com", PhoneNumber = "333-456-7890" });
			items.Add(new Contact() { Id = 3, FirstName = "omar", LastName = "naser", Email = "omaernaser@gmail.com", PhoneNumber = "44-5454-326" });
		}
		public List<Contact> GetItems()
		{
			return items;
		}
        public Task<Contact> GetContactByIdAsync(int id)
        {
            var task = items.Find(t => t.Id == id);
            return Task.FromResult(task);
        }

        public void CreateContact(Contact contact)
        {
            contact.Id = items.Count+1;
            // In a real-world application, you might save the task to a database.
            items.Add(contact);
        }

        public void UpdateContact(Contact updatedContact)
        {
            var index = items.FindIndex(t => t.Id == updatedContact.Id);
            if (index != -1)
            {
                items[index] = updatedContact;
            }
        }

        public void DeleteContact(int id)
        {
            var ContactToRemove = items.Find(t => t.Id == id);
            if (ContactToRemove != null)
            {
                items.Remove(ContactToRemove);
            }
        }


    }
}

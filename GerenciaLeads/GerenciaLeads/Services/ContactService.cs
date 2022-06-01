using GerenciaLeads.Api.Context;
using GerenciaLeads.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciaLeads.Api.Services
{
    public class ContactService : IContactService
    {
        private readonly GerenciaLeadsContext _context;

        public ContactService(GerenciaLeadsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await _context.Contact.ToListAsync();
        }
        public async Task<Contact> GetContactById(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            return contact;
        }
        public async Task<IEnumerable<Contact>> GetContactsByName(string name)
        {
            IEnumerable<Contact> contacts; 
            if (!string.IsNullOrEmpty(name))
            {
                contacts = await _context.Contact.Where(n => n.FullName.Contains(name)).ToListAsync();
            }
            else
            {
                contacts = await GetContacts();
            }
            return contacts;
        }

        public async Task<IEnumerable<Contact>> GetContactsByAccepted(string accepted)
        {
            IEnumerable<Contact> contacts = await _context.Contact.Where(n => n.Accepted.Equals(accepted)).ToListAsync();
            return contacts;
        }
        public async Task CreateContact(Contact contact)
        {
            _context.Contact.Add(contact);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateContact(Contact contact)
        {
            _context.Entry(contact).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteContact(Contact contact)
        {
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
        }
    }
}

using GerenciaLeads.Api.Models;

namespace GerenciaLeads.Api.Services
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetContacts();
        Task<Contact> GetContactById(int id);
        Task<IEnumerable<Contact>> GetContactsByName(string name);
        Task<IEnumerable<Contact>> GetContactsByAccepted(string accepted);
        Task CreateContact(Contact contact);
        Task UpdateContact(Contact contact);
        Task DeleteContact(Contact contact);
    }
}

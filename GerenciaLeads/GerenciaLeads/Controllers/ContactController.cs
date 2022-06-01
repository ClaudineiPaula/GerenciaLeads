using GerenciaLeads.Api.Models;
using GerenciaLeads.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciaLeads.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Contact>>> GetContacts(string accepted)
        {
            try
            {
                var contacts = await _contactService.GetContactsByAccepted(accepted);
                return Ok(contacts);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error getting contacts");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Edit(int id, [FromBody] Contact contact)
        {
            try
            {
                if(contact.Id == id)
                {
                    await _contactService.UpdateContact(contact);
                    return Ok($"Contact id={id} sucess update");
                }
                else
                {
                    return BadRequest("Inconsistent data");
                }
            }
            catch
            {
                return BadRequest("Invalid request");
            }
        }
    }
}

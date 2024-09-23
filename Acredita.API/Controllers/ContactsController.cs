using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/contacts")]
    public class ContactsController : ControllerBase
    {
        private readonly DataContext dataContext;

        public ContactsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Contact contact)
        {
            dataContext.Contacts.Add(contact);
            await dataContext.SaveChangesAsync();
            return Ok(contact);
        }
    }
}

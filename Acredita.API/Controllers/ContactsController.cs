using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Contacts.ToListAsync());
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

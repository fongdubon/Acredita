using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/subject")]
    public class SubjectsController : ControllerBase

    {
        private readonly DataContext dataContext;

        public SubjectsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Subject subject)
        {
            dataContext.Subjects.Add(subject);
            await dataContext.SaveChangesAsync();
            return Ok(subject);
        }
    }
}

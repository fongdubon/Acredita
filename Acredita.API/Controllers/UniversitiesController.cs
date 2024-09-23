
using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/universities")]
    public class UniversitiesController:ControllerBase
    {
        private readonly DataContext dataContext;

        public UniversitiesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(University university)
        {
            dataContext.Universities.Add(university);
            await dataContext.SaveChangesAsync();
            return Ok(university);
        }
    }
}

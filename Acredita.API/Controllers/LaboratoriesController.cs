using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/laboratories")]
    public class LaboratoriesController : ControllerBase
    {
        private readonly DataContext dataContext;
        public LaboratoriesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Laboratory laboratory)
        {
            dataContext.Laboratories.Add(laboratory);
            await dataContext.SaveChangesAsync();
            return Ok(laboratory);
        }
    }
}
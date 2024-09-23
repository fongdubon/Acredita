using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/majors")]
    public class MajorsController: ControllerBase
    {
        private readonly DataContext dataContext;

        public MajorsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Major major)
        {
            dataContext.Majors.Add(major);
            await dataContext.SaveChangesAsync();
            return Ok(major);
        }
    }
}

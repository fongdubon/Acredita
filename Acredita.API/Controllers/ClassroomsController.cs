using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/controllers")]
    public class ClassroomsController : ControllerBase
    {
        private readonly DataContext dataContext;

        public ClassroomsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]


        public async Task<IActionResult> PostAsync(Classroom classroom)
        {
            dataContext.Classrooms.Add(classroom);
            await dataContext.SaveChangesAsync();
            return Ok(classroom);


        }


    }
}
using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/classrooms")]
    public class ClassroomsController : ControllerBase
    {
        private readonly DataContext dataContext;

        public ClassroomsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Classrooms.ToListAsync());
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
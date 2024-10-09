using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/teachers")]
    public class TeachersController : ControllerBase
    {
        private readonly DataContext dataContext;

        public TeachersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Teachers.ToListAsync());
        }
        [HttpPost]

        public async Task<IActionResult> PostAsync(Teacher teacher)
        {
            dataContext.Teachers.Add(teacher); // se agrega al contexto de datos la carera :p
            await dataContext.SaveChangesAsync();
            return Ok(teacher); // agrega los datos al servidor epicooo

        }
    }
}
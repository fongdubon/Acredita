using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

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
        [HttpPost]

        public async Task<IActionResult> PostAsync(Teacher teacher)
        {
            dataContext.Teachers.Add(teacher); // se agrega al contexto de datos la carera :p
            await dataContext.SaveChangesAsync();
            return Ok(teacher); // agrega los datos al servidor epicooo

        }
    }
}
using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly DataContext dataContext;

        public StudentsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Students.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Student student) //http results
        {
            dataContext.Students.Add(student); //se agrega
            await dataContext.SaveChangesAsync(); //salva los changos
            return Ok(student);
        }
    }
}
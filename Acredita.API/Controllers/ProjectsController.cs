using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext dataContext;
        public ProjectsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Project project)
        {
            dataContext.Projects.Add(project);
            await dataContext.SaveChangesAsync();
            return Ok(project);
        }
    }
}
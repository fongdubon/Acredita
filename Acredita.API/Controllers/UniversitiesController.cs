
using Acredita.API.Data;
using Acredita.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Acredita.API.Controllers
{
    [ApiController]
    [Route("/api/universities")]
    public class UniversitiesController : ControllerBase
    {
        private readonly DataContext dataContext;

        public UniversitiesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(dataContext.Universities.ToList());
        //}

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await dataContext.Universities.ToListAsync());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var country = await dataContext.Universities.FirstOrDefaultAsync(x => x.Id == id);
            if (country is null)
            {
                return NotFound();
            }

            return Ok(country);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(University university)
        {
            dataContext.Universities.Add(university);
            await dataContext.SaveChangesAsync();
            return Ok(university);
        }
        [HttpPut]
        public async Task<ActionResult> Put(University university)
        {
            dataContext.Universities.Update(university);
            await dataContext.SaveChangesAsync();
            return Ok(university);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await dataContext.Universities
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();
            if (afectedRows == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

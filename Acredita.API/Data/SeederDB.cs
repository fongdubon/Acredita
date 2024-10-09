using Acredita.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Acredita.API.Data
{
    public class SeederDB
    {
        private readonly DataContext dataContext;

        public SeederDB(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task SeedAsync()
        {
            await dataContext.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCitiesAsync();
            await CheckUniversitiesAsync();//Argenis
            await CheckMajorsAsync();//Sam
            await CheckContactsAsync();//Eduardo
            await CheckProjectsAsync();//Manuel
            await CheckLaboratoriesAsync();
            await CheckTeachersAsync();
            await CheckStudentsAsync();//Kevin
            await CheckClassroomsAsync();
            await CheckSubjectsAsync();//Diana

        }

        private async Task CheckCitiesAsync()
        {
            if(!dataContext.Cities.Any())
            {
                var country = await dataContext.Countries.FirstOrDefaultAsync(x=>x.Name== "México");
                if (country != null)
                {
                    dataContext.Cities.Add(new City { Name = "Puebla", Country = country });
                    dataContext.Cities.Add(new City { Name = "Cholula", Country = country });
                }
                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckCountriesAsync()
        {
            if (!dataContext.Countries.Any())
            {
                dataContext.Countries.Add(new Country { Name = "México" });
                dataContext.Countries.Add(new Country { Name = "Jamaica" });
                dataContext.Countries.Add(new Country { Name = "Canadá" });
                dataContext.Countries.Add(new Country { Name = "Brasil" });
                dataContext.Countries.Add(new Country { Name = "Perú" });
                await dataContext.SaveChangesAsync();
            }
        }
    }
}

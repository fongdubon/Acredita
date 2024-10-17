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
            await CheckMajorsAsync();//Sam
            await CheckSubjectsAsync();//Diana
            await CheckContactsAsync();//Eduardo
            await CheckProjectsAsync();//Manuel
            await CheckUniversitiesAsync();//Argenis
            await CheckStudentsAsync();//Kevin
            //await CheckLaboratoriesAsync();
            //await CheckTeachersAsync();
            //await CheckClassroomsAsync();
        }

        private async Task CheckSubjectsAsync()
        {
            if (!dataContext.Subjects.Any())
            {
                dataContext.Subjects.Add(new Subject { Name = "Programación", Credits = 8, Description = "Materia de ingenieria en sistemas", Hours = 4 });
                dataContext.Subjects.Add(new Subject { Name = "Sistemas de información", Credits = 6, Description = "Materia de ingenieria en sistemas", Hours = 4 });
                dataContext.Subjects.Add(new Subject { Name = "Álgebra", Credits = 8, Description = "Tronco común ingenierias", Hours = 4 });
                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckClassroomsAsync()
        {
            throw new NotImplementedException();
        }

        private async Task CheckStudentsAsync()
        {
            if (!dataContext.Students.Any())
            {
                dataContext.Students.Add(new Student { Enrollment = "1111", Phone = "2222222222", Email = "Jorge@gmail.com", FirstName = "Jorge", LastName = "Guzman", SurName = "Loera" });
                dataContext.Students.Add(new Student { Enrollment = "2222", Phone = "2256321478", Email = "Eduardo@gmail.com", FirstName = "Eduardo", LastName = "Gonzalez", SurName = "Sanchez" });
                dataContext.Students.Add(new Student { Enrollment = "3333", Phone = "2214532689", Email = "Sebastian@gmail.com", FirstName = "Sebastian", LastName = "Sanchez", SurName = "Rojas" });
                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckTeachersAsync()
        {
            throw new NotImplementedException();
        }

        private async Task CheckLaboratoriesAsync()
        {
            throw new NotImplementedException();
        }

        private async Task CheckProjectsAsync()
        {
            if (!dataContext.Projects.Any())
            {
                dataContext.Projects.Add(new Project { Name = "NASA", Description = "aterrizaje Apolo 13", Length = "2 meses", Active = true });
                dataContext.Projects.Add(new Project { Name = "Smart City", Description = "Semáforos para perros", Length = "3 meses", Active = true });
                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckContactsAsync()
        {
            if (!dataContext.Contacts.Any())
            {
                dataContext.Contacts.Add(new Contact { Name = "Juan", LastName = "Pérez", SurName = "Pérez", Email = "juanp@hotmail.com", PhoneNumber = "2221234567", Address = "Av #12", Active = true });
                dataContext.Contacts.Add(new Contact { Name = "Luis", LastName = "Sánchez", SurName = "Juárez", Email = "luiss@gmil.com", PhoneNumber = "2227654321", Address = "Av #27", Active = true });
                dataContext.Contacts.Add(new Contact { Name = "Rham", LastName = "DeRivia", SurName = "Monroe", Email = "rhamderiv@gmail.com", PhoneNumber = "2221726354", Address = "Av #77", Active = true });
                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckMajorsAsync()//sam
        {
            if (!dataContext.Majors.Any())
            {
                dataContext.Majors.Add(new Major { Name = "Ingeniería en Sistemas Computacionales", Duration = 8, Active = true });
                dataContext.Majors.Add(new Major { Name = "Licenciatura en derecho", Duration = 10, Active = true });
                dataContext.Majors.Add(new Major { Name = "Ingeniería en Química", Duration = 9, Active = true });
                dataContext.Majors.Add(new Major { Name = "Licenciatura en Mercadotecnia", Duration = 8, Active = true });

                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckUniversitiesAsync()//argenis
        {
            if (!dataContext.Universities.Any())
            {
                dataContext.Universities.Add(new University { Name = "Ibero", Url = "https://www.iberopuebla.mx", PhoneNumber = "2223723000", Address = "Colonia Reserva Territorial Atlixcáyotl", Active = true });
                dataContext.Universities.Add(new University { Name = "ITESM", Url = "https://tec.mx/es", PhoneNumber = "8183582000", Address = "Av. Eugenio Garza Sada 2501 Sur", Active = true });
                dataContext.Universities.Add(new University { Name = "UDLAP", Url = "https://www.udlap.mx/web/", PhoneNumber = "2222292000", Address = "Ex hacienda Sta. Catarina Mártir S/N. San Andrés Cholula", Active = true });
                dataContext.Universities.Add(new University { Name = "UNAM", Url = "https://www.unam.mx", PhoneNumber = "5556220000", Address = "Av. Universidad 3000, Col. Universidad Nacional Autónoma de México", Active = true });
                dataContext.Universities.Add(new University { Name = "Anáhuac", Url = "https://www.anahuac.mx", PhoneNumber = "2221691069", Address = "Calle Orión Norte s/n Col. La vista Country Club", Active = true });
                await dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckCitiesAsync()
        {
            if (!dataContext.Cities.Any())
            {
                var country = await dataContext.Countries.FirstOrDefaultAsync(x => x.Name == "México");
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

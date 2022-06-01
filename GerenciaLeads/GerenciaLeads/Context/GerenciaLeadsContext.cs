using GerenciaLeads.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciaLeads.Api.Context
{
    public class GerenciaLeadsContext : DbContext
    {
        public GerenciaLeadsContext(DbContextOptions<GerenciaLeadsContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contact { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 5577421,
                    FullName = "Bill Test",
                    DateCreated = DateTime.Now,
                    Suburb = "Yanderra 2574",
                    Category = "Painters",
                    Description = "Need to paint 2 aluminum windows and a sliding glass door",
                    Price = 62,
                    PhoneNumber = "1198765423456",
                    EmailAddress = "bill@test.com",
                    Accepted = "N"
                },
                new Contact
                {
                    Id = 5588872,
                    FullName = "Craig Test",
                    DateCreated = DateTime.Now,
                    Suburb = "Woolooware 2230",
                    Category = "Interior Painters",
                    Description = "internal walls 3 colours",
                    Price = 49,
                    PhoneNumber = "1198765423451",
                    EmailAddress = "craig@test.com",
                    Accepted = "N"
                },
                new Contact
                {
                    Id = 5141895,
                    FullName = "Pete",
                    DateCreated = DateTime.Now,
                    Suburb = "Carramar 6031",
                    Category = "General Building Work",
                    Description = "Plaster exposed...",
                    Price = 26,
                    PhoneNumber = "0412345678",
                    EmailAddress = "fake@mailinator.com",
                    Accepted = "Y"
                },
                new Contact
                {
                    Id = 5121931,
                    FullName = "Craig Test",
                    DateCreated = DateTime.Now,
                    Suburb = "Quinns Rock 6030",
                    Category = "Home Renovations",
                    Description = "There is a two ...",
                    Price = 32,
                    PhoneNumber = "04987654321",
                    EmailAddress = "another.fake@hipmail.com",
                    Accepted = "Y"
                }
                );
        }
    }
}

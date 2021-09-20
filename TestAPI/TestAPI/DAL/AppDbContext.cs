using System;
using Microsoft.EntityFrameworkCore;
using TestAPI.DAL.Entities;

namespace TestAPI.DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}

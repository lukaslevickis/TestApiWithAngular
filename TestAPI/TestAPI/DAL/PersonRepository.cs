using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestAPI.DAL.Entities;

namespace TestAPI.DAL
{
    public class PersonRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<List<Person>> GetAllAsync()
        {
            return await _context.Persons.ToListAsync();
        }

        public virtual async Task InsertAsync(Person entity)
        {
            await _context.Persons.AddAsync(entity);
        }

        public virtual async Task<Person> FindAsync(object id)
        {
            return await _context.Persons.FindAsync(id);
        }
    }
}

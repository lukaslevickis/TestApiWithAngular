using System;
using System.Threading.Tasks;

namespace TestAPI.DAL
{
    public class Unit
    {
        private readonly AppDbContext _context;
        private PersonRepository _personRepository;

        public Unit(AppDbContext context)
        {
            _context = context;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public PersonRepository PersonRepository
        {
            get
            {
                if (this._personRepository == null)
                {
                    this._personRepository = new PersonRepository(_context);
                }

                return _personRepository;
            }
        }
    }
}

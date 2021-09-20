using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestAPI.DAL;
using TestAPI.DAL.Entities;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class PersonController: ControllerBase
    {
        private Unit _unit;

        public PersonController(Unit unit)
        {
            _unit = unit;
        }

        // GET: api/Persons
        [HttpGet]
        public async Task<ActionResult<List<Person>>> Get()
        {
            return await _unit.PersonRepository.GetAllAsync();
        }

        // POST: api/Person
        [HttpPost] 
        [Route("~/api/Person")]
        public async Task<ActionResult<Person>> PostPerson([FromBody] Person item)
        {
            await _unit.PersonRepository.InsertAsync(item);
            await _unit.SaveAsync();

            return Redirect("/api");
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            var todoItem = await _unit.PersonRepository.FindAsync(id);

            if (todoItem == null)
            {
                throw new ArgumentNullException("not found");
            }

            return todoItem;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeritabaniProjesii.Models; // Eğer Person modelini farklı bir isim alanında tanımladıysanız düzenlemeler yapın.
using VeritabaniProjesi.Data;

namespace VeritabaniProjesi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
        {
            var people = await _context.People.ToListAsync();
            return Ok(people);
        }

        [HttpPost]
        public async Task<IActionResult> PostPerson(Person person)
        {
            _context.People.Add(person);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

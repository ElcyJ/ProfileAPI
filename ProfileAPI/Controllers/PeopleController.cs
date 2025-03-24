using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProfileAPI.Context;
using ProfileAPI.Entity;

namespace ProfileAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly AppDbContext _context;

    public PeopleController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
    {
        return await _context.People.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Person>> GetPerson(int id)
    {
        var person = await _context.People.FindAsync(id);

        if (person == null)
        {
            return NotFound();
        }

        return person;
    }

    [HttpPost]
    public async Task<ActionResult<Person>> PostPerson(Person person)
    {
        _context.People.Add(person);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPerson), new { id = person.Id }, person);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutPerson(int id, Person person)
    {
        if (id != person.Id)
        {
            return BadRequest();
        }

        _context.Entry(person).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.People.Any(e => e.Id == id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
            
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(int id)
    {
        var person = await _context.People.FindAsync(id);
        if (person == null)
        {
            return NotFound();
        }

        _context.People.Remove(person);
        await _context.SaveChangesAsync();

        return NoContent();
    }   
}

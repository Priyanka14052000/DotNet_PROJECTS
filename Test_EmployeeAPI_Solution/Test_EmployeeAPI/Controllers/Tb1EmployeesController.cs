using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_EmployeeAPI;
using Microsoft.AspNetCore.Cors;


namespace Test_EmployeeAPI.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class Tb1EmployeesController : ControllerBase
    {
        private readonly test_employeeContext _context;

        public Tb1EmployeesController(test_employeeContext context)
        {
            _context = context;
        }

        // GET: api/Tb1Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tb1Employee>>> GetTb1Employees()
        {
          if (_context.Tb1Employees == null)
          {
              return NotFound();
          }
            return await _context.Tb1Employees.ToListAsync();
        }

        // GET: api/Tb1Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tb1Employee>> GetTb1Employee(int id)
        {
          if (_context.Tb1Employees == null)
          {
              return NotFound();
          }
            var tb1Employee = await _context.Tb1Employees.FindAsync(id);

            if (tb1Employee == null)
            {
                return NotFound();
            }

            return tb1Employee;
        }

        // PUT: api/Tb1Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTb1Employee(int id, Tb1Employee tb1Employee)
        {
            if (id != tb1Employee.Id)
            {
                return BadRequest();
            }

            _context.Entry(tb1Employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tb1EmployeeExists(id))
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

        // POST: api/Tb1Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tb1Employee>> PostTb1Employee(Tb1Employee tb1Employee)
        {
          if (_context.Tb1Employees == null)
          {
              return Problem("Entity set 'test_employeeContext.Tb1Employees'  is null.");
          }
            _context.Tb1Employees.Add(tb1Employee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Tb1EmployeeExists(tb1Employee.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTb1Employee", new { id = tb1Employee.Id }, tb1Employee);
        }

        // DELETE: api/Tb1Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTb1Employee(int id)
        {
            if (_context.Tb1Employees == null)
            {
                return NotFound();
            }
            var tb1Employee = await _context.Tb1Employees.FindAsync(id);
            if (tb1Employee == null)
            {
                return NotFound();
            }

            _context.Tb1Employees.Remove(tb1Employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Tb1EmployeeExists(int id)
        {
            return (_context.Tb1Employees?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_new_app.Data;
using my_new_app.Models;

namespace my_new_app.Controllers
{
    [Route("api/spendings")]
    public class SpendingController : Controller
    {
        private readonly ApplicationDbContext db;

        public SpendingController(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(string search = null)
        {
             var list =await db.Spendings.ToListAsync();
            return Ok(list);
        }
          [HttpGet("{id}")]
          public async Task<IActionResult> GetSpending(int id)
        { 
            var query1 = await db.Spendings.FindAsync(id);
            if(query1 != null)
            {
                return Ok(query1);
            }
            return NotFound();
        }
        // [HttpGet]
        // public async Task<IActionResult> GetMoney(string search = null)
        // {
        //     var query = db.Spendings.AsQueryable();
        //     if (!string.IsNullOrWhiteSpace(search))
        //     {
        //         query = query.Where(item => item.Purpose.Contains(search));
        //     }
        //     var list = await query.ToListAsync();
        //     return Ok(list);
        // }
        
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Spending model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Dữ liệu sai");
            }

            db.Spendings.Add(model);
            await db.SaveChangesAsync();

            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Spending model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Dữ liệu sai");
            }

            var found = await db.Spendings.FindAsync(id);
            if (found != null)
            {
                found.Purpose = model.Purpose;
                found.Money =model.Money;
                await db.SaveChangesAsync();

                return Ok(found);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delette(int id)
        {
            var found = await db.Spendings.FindAsync(id);
            if (found != null)
            {
                db.Spendings.Remove(found);
                await db.SaveChangesAsync();

                return Ok(new { success = true });
            }

            return NotFound();
        }
    }
}
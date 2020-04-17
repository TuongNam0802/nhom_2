using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_new_app.Data;
using my_new_app.Models;

namespace my_new_app
{
    [Route("api/banks")]
    public class BankController :Controller
    {
        private readonly ApplicationDbContext db;
        public BankController(ApplicationDbContext dbContext)
        {
            this.db=dbContext;
        }
          [HttpGet]
        public async Task<IActionResult> GetAll()
        { 
            var list =await db.Banks.ToListAsync();
            return Ok(list);
        }
          [HttpGet("{id}")]
          public async Task<IActionResult> GetBankItem(int id)
        { 
            var query1 = await db.Spending_Details.FirstOrDefaultAsync(m => m.Id == id);
            if(query1 != null)
            {
                // query1 = query1.Bank;
               var  query2 = await db.Banks.FirstAsync(m => m.Id == id);
                return Ok(query2);
            }
            return NotFound();
        }
         [HttpPost]
        public async Task<IActionResult> Create([FromBody] Bank model)
        {
            if (!ModelState.IsValid)// bắt lỗi string
            {
                return BadRequest("Dữ liệu không chuẩn");
            }
            db.Banks.Add(model);
            await db.SaveChangesAsync();

            return Ok(model);
        }
          [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Bank model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Dữ liệu không chuẩn");
            }

            var found = await db.Banks.FindAsync(id);
            if (found != null)
            {
                found.BankName = model.BankName;
                found.RedMoney = model.RedMoney;
                await db.SaveChangesAsync();

                return Ok(found);
            }

            return NotFound();
        }
         [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var found = await db.Banks.FindAsync(id);
            if (found != null)
            {
                db.Banks.Remove(found);
                await db.SaveChangesAsync();

                return Ok(new { success = true });
            }

            return NotFound();
        }
         
    }
}
        
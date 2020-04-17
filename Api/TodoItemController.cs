using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_new_app.Data;
using my_new_app.Models;

namespace my_new_app
{
    [Route("api/todo-items")]
    public class TodoItemController :Controller
    {
        private readonly ApplicationDbContext db;
        public TodoItemController(ApplicationDbContext dbContext)
        {
            this.db=dbContext;
        }
          [HttpGet]
        public async Task<IActionResult> GetAll()
        { 
            var list =await db.TodoItems.ToListAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
          public async Task<IActionResult> GetToItem(int id)
        { 
            var query1 = await db.TodoItems.FirstOrDefaultAsync(m => m.Id==id );
            if(query1 != null)
            {
                return Ok(query1);
            }
            return NotFound();
        }
        
         [HttpPost]
        public async Task<IActionResult> Create([FromBody] TodoItem model)
        {
            if (!ModelState.IsValid)// bắt lỗi string
            {
                return BadRequest("Dữ liệu không chuẩn");
            }
            model.CreatedTime = DateTime.Now;
            db.TodoItems.Add(model);
            await db.SaveChangesAsync();

            return Ok(model);
        }
          [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TodoItem model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Dữ liệu không chuẩn");
            }

            var found = await db.TodoItems.FindAsync(id);
            if (found != null)
            {
                found.Title = model.Title;
                found.Checked = model.Checked;
                await db.SaveChangesAsync();

                return Ok(found);
            }

            return NotFound();
        }
            [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var found = await db.TodoItems.FindAsync(id);
            if (found != null)
            {
                db.TodoItems.Remove(found);
                await db.SaveChangesAsync();

                return Ok(new { success = true });
            }

            return NotFound();
        }
    }
}
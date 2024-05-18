using ApplicationCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            //_context.TodoItems.Add(todoItem);
            //await _context.SaveChangesAsync();

            //    return CreatedAtAction("PostTodoItem", new { id = todoItem.Id }, todoItem);
            return NoContent(); //new User{Id=1, Ativo= false, Email="user1@email.com", Name="User1"};//CreatedAtAction(nameof(PostTodoItem), new { id = todoItem.Id }, todoItem);
        }

        [HttpGet]
        public async Task<ActionResult<User>> Get()
        {
            return new User { Name = "Walter" };
        }
    }
}

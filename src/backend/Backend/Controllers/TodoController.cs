using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    [Route("api/todo")] // /api/todo
    public class TodoController : ControllerBase
    {
        private readonly CollectionContext _context;

        public TodoController(CollectionContext context)
        {
            _context = context;
        }

        [HttpGet] // /api/todo
        public List<TodoItem> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        [Route("{id}")] // /api/todo/1
        [HttpGet]
        public ActionResult GetById(long id)
        {
            var item = _context.TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")] // /api/todo/1 + body
        public IActionResult Update(long id, TodoItem item)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.Name =item.Name;

            _context.TodoItems.Update(todo);
            _context.SaveChanges();
            return NoContent();

        }

        [HttpPost] // /api/todo + body
        public IActionResult Post([FromBody] TodoItem todo)
        {
            _context.TodoItems.Add(todo);
            _context.SaveChanges();
            return Created("", todo);
        }

        [HttpDelete("{id}")] // /api/todo/1
        public IActionResult Delete(long id)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
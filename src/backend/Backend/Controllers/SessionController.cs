using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    [Route("api/session")] // /api/session
    public class SessionController : ControllerBase
    {
        private readonly ARealmContext _context;

        public SessionController(ARealmContext context)
        {
            _context = context;
        }

        [HttpGet] // /api/session
        public List<Session> GetAll()
        {
            return _context.Sessions.ToList();
        }

        [Route("{id}")] // /api/session/1
        [HttpGet]
        public ActionResult GetById(long id)
        {
            var item = _context.Sessions.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")] // /api/session/1 + body
        public IActionResult Update(long id, Session item)
        {
            var session = _context.Sessions.Find(id);
            if (session == null)
            {
                return NotFound();
            }

            session.SessionCode = item.SessionCode;
            //todo

            _context.Sessions.Update(session);
            _context.SaveChanges();
            return NoContent();

        }

        [HttpPost] // /api/session + body
        public IActionResult Post([FromBody] Session session)
        {
            _context.Sessions.Add(session);
            _context.SaveChanges();
            return Created("", session);
        }

        [HttpDelete("{id}")] // /api/session/1
        public IActionResult Delete(long id)
        {
            var session = _context.Sessions.Find(id);
            if (session == null)
            {
                return NotFound();
            }

            _context.Sessions.Remove(session);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
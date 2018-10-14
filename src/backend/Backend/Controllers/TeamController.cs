using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    [Route("api/team")] // /api/team
    public class TeamController : ControllerBase
    {
        private readonly ARealmContext _context;

        public TeamController(ARealmContext context)
        {
            _context = context;
        }

        [HttpGet] // /api/team
        public List<Team> GetAll()
        {
            return _context.Teams.ToList();
        }

        [Route("{id}")] // /api/team/1
        [HttpGet]
        public ActionResult GetById(long id)
        {
            var item = _context.Teams.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")] // /api/team/1 + body
        public IActionResult Update(long id, Team item)
        {
            var team = _context.Teams.Find(id);
            if (team == null)
            {
                return NotFound();
            }

            team.Name =item.Name;
            //todo

            _context.Teams.Update(team);
            _context.SaveChanges();
            return NoContent();

        }

        [HttpPost] // /api/team + body
        public IActionResult Post([FromBody] Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
            return Created("", team);
        }

        [HttpDelete("{id}")] // /api/team/1
        public IActionResult Delete(long id)
        {
            var team = _context.Teams.Find(id);
            if (team == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(team);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
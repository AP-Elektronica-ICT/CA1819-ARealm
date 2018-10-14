using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;
using Services;

namespace Controllers
{
    [Route("api/team")] // /api/team
    public class TeamController : ControllerBase
    {
        private readonly ARealmContext _context;
        private TeamService _teamService;
        
        public TeamController(ARealmContext context)
        {
            _context = context;
            _teamService = new TeamService(_context);
        }

        [HttpGet] // /api/team
        public List<Team> GetAll()
        {
            //return _context.Teams.ToList();
            return _context.Teams.Include(d => d.Session).ToList();
        }

        [Route("{id}")] // /api/team/1
        [HttpGet]
        public ActionResult GetById(long id)
        {
            var item = _context.Teams.Include( d=> d.Session)
                                        .SingleOrDefault(d=> d.Id == id);
            //var item = _context.Teams.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // om een sessie bij een team aan te sluiten:
        // PUT reqest doen met de juiste sessiecode als team.sessioncode property.
        [HttpPut("{id}")] // /api/team/1 + body
        public IActionResult Update(long id, [FromBody] Team item)
        {
            var team = _context.Teams.Find(id);
            if (team == null)
            {
                return NotFound();
            }

            team.Name =item.Name;
            team.SessionCode = item.SessionCode;
            
            return _teamService.CheckSessionCode(team,this);
                        
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
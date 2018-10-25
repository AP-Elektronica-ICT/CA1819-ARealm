using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    //API endpoints
    [Route("api/team")]
    public class TeamController : Controller
    {
        private TeamService _service;

        public TeamController(TeamService service)
        {
            _service = service;
        }

        [HttpGet] // GET api/team
        public IEnumerable<Team> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")] // GET api/team/5
        public Team Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public Team Put([FromBody]Team team)
        {
            return _service.Update(team);
        }

        [HttpPost]
        public Team Post([FromBody]Team team)
        {
            return _service.Create(team);
        }

        [HttpDelete("{id}")]
        public bool Delete(long id)
        {
            return _service.Delete(id);
        }

    }
}

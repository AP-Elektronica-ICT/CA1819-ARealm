using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace WebAPI
{
    //API endpoints
    [Route("api/session")]
    public class SessionController : Controller
    {
        private SessionService _sessionService;
        private TeamService _teamService;
        private DistrictService _districtService;

        public SessionController(SessionService sessionService, TeamService teamService, DistrictService districtService)
        {
            _sessionService = sessionService;
            _teamService = teamService;
            _districtService = districtService;
        }

        [HttpGet] // GET api/session
        public IEnumerable<Session> Get()
        {
            return _sessionService.GetAll();
        }

        [HttpGet("{id}")] // GET api/session/5
        public Session Get(long id)
        {
            return _sessionService.Get(id);
        }

        [Route("{id}/teams")] // POST api/session/3/teams team aanmaken in bepaalde sessie
        [HttpPost]
        public bool AddTeamToSession([FromBody]Team team,long id)
        {
            return _teamService.Create(team, id);
        }

        [HttpDelete("{id}")]
        public bool Delete(long id)
        {
            return _sessionService.Delete(id);
        }


    }
}

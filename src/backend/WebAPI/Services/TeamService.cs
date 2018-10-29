using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Repositories;

namespace Services
{
    //logic
    public class TeamService
    {
        private TeamRepository _repository;
        private SessionService _sessionService;
        public int maxTeams; // change name?

        public TeamService(TeamRepository repository, SessionService service)
        {
            _repository = repository;
            _sessionService = service;
            maxTeams = 4;
        }

        public bool Create(Team team, long id)
        {
            var added = AddTeamToSession(team, id);
            if (added)
            {
                _repository.Post(team);
            }         
            return added;
        }

        public Team Update(Team team)
        {
            return _repository.Put(team);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public List<Team> GetAll()
        {

            return _repository.GetAll();
        }

        public Team Get(long id)
        {
            return _repository.Get(id);
        }

        public bool AddTeamToSession(Team team, long id)
        {
            var session = _sessionService.Get(id);
            var count = session.Teams.Count;
            if(count < maxTeams)
            {
                if (team.SessionCode == session.SessionCode.Code) // compare session codes
                {
                    team.Session = session; // add team to session
                    return true;
                }
            }
            return false;

        }
    }
}

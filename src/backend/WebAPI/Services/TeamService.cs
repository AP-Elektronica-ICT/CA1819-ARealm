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
        public int maxTeamsPerSession; // change name?
        public int teamCount;

        public TeamService(TeamRepository repository, SessionService service)
        {
            _repository = repository;
            _sessionService = service;
            maxTeamsPerSession = 4;
        }

        public Team Create(Team team)
        {
            AddTeamToSession(team);
            return _repository.Post(team);
        }

        public Team Update(Team team)
        {
            //TODO new item gets created?
            AddTeamToSession(team);
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

        public bool AddTeamToSession(Team team)
        {
            teamCount = 0;
            List<Session> sessions = _sessionService.GetAll();
            List<Team> teams = GetAll();

            foreach (Session session in sessions)
            {
                if (session.SessionCode == team.SessionCode)
                {
                    foreach (Team t in teams)
                    {
                        if (t.SessionCode == session.SessionCode) // count teams with same session code
                        {                                         // todo session.Teams.Count => Teams gives null  
                            teamCount++;
                        }
                    }
                    if (teamCount < maxTeamsPerSession)// check if session is full
                    {
                        team.Session = session; // add session to team
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

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

        public TeamService(TeamRepository repository)
        {
            _repository = repository;
        }

        public Team Create(Team team)
        {
            return _repository.Post(team);
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
    }
}

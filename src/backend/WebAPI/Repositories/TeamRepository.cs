using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repositories
{
    //DB calls
    public class TeamRepository
    {
        private ARealmContext _context;

        public TeamRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<Team> GetAll()
        {
            try
            {
                return _context.Teams.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Team Get(long id)
        {
            try
            {
                return _context.Teams.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Team Put(Team team)
        {
            try
            {
                _context.Teams.Update(team);
                _context.SaveChanges();
                return team;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Team Post(Team team)
        {
            try
            {
                _context.Teams.Add(team);
                _context.SaveChanges();
                return team;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool Delete(long id)
        {
            try
            {
                var team = _context.Teams.Find(id);
                if (team == null)
                {
                    return false;
                }

                _context.Teams.Remove(team);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

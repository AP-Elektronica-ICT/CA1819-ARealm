using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Repositories;

namespace Repositories
{
    //DB calls
    public class SessionRepository
    {
        private ARealmContext _context;

        public SessionRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<Session> GetAll()
        {
            try
            {
                return _context.Sessions.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Session Get(long id)
        {
            try
            {
                return _context.Sessions.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Session Put(Session session)
        {
            try
            {
                _context.Sessions.Update(session);
                _context.SaveChanges();
                return session;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Session Post(Session session)
        {
            try
            {
                _context.Sessions.Add(session);
                _context.SaveChanges();
                return session;
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
                var session = _context.Sessions.Find(id);
                if (session == null)
                {
                    return false;
                }

                _context.Sessions.Remove(session);
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

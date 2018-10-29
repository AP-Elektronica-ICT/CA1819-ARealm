using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Repositories
{
    public class SessionCodeRepository
    {
        private ARealmContext _context;

        public SessionCodeRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<SessionCode> GetAll()
        {
            try
            {
                return _context.SessionCodes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public SessionCode Get(long id)
        {
            try
            {
                return _context.SessionCodes.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public SessionCode Put(SessionCode code)
        {
            try
            {
                _context.SessionCodes.Update(code);
                _context.SaveChanges();
                return code;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SessionCode Post(SessionCode code)
        {
            try
            {
                _context.SessionCodes.Add(code);
                _context.SaveChanges();
                return code;
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
                var code = _context.SessionCodes.Find(id);
                if (code == null)
                {
                    return false;
                }

                _context.SessionCodes.Remove(code);
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

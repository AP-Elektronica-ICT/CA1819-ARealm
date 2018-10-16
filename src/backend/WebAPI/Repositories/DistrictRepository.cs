using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Repositories
{
    //DB calls
    public class DistrictRepository
    {
        private ARealmContext _context;

        public DistrictRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<District> GetAll()
        {
            try
            {
                return _context.Districts.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public District Get(long id)
        {
            try
            {
                return _context.Districts.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public District Put(District district)
        {
            try
            {
                _context.Districts.Update(district);
                _context.SaveChanges();
                return district;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public District Post(District district)
        {
            try
            {
                _context.Districts.Add(district);
                _context.SaveChanges();
                return district;
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
                var district = _context.Districts.Find(id);
                if (district == null)
                {
                    return false;
                }

                _context.Districts.Remove(district);
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

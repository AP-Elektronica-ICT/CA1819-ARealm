using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class LockedDistrictsRepository
    {
        private ARealmContext _context;

        public LockedDistrictsRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<LockedDistricts> Get()
        {
            try
            {
                return _context.LockedDistricts.Include(d => d.Districts).ThenInclude(d => d.Task).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
    }

}

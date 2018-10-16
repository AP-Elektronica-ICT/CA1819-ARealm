using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    //DB calls
    public class LocationTaskRepository
    {
        private ARealmContext _context;

        public LocationTaskRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<LocationTask> GetAll()
        {
            try
            {
                return _context.LocationTasks.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public LocationTask Get(long id)
        {
            try
            {
                return _context.LocationTasks.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public LocationTask Put(LocationTask task)
        {
            try
            {
                _context.LocationTasks.Update(task);
                _context.SaveChanges();
                return task;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LocationTask Post(LocationTask task)
        {
            try
            {
                _context.LocationTasks.Add(task);
                _context.SaveChanges();
                return task;
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
                var task = _context.LocationTasks.Find(id);
                if (task == null)
                {
                    return false;
                }

                _context.LocationTasks.Remove(task);
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

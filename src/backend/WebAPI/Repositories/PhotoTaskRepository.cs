using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    //DB calls
    public class PhotoTaskRepository
    {
        private ARealmContext _context;

        public PhotoTaskRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<PhotoTask> GetAll()
        {
            try
            {
                return _context.PhotoTasks.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public PhotoTask Get(long id)
        {
            try
            {
                return _context.PhotoTasks.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public PhotoTask Put(PhotoTask task)
        {
            try
            {
                _context.PhotoTasks.Update(task);
                _context.SaveChanges();
                return task;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PhotoTask Post(PhotoTask task)
        {
            try
            {
                _context.PhotoTasks.Add(task);
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
                var task = _context.PhotoTasks.Find(id);
                if (task == null)
                {
                    return false;
                }

                _context.PhotoTasks.Remove(task);
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

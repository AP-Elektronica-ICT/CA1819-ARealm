using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    //DB calls
    public class PuzzleTaskRepository
    {
        private ARealmContext _context;

        public PuzzleTaskRepository(ARealmContext context)
        {
            _context = context;
        }

        public List<PuzzleTask> GetAll()
        {
            try
            {
                return _context.PuzzleTasks.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public PuzzleTask Get(long id)
        {
            try
            {
                return _context.PuzzleTasks.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public PuzzleTask Put(PuzzleTask task)
        {
            try
            {
                _context.PuzzleTasks.Update(task);
                _context.SaveChanges();
                return task;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PuzzleTask Post(PuzzleTask task)
        {
            try
            {
                _context.PuzzleTasks.Add(task);
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
                var task = _context.PuzzleTasks.Find(id);
                if (task == null)
                {
                    return false;
                }

                _context.PuzzleTasks.Remove(task);
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

using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Repositories;

namespace Services
{
    //logic
    public class PuzzleTaskService
    {
        private PuzzleTaskRepository _repository;

        public PuzzleTaskService(PuzzleTaskRepository repository)
        {
            _repository = repository;
        }

        public PuzzleTask Create(PuzzleTask task)
        {
            return _repository.Post(task);
        }

        public PuzzleTask Update(PuzzleTask task)
        {
            return _repository.Put(task);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public List<PuzzleTask> GetAll()
        {

            return _repository.GetAll();
        }

        public PuzzleTask Get(long id)
        {
            return _repository.Get(id);
        }
    }
}

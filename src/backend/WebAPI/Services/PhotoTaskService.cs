using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Repositories;

namespace Services
{
    //logic
    public class PhotoTaskService
    {
        private PhotoTaskRepository _repository;

        public PhotoTaskService(PhotoTaskRepository repository)
        {
            _repository = repository;
        }

        public PhotoTask Create(PhotoTask task)
        {
            return _repository.Post(task);
        }

        public PhotoTask Update(PhotoTask task)
        {
            return _repository.Put(task);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public List<PhotoTask> GetAll()
        {

            return _repository.GetAll();
        }

        public PhotoTask Get(long id)
        {
            return _repository.Get(id);
        }
    }
}

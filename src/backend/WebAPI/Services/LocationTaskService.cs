using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Repositories;

namespace Services
{
    //logic
    public class LocationTaskService
    {
        private LocationTaskRepository _repository;

        public LocationTaskService(LocationTaskRepository repository)
        {
            _repository = repository;
        }

        public LocationTask Create(LocationTask task)
        {
            return _repository.Post(task);
        }

        public LocationTask Update(LocationTask task)
        {
            return _repository.Put(task);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public List<LocationTask> GetAll()
        {

            return _repository.GetAll();
        }

        public LocationTask Get(long id)
        {
            return _repository.Get(id);
        }
    }
}

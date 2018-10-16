using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Repositories;

namespace Services
{
    //logic
    public class DistrictService
    {
        private DistrictRepository _repository;

        public DistrictService(DistrictRepository repository)
        {
            _repository = repository;
        }

        public District Create(District district)
        {
            return _repository.Post(district);
        }

        public District Update(District district)
        {
            return _repository.Put(district);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public List<District> GetAll()
        {

            return _repository.GetAll();
        }

        public District Get(long id)
        {
            return _repository.Get(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Repositories;
using Models;

namespace Services
{
    //logic
    public class SessionService
    {
        private SessionRepository _repository;

        public SessionService(SessionRepository repository)
        {
            _repository = repository;
        }

        public Session Create(Session session)
        {
            return _repository.Post(session);
        }

        public Session Update(Session session)
        {
            return _repository.Put(session);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public List<Session> GetAll()
        {

            return _repository.GetAll();
        }

        public Session Get(long id)
        {
            return _repository.Get(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace WebAPI
{
    //API endpoints
    [Route("api/session")]
    public class SessionController : ControllerBase
    {
        private SessionService _service;

        public SessionController(SessionService service)
        {
            _service = service;
        }

        [HttpGet] // GET api/session
        public IEnumerable<Session> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")] // GET api/session/5
        public Session Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public Session Put([FromBody]Session session)
        {
            return _service.Update(session);
        }

        [HttpPost]
        public Session Post([FromBody]Session session)
        {
            return _service.Create(session);
        }

        [HttpDelete("{id}")]
        public bool Delete(long id)
        {
            return _service.Delete(id);
        }


    }
}

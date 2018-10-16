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
    [Route("api/location")]
    public class LocationTaskController : ControllerBase
    {
        private LocationTaskService _service;

        public LocationTaskController(LocationTaskService service)
        {
            _service = service;
        }

        [HttpGet] // GET api/location
        public IEnumerable<LocationTask> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")] // GET api/location/5
        public LocationTask Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public LocationTask Put([FromBody]LocationTask task)
        {
            return _service.Update(task);
        }

        [HttpPost]
        public LocationTask Post([FromBody]LocationTask task)
        {
            return _service.Create(task);
        }

        [HttpDelete("{id}")]
        public bool Delete(long id)
        {
            return _service.Delete(id);
        }
    }
}

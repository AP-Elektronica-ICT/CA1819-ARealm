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
    public class PhotoTaskController : Controller
    {
        private PhotoTaskService _service;

        public PhotoTaskController(PhotoTaskService service)
        {
            _service = service;
        }

        [HttpGet] // GET api/photo
        public IEnumerable<PhotoTask> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")] // GET api/photo/5
        public PhotoTask Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public PhotoTask Put([FromBody]PhotoTask task)
        {
            return _service.Update(task);
        }

        [HttpPost]
        public PhotoTask Post([FromBody]PhotoTask task)
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

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
    [Route("api/district")]
    public class DistrictController : ControllerBase
    {
        private DistrictService _service;

        public DistrictController(DistrictService service)
        {
            _service = service;
        }

        [HttpGet] // GET api/district
        public IEnumerable<District> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")] // GET api/district/5
        public District Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public District Put([FromBody]District district)
        {
            return _service.Update(district);
        }

        [HttpPost]
        public District Post([FromBody]District district)
        {
            return _service.Create(district);
        }

        [HttpDelete("{id}")]
        public bool Delete(long id)
        {
            return _service.Delete(id);
        }
    }
}

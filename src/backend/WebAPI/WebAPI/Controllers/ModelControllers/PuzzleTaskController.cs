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
    [Route("api/puzzle")]
    public class PuzzleTaskController : Controller
    {
        private PuzzleTaskService _service;

        public PuzzleTaskController(PuzzleTaskService service)
        {
            _service = service;
        }

        [HttpGet] // GET api/puzzle
        public IEnumerable<PuzzleTask> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")] // GET api/puzzle/5
        public PuzzleTask Get(long id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public PuzzleTask Put([FromBody]PuzzleTask task)
        {
            return _service.Update(task);
        }

        [HttpPost]
        public PuzzleTask Post([FromBody]PuzzleTask task)
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

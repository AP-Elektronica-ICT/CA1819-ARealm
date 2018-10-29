using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services;

namespace WebAPI.Controllers
{
    //API endpoints
    [Route("api/code")]
    public class SessionCodeController : Controller
    {
        private SessionCodeService _service;

        public SessionCodeController(SessionCodeService service)
        {
            _service = service;
        }

        [HttpGet] // GET api/code
        public SessionCode Get()
        {
            return _service.Create(); // creates new session with code
        }



    }
}

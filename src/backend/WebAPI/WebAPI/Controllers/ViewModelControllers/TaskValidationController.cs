using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Services;
using ViewModels;

namespace WebAPI
{
    //API endpoint
    [Produces("application/json")]
    [Route("api/taskvalidation")]
    public class TaskValidationController : Controller
    {
        private PuzzleTaskService _puzzleTaskService;
        private PhotoTaskService _photoTaskService;
        private LocationTaskService _locationTaskService;

        [HttpPut()]
        public TaskValidationViewModel PutForValidation([FromBody] PuzzleTask puzzleTask)
        {
            return _puzzleTaskService.CheckIfTrue(puzzleTask);
        }



    }
}

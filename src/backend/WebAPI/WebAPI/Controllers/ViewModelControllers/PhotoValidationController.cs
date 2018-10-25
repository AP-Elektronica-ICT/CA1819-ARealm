using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;
using Services;

namespace WebAPI.Controllers.ViewModelControllers
{
    [Route("api/validatephoto")]
    public class PhotoValidationController : Controller
    {
        private PhotoValidationService _photoValidationService;

        public PhotoValidationController(PhotoValidationService photoValidationService)
        {
            _photoValidationService = photoValidationService;
        }

        [HttpPost()]
        public TaskValidationViewModel  PutForValidation([FromBody] PhotoViewModel photo)
        {
            return _photoValidationService.Validate(photo);
        }



    }
}

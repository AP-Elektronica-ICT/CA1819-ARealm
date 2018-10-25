using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
namespace Services
{
    public class PhotoValidationService
    {
        public PhotoValidationService()
        {

        }
        public TaskValidationViewModel Validate(PhotoViewModel photo)
        {
            // todo photo validation
            return new TaskValidationViewModel()
            {
                IsCorrect = true
            };
        }
    }
}

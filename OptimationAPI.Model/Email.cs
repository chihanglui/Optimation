using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OptimationAPI.ViewModel {
    public class Email : ModelBase{
        [Required]
        public string Content { get; set; }

    }



}

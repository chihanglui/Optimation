using System;
using System.Collections.Generic;
using System.Text;

namespace OptimationAPI.Domain.Model {
    public class Validation {
        public Error Error { get; set; }

        public enum ValidationTypeEnum {
            Info,
            Error
        }

        public Validation(ValidationTypeEnum validationType, string target, string message) {
            Error = new Error(validationType, target, message);
        }



    }

    public class Error {
        public Error(Validation.ValidationTypeEnum validationType, string target, string message) {
            ValidationType = validationType.ToString();
            Target = target;
            Message = message;
        }
        
        public string ValidationType { get; set; }
        public string Target { get; set; }

        public string Message { get; set; }

    }
}

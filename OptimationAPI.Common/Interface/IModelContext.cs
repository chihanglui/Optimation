using System;
using System.Collections.Generic;
using System.Text;

namespace OptimationAPI.Common.Interface {
    public interface IModelContext {
        List<IModelValidation> Validations { get; set; }

        bool IsValid();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OptimationAPI.Domain.Model
{
    public interface IContext {
        bool IsValid();
        List<Validation> Validations { get; set; }

    }
}

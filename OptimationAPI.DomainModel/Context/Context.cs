using System;
using System.Collections.Generic;
using System.Text;

namespace OptimationAPI.Domain.Model {
    public abstract class Context : IContext {
        public Context() {
            Validations = new List<Validation>();
        }
        public List<Validation> Validations { get; set ; }

        public abstract bool IsValid();
    }
}

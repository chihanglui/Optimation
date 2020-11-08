using OptimationAPI.Common.Interface;
using System;
using System.Collections.Generic;

namespace OptimationAPI.Common {
    public class ModelContext : IModelContext
    {
        public List<IModelValidation> Validations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid() {
            throw new NotImplementedException();
        }
    }
}

using OptimationAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OptimationAPI.Domain.Interfaces {
    public interface IExpenseService {
        Task<IContext> ExtractEmailContent(Email email);

    }
}

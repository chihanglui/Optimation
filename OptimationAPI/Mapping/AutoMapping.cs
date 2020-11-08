using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OptimationAPI.ViewModel;
using domain = OptimationAPI.Domain.Model;

namespace OptimationAPI.Mapping {
    public class AutoMapping : Profile {
        public AutoMapping() {
            CreateMap<Email, domain.Email>();
            CreateMap<domain.Expense, Expense>();
        }
    }
}

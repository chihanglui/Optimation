using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimationAPI.Domain.Model {
    public class ExpenseContext : Context {
        
        public List<Expense> Expenses { get; set; }

        public override bool IsValid() => !Validations.Any();
    }
}

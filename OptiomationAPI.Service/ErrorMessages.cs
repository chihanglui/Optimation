using OptimationAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OptimationAPI.Domain.Service
{
    
    public static class ErrorMessages {
        public static readonly Dictionary<string, Validation> EmailErrorMsgs = new Dictionary<string, Validation> { 
            { "ERR0001", new Validation(Validation.ValidationTypeEnum.Error, "Email.Content", "Invalid XML content.") }, 
            { "ERR0002", new Validation(Validation.ValidationTypeEnum.Error, "Email.Content", "Cannot find expense.") } 
        };

        public static readonly Dictionary<string, Validation> ExpenseErrorMsgs = new Dictionary<string, Validation> {
            { "ERR0001", new Validation(Validation.ValidationTypeEnum.Error, "Expense.Total", "Invalid expense total.")}
        };
    }

}

using System;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace OptimationAPI.ViewModel {
    public class Expense :ModelBase{

        public Expense() { 
        }

        public Expense(string costCentre, decimal total, string paymentMethod) {
            CostCentre = costCentre;
            Total = total;
            PaymentMethod = paymentMethod;
        }

        public string CostCentre { get; set; }
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal? Total { get; set; }
        public decimal? GST { get; set; }
        public decimal? TotalExcludingGST { get; set; }
        public string PaymentMethod { get; set; }

    }

    
}

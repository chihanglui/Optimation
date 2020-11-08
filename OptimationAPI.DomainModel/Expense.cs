using System;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace OptimationAPI.Domain.Model {
    public class Expense :ModelBase{
        private const string DEFAULT_COST_CENTRE = "UNKNOWN";
        private const decimal GST_RATE = 0.15M;

        public Expense() { 
        }
        public Expense(string costCentre, decimal total, string paymentMethod) {
            CostCentre = string.IsNullOrWhiteSpace(costCentre) ? DEFAULT_COST_CENTRE : costCentre;
            Total = total;
            PaymentMethod = paymentMethod;
        }

        public string CostCentre { get; set; }
        public decimal Total { get; set; }
        public decimal? GST => Total * GST_RATE;
        public decimal? TotalExcludingGST => Total - GST;
        public string PaymentMethod { get; set; }
    }

    
}

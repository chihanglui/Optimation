using OptimationAPI.Domain.Interfaces;
using OptimationAPI.Domain.Model;
using OptimationAPI.Domain.Service.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace OptimationAPI.Domain.Service {
    public class ExpenseService : IExpenseService {

        public  async Task<IContext> ExtractEmailContent(Email email) {
            
            var context = new ExpenseContext();
            var xml = $"<Foo>{email.Content}</Foo>";
            var xmlHelper = new XmlHelper();
            var xmlDoc = await xmlHelper.LoadXmlDocument(xml);

            if (xmlDoc == null) {
                
                context.Validations.Add(ErrorMessages.EmailErrorMsgs["ERR0001"]);
                return context;
            }

            var nodes = xmlDoc.SelectNodes("/Foo/expense");
            if (nodes.Count == 0) {
                context.Validations.Add(ErrorMessages.EmailErrorMsgs["ERR0002"]);
                return context;
            }
            
            var expenses = new List<Expense>();
            foreach (XmlNode node in nodes) {
                var costCentre = node["cost_centre"]?.InnerText;
                decimal total;
                var paymentMethod = node["payment_method"]?.InnerText;
                if (decimal.TryParse(node["total"]?.InnerText, out total)) {
                    expenses.Add(new Expense(costCentre, total, paymentMethod));
                } else {
                    context.Validations.Add(ErrorMessages.ExpenseErrorMsgs["ERR0001"]);
                }
            }
            context.Expenses = expenses;
            return context;
        }



    }
}

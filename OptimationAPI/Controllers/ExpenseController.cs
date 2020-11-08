using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OptimationAPI.ViewModel;
using domain = OptimationAPI.Domain.Model;
using AutoMapper;
using OptimationAPI.Domain.Interfaces;
using System.Net;

namespace OptimationAPI.Controllers
{
    
    [ApiController]
    [Produces("application/json")]
    [Route("api/expenses")]
    public class ExpenseController : ControllerBase {

        private readonly IExpenseService ExpenseService;
        private readonly IMapper Mapper;
        private readonly ILogger<ExpenseController> Logger;

        public ExpenseController(IExpenseService expenseService, IMapper mapper, ILogger<ExpenseController> logger) {
            this.Mapper = mapper;
            this.ExpenseService = expenseService;
            this.Logger = logger;
        }


        


        [HttpGet]
        [ProducesResponseType(typeof(List<Expense>), 200)]
        public async Task<IActionResult> Get()
        {
            var expenses = new List<Expense>();
            expenses.Add( new Expense("Dummy", 1024.01M, "Payment Method"));
            return Ok(expenses);
        }


        [HttpPost]
        [Route("EmailSubmit")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> EmailSubmit([FromBody] Email email) {

                if (!ModelState.IsValid) {
                    return BadRequest(ModelState);
                }

                var domainEmail = Mapper.Map<Email, domain.Email>(email);

                var context = await ExpenseService.ExtractEmailContent(domainEmail);

                if (!context.IsValid()) {
                    return BadRequest(context.Validations);
                }

                var domainExpenses = ((domain.ExpenseContext)context).Expenses;

                var expenses = Mapper.Map<List<domain.Expense>, List<Expense>>(domainExpenses);

                return Created(new Uri(Request.Path, UriKind.Relative), expenses);

        }
    }
}

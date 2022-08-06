using System.Diagnostics;
using Budget.Mvc.Models.ViewModels;
using Budget.Mvc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Budget.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBudgetRepository _budgetRepository;

        public HomeController(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public IActionResult Index()
        {
            var transactions = _budgetRepository.GetTransactions();
            var viewModel = new BudgetViewModel
            {
                Transactions = transactions
            };

            return View(viewModel);
        }
    }
}
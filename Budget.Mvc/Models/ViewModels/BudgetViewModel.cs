namespace Budget.Mvc.Models.ViewModels
{
    public class BudgetViewModel
    {
        public List<Transaction>? Transaction { get; set; }
        public List<System.Transactions.Transaction> Transactions { get; internal set; }
    }
}

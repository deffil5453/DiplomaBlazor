using System.Transactions;

namespace DiplomaRealEstate.Services.TransactionServices
{
    public interface ITransactionService
    {
        Task<List<Transaction>> IndexTransaction();
        Task<Transaction> DetailsTransaction(Guid id);
        Task<Transaction> CreateTransaction(Transaction transaction);
    }
}

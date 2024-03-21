using System.Transactions;

namespace DiplomaRealEstate.Services.TransactionService
{
    public interface ITransactionServices
    {
        Task<List<Transaction>> GetAllTransaction(Guid id);
        Task <Transaction> GetTransaction(Guid id);
        Task <Transaction> CreateTransaction(Transaction transaction);
    }
}

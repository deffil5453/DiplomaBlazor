using DiplomaRealEstate.InputModel;
using System.Transactions;

namespace DiplomaRealEstate.Services.TransactionServices
{
    public interface ITransactionService
    {
        Task<List<Transaction>> IndexTransactionUser(string userId);
        Task<Transaction> DetailsTransaction(Guid id);
        Task<Transaction> CreateTransaction(TransactionInputModel transactionInput);
    }
}

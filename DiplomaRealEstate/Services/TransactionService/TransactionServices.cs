using System.Transactions;

namespace DiplomaRealEstate.Services.TransactionService
{
    public class TransactionServices : ITransactionServices
    {
        public Task<Transaction> CreateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<List<Transaction>> GetAllTransaction(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetTransaction(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

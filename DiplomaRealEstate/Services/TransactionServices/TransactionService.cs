using BlazorApp10.Data;
using DiplomaRealEstate.InputModel;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace DiplomaRealEstate.Services.TransactionServices
{
    public class TransactionService : ITransactionService
    {
		public Task<Transaction> CreateTransaction(TransactionInputModel transactionInput)
		{
			throw new NotImplementedException();
		}

		public Task<Transaction> DetailsTransaction(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Transaction>> IndexTransactionUser(string userId)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                //return await dbContext.Transactions.Where(tr=>tr.CustomerId==userId).ToListAsync();
            }
			throw new NotImplementedException();
		}
    }
}

using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.Models
{
    public class TypeTransaction
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public List<TransactionOrder> Transactions { get; set;}
    }
}
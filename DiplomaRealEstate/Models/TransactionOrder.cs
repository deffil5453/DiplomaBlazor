namespace DiplomaRealEstate.Models
{
    public class TransactionOrder
    {
        public Guid Id { get; set; }
        public Guid TypeTransactionId { get; set; }
        public Guid RealEstateId { get; set; }
        public string SellerId { get; set; }
        public string CustomerId { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public RealEstate RealEstate { get; set; }
        public User User { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiplomaRealEstate.Models
{
    public class RealEstate
    {
        public Guid Id { get; set; }
        [Required] public string Area { get; set; }
        [Required] public int Price { get; set; }
        [Required] public int Rooms { get; set; }
        public string? Desctiption { get; set; }
        [Required] public string Country { get; set; }
        [Required] public string Region { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Photos { get; set; }
        public string UserId { get; set; }
        public Guid TypeRealEstateId { get; set; }
        public Guid StatusId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid? ReviewId { get; set; }
        public User User { get; set; }
        public TypeRealEstate TypeRealEstate { get; set; }
        public Status Status { get; set; }
        public Category Category { get; set; }
        public Review Review { get; set; }
        public List<Transaction> TransactionProperties { get; set; }
    }
}
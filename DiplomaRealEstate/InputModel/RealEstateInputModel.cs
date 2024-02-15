using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.InputModel
{
    public class RealEstateInputModel
    {
        public string Area { get; set; }
        public int Price { get; set; }
        public int Rooms { get; set; }
        public string? Desctiption { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Photos { get; set; }
        public string UserId { get; set; }
        public Guid TypeRealEstateId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
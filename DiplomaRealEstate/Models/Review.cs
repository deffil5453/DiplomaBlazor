using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public string UserId {  get; set; }
        public User User { get; set; }
        [Required] public string text { get; set; }
        [Required] public int Rating { get; set; }
        public string RealEstateId { get; set; }
        public List<RealEstate> RealEstates { get; set; }
    }
}
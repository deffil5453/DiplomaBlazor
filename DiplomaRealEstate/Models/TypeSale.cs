using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.Models
{
    public class TypeSale
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public ICollection<RealEstate>? RealEstates { get; set; }
    }
}
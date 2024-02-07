using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; } = string.Empty;
        public ICollection<RealEstate> RealEstates { get; set; }
    }
}
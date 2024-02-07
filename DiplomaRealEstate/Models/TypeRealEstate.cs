using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.Models
{
    public class TypeRealEstate
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public List<RealEstate> RealEstates { get; set; }
    }
}
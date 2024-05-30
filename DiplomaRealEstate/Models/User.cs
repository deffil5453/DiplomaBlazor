using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.Models
{
    public class User : IdentityUser
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? ImageProfile { get; set; }
        public List<RealEstate> RealEstates { get; set; }
        public List<TransactionOrder>? UserTransaction { get; set; }
        public List<FavoriteRealEstate> Favorites { get; set; }
    }
}
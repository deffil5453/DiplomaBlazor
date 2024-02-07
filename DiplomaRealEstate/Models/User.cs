using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.Models
{
    public class User : IdentityUser
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public List<RealEstate> RealEstates { get; set; }
        public List<Review>? Reviews { get; set; }
        public List<Transaction>? UserTransaction { get; set; }
    }
}
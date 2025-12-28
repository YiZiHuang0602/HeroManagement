using System.ComponentModel.DataAnnotations;

namespace HeroManagement.Models
{
    public class Hero
    {
        public int Id { get; set; }
        [Required]
        public required string HeroName { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string City { get; set; }
    }
}

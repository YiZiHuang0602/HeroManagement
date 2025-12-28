namespace HeroManagement.ViewModel
{
    public class HeroDto
    {
        public int Id { get; set; }
        public required string HeroName { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string City { get; set; }
    }
}

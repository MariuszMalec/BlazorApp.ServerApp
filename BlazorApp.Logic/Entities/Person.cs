namespace BlazorApp.Logic.Entities
{
    public class Person : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public string? AddressCorrespondence { get; set; }

        public string? PhoneNumber { get; set; }

        public string? PhoneMobile { get; set; }
    }
}

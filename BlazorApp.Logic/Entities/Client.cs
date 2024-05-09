namespace BlazorApp.Logic.Entities
{
    public class Client : Person
    {
        public DateTime? DataOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        //public virtual Role Role { get; set; }
    }
}

﻿namespace BlazorApp.Logic.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DataOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        //public virtual Role Role { get; set; }
    }
}

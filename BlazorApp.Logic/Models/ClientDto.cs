﻿namespace BlazorApp.Logic.Models
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DataOfBirth { get; set; }
        public string? Nationality { get; set; }
    }
}

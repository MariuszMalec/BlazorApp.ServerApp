using BlazorApp.Logic.Entities;
using BlazorApp.Logic.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Logic.DataStorage
{
    public class UsersStorage
    {
        private readonly IPasswordHasher<Client> _passwordHasher;

        public UsersStorage(IPasswordHasher<Client> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public static List<User> Users = new List<User>
        {
            new User {Id=1, FirstName = "Mariusz", LastName = "Malec", Address="Sadowa", AddressCorrespondence="",Email="mm@example.com", PhoneMobile="501622578", PhoneNumber=null},
            new User {Id=2, FirstName = "Sebastian", LastName = "Malec" , Address="Dabkowo", AddressCorrespondence="",Email="sm@example.com", PhoneMobile=null, PhoneNumber="552391376"},
            new User {Id=3, FirstName = "Basia", LastName = "Malec" , Address="Sadkowo", AddressCorrespondence="",Email="bm@example.com", PhoneMobile=null, PhoneNumber="552391376"},
            new User {Id=4, FirstName = "Maniek", LastName = "Staniek" , Address="Stankowo", AddressCorrespondence="",Email="ms@example.com", PhoneMobile=null, PhoneNumber="552391376"}
        };
        public static List<Client> Clients = new List<Client>
        {
            new Client {Id=1,FirstName="admin",LastName="admin", Email="admin@example.com", DataOfBirth=DateTime.Now, Nationality="polish", PasswordHash="admin", RoleId=1}
        };

        public string HasPassword(string password, Client client)
        {
            var passwordhash = _passwordHasher.HashPassword(client, password);
            return passwordhash;
        }
    }
}

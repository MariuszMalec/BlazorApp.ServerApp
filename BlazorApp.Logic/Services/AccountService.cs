using BlazorApp.Logic.DataStorage;
using BlazorApp.Logic.Entities;
using BlazorApp.Logic.Interfaces;
using BlazorApp.Logic.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Logic.Services
{
    public class AccountService : IAccountService
    {
        private readonly IPasswordHasher<Client> _passwordHasher;

        public AccountService(IPasswordHasher<Client> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public async Task<bool> Register(RegisterClientDto userDto)
        {
            var newUser = new Client()
            {
                Id = UsersStorage.Clients.Max(u => u.Id) + 1,
                Email = userDto.Email,
                FirstName = "test",
                LastName = userDto.LastName,
                DataOfBirth = DateTime.Now,
                Nationality = "polish",
                RoleId = 1
            };
            var hashedPassword = _passwordHasher.HashPassword(newUser, userDto.Password);
            newUser.PasswordHash = hashedPassword;
            UsersStorage.Clients.Add(newUser);
            if (newUser != null)
                return true;
            return false;
        }
    }
}

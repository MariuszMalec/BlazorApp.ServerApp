using BlazorApp.Logic.Entities;
using BlazorApp.Logic.Interfaces;
using BlazorApp.Logic.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Logic.Services
{
    public class AccountService : IAccountService
    {
        private readonly IPasswordHasher<Client> _passwordHasher;
        public async Task Register(RegisterClientDto userDto)
        {
            var newUser = new Client()
            {
                Email = userDto.Email,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                DataOfBirth = userDto.DataOfBirth,
                Nationality = userDto.Nationality,
                RoleId = userDto.RoleId
            };
            var hashedPassword = _passwordHasher.HashPassword(newUser, userDto.Password);
        }
    }
}

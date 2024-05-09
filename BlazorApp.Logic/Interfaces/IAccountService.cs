using BlazorApp.Logic.Models;

namespace BlazorApp.Logic.Interfaces
{
    public interface IAccountService
    {
        Task<bool> Register(RegisterClientDto userDto);
    }
}

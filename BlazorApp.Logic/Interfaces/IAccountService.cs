using BlazorApp.Logic.Models;

namespace BlazorApp.Logic.Interfaces
{
    public interface IAccountService
    {
        Task Register(RegisterClientDto userDto);
    }
}

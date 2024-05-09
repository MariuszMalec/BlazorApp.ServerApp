using BlazorApp.Logic.DataStorage;
using BlazorApp.Logic.Entities;
using BlazorApp.Logic.Models;
using BlazorApp.Logic.Repositories;

namespace BlazorApp.Logic.Services
{
    public class ClientService : IRepository<ClientDto>
    {
        public IEnumerable<ClientDto> GetAll()
        {
            var result = new List<ClientDto>();
            var clients = UsersStorage.Clients;
            //mapowanie
            foreach (var client in clients)
            {
                result.Add(new ClientDto()
                {
                    Id = client.Id,
                    LastName = client.LastName,
                    Email = client.Email,
                    DataOfBirth = client.DataOfBirth,
                    Nationality = client.Nationality
                });
            }
            return result;
        }

        public ClientDto GetById(int id)
        {
            var client = UsersStorage.Clients.FirstOrDefault(x => x.Id == id);
            if (client == null)
            {

            }
            var result = new ClientDto()
            {
                Id = client.Id,
                LastName = client.LastName,
                Email = client.Email,
                DataOfBirth = client.DataOfBirth,
                Nationality = client.Nationality
            };
            return result;
        }
        public bool DeleteById(int id)
        {
            //return UsersStorage.Clients.Remove(GetById(id));
            throw new NotImplementedException();
        }
        public Client Create(ClientDto newUser)
        {
            //newUser.Id = UsersStorage.Users.Max(u => u.Id) + 1;
            //UsersStorage.Clients.Add(newUser);
            //return newUser;
            throw new NotImplementedException();
        }

        public bool Update(int id, ClientDto user)
        {
            var currentUser = GetById(id);
            currentUser.FirstName = user.FirstName;
            currentUser.LastName = user.LastName;
            currentUser.Email = user.Email;
            return true;
        }

        ClientDto IRepository<ClientDto>.Create(ClientDto newEmployee)
        {
            throw new NotImplementedException();
        }
    }
}

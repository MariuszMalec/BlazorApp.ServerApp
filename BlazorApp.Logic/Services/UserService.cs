using BlazorApp.Logic.DataStorage;
using BlazorApp.Logic.Entities;
using BlazorApp.Logic.Interfaces;

namespace BlazorApp.Logic.Services
{
    public class UserService : IPersonService
    {
        public IEnumerable<User> GetAll()
        {
            return UsersStorage.Users;
        }

        public User GetById(int id)
        {
            return UsersStorage.Users.Single(x => x.Id == id);
        }
        public bool DeleteById(int id)
        {
            return UsersStorage.Users.Remove(GetById(id));
        }
        public User Create(User newUser)
        {
            newUser.Id = UsersStorage.Users.Max(u => u.Id) + 1;
            UsersStorage.Users.Add(newUser);
            return newUser;
        }

        public bool Update(int id, User user)
        {
            var currentUser = GetById(id);
            currentUser.FirstName = user.FirstName;
            currentUser.LastName = user.LastName;
            return true;
        }
    }
}

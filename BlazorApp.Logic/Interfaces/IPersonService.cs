using BlazorApp.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Logic.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        bool DeleteById(int id);
        User Create(User newEmployee);
        bool Update(int id, User employee);
    }
}

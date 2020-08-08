using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RNAX_web.Models;

namespace RNAX_web.Models
{
    public interface IUserRepository
    {
        User User(int Id);
        IEnumerable<User> GetAllUsers();
        User Add(User user);
        User Update(User userchanges);
        User Delete(int Id);
    }

}


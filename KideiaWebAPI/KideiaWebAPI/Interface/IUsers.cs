using System.Collections.Generic;
using KideiaWebAPI.Model;

namespace KideiaWebAPI.Interface
{
    public interface IUsers
    {
        List<Users> GetAllUser();

        Users GetUser(int id);
    }
}
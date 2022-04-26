using KideiaWebAPI.Interface;
using KideiaWebAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace KideiaWebAPI.Repository
{
    public class UsersRepository : IUsers
    {
        List<Users> lisUsers = new List<Users>
        {
            new Users{UserId=1, FirstName="Kirtesh", LastName="Shah", Address="teste01@teste.com.br" },
            new Users{UserId=2, FirstName="Nitya", LastName="Shah", Address="teste02@teste.com.br" },
            new Users{UserId=3, FirstName="Dilip", LastName="Shah", Address="teste03@teste.com.br" },
            new Users{UserId=4, FirstName="Atul", LastName="Shah", Address="teste04@teste.com.br" },
            new Users{UserId=5, FirstName="Swati", LastName="Shah", Address="teste05@teste.com.br" },
            new Users{UserId=6, FirstName="Rashmi", LastName="Shah", Address="teste06@teste.com.br" },
        };
        public List<Users> GetAllUser()
        {
            return lisUsers;
        }

        public Users GetUser(int id)
        {
            return lisUsers.FirstOrDefault(x => x.UserId == id);
        }
    }
}
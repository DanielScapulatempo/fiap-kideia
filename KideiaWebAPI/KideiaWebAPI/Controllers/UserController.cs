using KideiaWebAPI.Interface;
using KideiaWebAPI.Model;
using KideiaWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KideiaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUsers users = new UsersRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetAllUsers()
        {
            return users.GetAllUser();
        }

        [HttpGet("{IdUser:int}")]
        public ActionResult<Users> GetUserById(int IdUser)
        {
            return users.GetUser(IdUser);
        }


    }
}
using file_manager_back.Data;
using file_manager_back.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace file_manager_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController
    {
        IRepository<User> userRepository;
        public UsersController()
        {
            userRepository = new UserRepository();
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return  await userRepository.GetAll();
        }
    
    }
}

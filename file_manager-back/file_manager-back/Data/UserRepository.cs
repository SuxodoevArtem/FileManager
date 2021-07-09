using file_manager_back.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using file_manager_back.Data;

namespace file_manager_back.Data
{
    public class UserRepository : IRepository<User>
    {
        private readonly NpgsqlConnection _conect;
        public UserRepository()
        {
            _conect = ConnectionProvider.npgsqlConnection;
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            List<User> users = new List<User>();

            using (var cmd = new NpgsqlCommand("SELECT * FROM users", _conect))
            {
                var reader = await cmd.ExecuteReaderAsync();
                while ( reader.Read()) {
                    users.Add(new User { id = reader.GetInt32(0) });
                }

            }

            return users;
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

    }
}

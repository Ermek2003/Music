using Abstaction.Interfaces.DataSources;
using Abstaction.Interfaces.Services;
using Mapster;
using Models.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IUserDataSource _userDataSource;
        public UserService(IUserDataSource userDataSource)
        {
            _userDataSource = userDataSource;
        }

        public Task<int> AddUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserDTO> GetUsers()
        {
            return _userDataSource.GetItems().ProjectToType<UserDTO>();
        }

        public Task<int> UpdateUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}

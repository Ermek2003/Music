using Models.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction.Interfaces.Services
{
    public interface IUserService
    {
        IQueryable<UserDTO> GetUsers();
        Task<UserDetailsDTO> GetUser(int id);
        Task<int> AddUser(UserDTO userDTO);
        Task<int> UpdateUser(UserDTO userDTO);
    }
}

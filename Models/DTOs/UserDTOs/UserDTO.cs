using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.UserDTOs
{
    public class UserDTO
    {
        /// <summary>
        /// Identifier code
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Login
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }
    }
}

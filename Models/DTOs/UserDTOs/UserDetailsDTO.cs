using Models.DTOs.PlaylistDTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.UserDTOs
{
    public class UserDetailsDTO : UserDTO
    {
        public ICollection<PlaylistDTO> Playlists { get; set; } = new List<PlaylistDTO>();
    }
}

using Models.DTOs.Playlist_TrackDtos;
using Models.DTOs.TrackDTOs;
using Models.DTOs.UserDTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.PlaylistDTOs
{
    public class PlaylistDetailDTO : PlaylistDTO
    {
        public UserDTO User { get; set; }
        //public ICollection<Playlist_TrackDTO> Playlist_Tracks { get; } = [];
        //public ICollection<TrackDTO> Tracks { get; } = [];
    }
}

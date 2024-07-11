using Models.DTOs.PlaylistDTOs;
using Models.DTOs.TrackDTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Playlist_TrackDtos
{
    public class Playlist_TrackDetailDTO : Playlist_TrackDTO
    {
        public TrackDTO Track { get; set; }
        //public PlaylistDTO Playlist { get; set; }
    }
}

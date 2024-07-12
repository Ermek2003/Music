using Models.DTOs.AlbumDTOs;
using Models.DTOs.GenreDTOs;
using Models.DTOs.Playlist_TrackDtos;
using Models.DTOs.PlaylistDTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.TrackDTOs
{
    public class TrackDetailDTO : TrackDTO
    {
        public AlbumDTO Album { get; set; }
        public GenreDTO Genre { get; set; }
        public ICollection<PlaylistTrackDTO> PlaylistTracks { get; } = [];
        //public ICollection<PlaylistDTO> Playlists { get; } = [];
    }
}

using Models.DTOs.ArtistDTOs;
using Models.DTOs.TrackDTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.AlbumDTOs
{
    public class AlbumDetailDTO : AlbumDTO
    {
        public ArtistDTO Artist { get; set; }
        public ICollection<TrackDTO> Tracks { get; set; }
    }
}

using Models.DTOs.AlbumDTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.ArtistDTOs
{
    public class ArtistDetailDTO : ArtistDTO
    {
        public ICollection<AlbumDTO> Albums { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.TrackDTOs
{
    public class TrackDTO
    {
        /// <summary>
        /// Identifier code
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// AlbumId
        /// </summary>
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
    }
}

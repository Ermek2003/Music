using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Track
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
        public Album Album { get; set; }
        public Genre Genre { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; } = [];
        //public ICollection<Playlist> Playlists { get; } = [];
    }
}

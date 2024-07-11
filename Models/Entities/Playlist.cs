using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Playlist
    {
        /// <summary>
        /// Identifier code
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        //public ICollection<Playlist_Track> Playlist_Tracks { get; } = [];
        //public ICollection<Track> Tracks { get; } = [];
    }
}

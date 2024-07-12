using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string Title { get; set; }
        /// <summary>
        /// UserId
        /// </summary>
        [Required(ErrorMessage = "UserId is required")]
        public int UserId { get; set; }
        /// <summary>
        /// User
        /// </summary>
        
        public User User { get; set; }

        //public ICollection<PlaylistTrack> PlaylistTracks { get; } = [];
        //public ICollection<Track> Tracks { get; } = [];
    }
}

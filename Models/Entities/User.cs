using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class User
    {
        /// <summary>
        /// Identifier code
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Login
        /// </summary>
        [Required(ErrorMessage = "Login is required")]
        [MaxLength(50, ErrorMessage = "Login cannot exceed 50 characters")]
        public string Login { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Album
    {
        /// <summary>
        /// Identifier code
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        /// <summary>
        /// Link to Tracks
        /// </summary>
        public ICollection<Track> Tracks { get; set; }
    }
}

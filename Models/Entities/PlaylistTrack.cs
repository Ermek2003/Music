using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class PlaylistTrack
    {  
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }
        public Track Track { get; set; }
        //public Playlist Playlist { get; set; }
    }
}

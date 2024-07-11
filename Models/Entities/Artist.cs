﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Artist
    {
        /// <summary>
        /// Identifier core
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Link to Albums
        /// </summary>
        public ICollection<Album> Albums { get; set; }
    }
}

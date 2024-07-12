using Abstaction.Interfaces.Services;
using Models.DTOs.PlaylistDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PlaylistService : IPlaylistService
    {
        public Task<int> AddPlaylist(PlaylistDTO playlistDTO)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PlaylistDTO> GedPlaylits()
        {
            throw new NotImplementedException();
        }
    }
}

using Models.DTOs.PlaylistDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction.Interfaces.Services
{
    public interface IPlaylistService
    {
        IQueryable<PlaylistDTO> GedPlaylits();
        Task<int> AddPlaylist(PlaylistDTO playlistDTO);
    }
}

using DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class MusicDbContext :DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new PlaylistConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MusicDbContext).Assembly);
        }
    }
}

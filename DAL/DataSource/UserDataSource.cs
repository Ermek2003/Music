using Abstaction.Interfaces.DataSources;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataSource
{
    public class UserDataSource : GenericDataSource<User>, IUserDataSource
    {
        public UserDataSource(MusicDbContext dbContext) : base(dbContext) { }
        public async Task<User?> GetUserWithPlaylists(Expression<Func<User, bool>> filter)
        {
            return await Set.Include(u => u.Playlists).FirstOrDefaultAsync(filter);
        }
    }
}

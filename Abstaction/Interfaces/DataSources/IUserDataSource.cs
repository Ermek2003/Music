using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction.Interfaces.DataSources
{
    public interface IUserDataSource : IGenericDataSource<User>
    {
        Task<User?> GetUserWithPlaylists(Expression<Func<User, bool>> filter);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction.Interfaces.DataSources
{
    public interface IGenericDataSource<T>
    {
        IQueryable<T> GetItems(Expression<Func<T, bool>>? filter = null);

        Task<T> AddAsync(T item);

        Task SaveChangesAsync();
    }
}

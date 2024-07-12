using Abstaction.Interfaces.DataSources;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataSource
{
    public class GenericDataSource<T> : IGenericDataSource<T> where T : class
    {
        protected readonly MusicDbContext dbContext;
        
        public GenericDataSource(MusicDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        protected DbSet<T> Set => dbContext.Set<T>();

        public async Task<T> AddAsync(T item)
        {
            await Set.AddAsync(item);
            return item;
        }

        public IQueryable<T> GetItems(Expression<Func<T, bool>>? filter = null)
        {
            if(filter is not null)
                return Set.Where(filter).AsNoTracking();
            return Set.AsNoTracking();
        }

        public async Task SaveChangesAsync()
            => await dbContext.SaveChangesAsync();
    }
}

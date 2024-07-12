using Abstaction.Interfaces.DataSources;
using DAL.DataSource;

namespace WebAPI.Extensions
{
    public static class DataSourceServicesServiceExtension
    {
        public static void AddDataSourceServises(this ServiceCollection services)
        {
            services
                .AddScoped(typeof(IGenericDataSource<>), typeof(GenericDataSource<>))
                .AddScoped<IUserDataSource, UserDataSource>();
        }
    }
}

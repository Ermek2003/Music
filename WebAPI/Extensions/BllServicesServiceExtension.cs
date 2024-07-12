using Abstaction.Interfaces.Services;
using BLL.Services;

namespace WebAPI.Extensions
{
    public static class BllServicesServiceExtension
    {
        public static void AddBllServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPlaylistService, PlaylistService>();
        }
    }
}

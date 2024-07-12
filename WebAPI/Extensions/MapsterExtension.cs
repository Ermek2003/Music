namespace WebAPI.Extensions
{
    public static class MapsterExtension
    {
        public static void InitMapping(this IApplicationBuilder app)
        {
            app.UseRouting();
        }
    }
}

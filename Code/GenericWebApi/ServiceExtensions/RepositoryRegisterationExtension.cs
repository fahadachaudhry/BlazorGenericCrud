using Repository.Repositories;

namespace GenericWebApi.ServiceExtensions
{
    public static class ServiceRegistryExtention
    {

        public static IServiceCollection RegisterRepositories(
            this IServiceCollection services,
            IWebHostEnvironment _env)
        {
            services.AddScoped<TodoItemRepo>();
            services.AddScoped<UserProfileRepo>();

            return services;
        }
    }
}

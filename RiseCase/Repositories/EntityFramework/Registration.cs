using Microsoft.EntityFrameworkCore;

namespace RiseCase.Repositories.EntityFramework
{
    public static class Registration
    {
        public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RiseStudyContext>(conf =>
            {
                var connStr = configuration["RiseDbConnectionString"].ToString();

                conf.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });



            return services;
        }
    }
}

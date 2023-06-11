using User_Modul.Data;

namespace User_Modul
{
    public static class ServiceRegister
    {
        public static WebApplicationBuilder AddUserManagement(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers()
                            .AddApplicationPart(typeof(ServiceRegister).Assembly);

            builder.Services.AddSingleton<Users>()
                            .AddSingleton<IUsers>(x => x.GetRequiredService<Users>())
                            .AddSingleton<IUsers>(x => x.GetRequiredService<Users>());

            return builder;
        }
    }

}

using Order_Modul.Data;

namespace Order_Modul
{
    public static class ServiceRegister
    {
        public static WebApplicationBuilder AddOrderManagement(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers()
                            .AddApplicationPart(typeof(ServiceRegister).Assembly);

            builder.Services.AddSingleton<IOrders, Orders>();

            return builder;
        }
    }
}

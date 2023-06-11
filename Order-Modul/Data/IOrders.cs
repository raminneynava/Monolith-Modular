using User_Modul.Data;

namespace Order_Modul.Data
{

    public interface IOrders
    {
        Task<Order?> WithId(int id);
    }

    public class Orders : IOrders
    {
        public Task<Order?> WithId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

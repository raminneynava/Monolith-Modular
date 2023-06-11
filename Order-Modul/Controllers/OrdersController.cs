using Microsoft.AspNetCore.Mvc;

using Order_Modul.Data;

using User_Modul.Data;

namespace Order_Modul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrders orders;
        private readonly IUsers users;

        public OrdersController(IOrders orders, IUsers users)
        {
            this.orders = orders;
            this.users = users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var order = await orders.WithId(id);

            if (order == null)
                return NotFound();

            var user = await users.WithId(order.OrderedById);

            return Ok(new
            {
                Id = order.Id,
                OrderDate = order.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                OrderedBy = user == null ? null : new
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                }
            });
        }
    }
}

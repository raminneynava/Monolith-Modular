using Microsoft.AspNetCore.Mvc;

using User_Modul.Data;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace User_Modul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Data.IUsers users;

        public UsersController(Data.IUsers users)
        {
            this.users = users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await users.WithId(id);

            return user == null ? NotFound() : user;
        }
    }
}

namespace User_Modul.Data
{
    public interface IUsers
    {
        Task<User?> WithId(int id);
    }

    public class Users : IUsers
    {
        public Task<User?> WithId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

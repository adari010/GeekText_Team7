using System.Collections.Generic;

namespace GeekText_Team7.Models
{
    public interface IBookStoreRepository
    {
        User GetUsersByName(string userFirstName);
        IEnumerable<User> GetAllUsers();
    }
}
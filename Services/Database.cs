using System.Collections.Generic;
using AvaTest1.Models;

namespace AvaTest1.Services;

public class Database
{
    public  List<User> Users
    {
        get => new List<User>()
        {
            new User() { ID = 1, Login = "Slava", Password = "123" },
            new User() { ID=2, Login = "Lesha", Password = "111" },
            new User() { ID = 3, Login = "Peter", Password = "321" },
        };

    }
}
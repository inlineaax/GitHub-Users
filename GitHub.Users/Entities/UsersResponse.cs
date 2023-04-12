using System.Collections.Generic;

namespace GitHub.Users.Entities
{
    public class UsersResponse
    {
        public List<Users> users { get; set; }
        public string nextPage { get; set; }

    }
}

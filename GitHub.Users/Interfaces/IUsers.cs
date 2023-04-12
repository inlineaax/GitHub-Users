using GitHub.Users.Entities;
using RestSharp;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHub.Users.Interfaces
{
    public interface IUsers
    {
        Task<UsersResponse> GetUsers(int number);
    }
}

using GitHub.Users.Entities;
using RestSharp;
using System.Threading.Tasks;

namespace GitHub.Users.Interfaces
{
    public interface IUserRepositories
    {
        Task<RestResponse> GetUserRepositories(string username);
    }
}

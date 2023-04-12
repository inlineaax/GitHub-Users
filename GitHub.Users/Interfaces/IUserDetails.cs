using RestSharp;
using System.Threading.Tasks;

namespace GitHub.Users.Interfaces
{
    public interface IUserDetails
    {
        Task<RestResponse> GetUserDetails(string username);        
    }
}

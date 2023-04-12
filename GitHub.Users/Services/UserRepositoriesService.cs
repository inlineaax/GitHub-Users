using GitHub.Users.Interfaces;
using RestSharp;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitHub.Users.Service
{
    public class UserRepositoriesService : IUserRepositories
    {
        public async Task<RestResponse> GetUserRepositories(string username)
        {
            var client = new RestClient("https://api.github.com/");
            var request = new RestRequest($"users/{username}/repos", Method.Get);
            request.AddHeader("Authorization", "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");
            var response = await client.ExecuteGetAsync(request);

            return response;
        }

    }
}
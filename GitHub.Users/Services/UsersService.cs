using GitHub.Users.Entities;
using GitHub.Users.Interfaces;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitHubUsers.Service
{
    public class UsersService : IUsers
    {
        public async Task<UsersResponse> GetUsers(int number)
        {
            RestClient client = new("https://api.github.com/");
            RestRequest request = new($"users?since={number}", Method.Get);
            request.AddHeader("Authorization", "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");

            RestResponse response = await client.ExecuteGetAsync(request);
            
            List<Users> users = JsonSerializer.Deserialize<List<Users>>(response.Content);
            UsersResponse ur = new()
            {
                users = users,
                nextPage = GetNextUrl(response)
            };

            return ur;
        }

        private static string GetNextUrl(RestResponse rr)
        {
            string? temp = rr?.Headers.Where(o => o.Name == "Link")!.FirstOrDefault()!.Value.ToString();
            int firstCaracter = temp.IndexOf(">");
            return temp.Substring(1, firstCaracter - 1);
        }

    }
}
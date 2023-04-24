using Gitblazor.Shared.Models;
using System.Net.Http.Json;

namespace Gitblazor.UI.Services
{
    public class GithubService : IGithubService
    {
        public State State { get; set; }

        public GithubService(State state)
        {
            State = state;
        }

        public async Task<bool> LoginUser(string token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token); ;

                    var result = await client.GetAsync(" https://api.github.com/user");
                    if (result.IsSuccessStatusCode)
                        State.SetUser(await result.Content.ReadFromJsonAsync<UserData>());

                    return result.IsSuccessStatusCode;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}

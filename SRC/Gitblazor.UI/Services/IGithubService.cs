namespace Gitblazor.UI.Services
{
    public interface IGithubService
    {
        Task<bool> LoginUser(string token);
    }
}
using Gitblazor.Shared.Models;

namespace Gitblazor.UI
{
    public class State
    {

        public event EventHandler<EventArgs>? StateChanged;
        public UserData user = new();
        private static string Token { get; set; }
        public bool IsLoggedIn { get; set; }

        public void SetToken(string token)
        {
            Token = token;
        }
        public string GetToken()
        {
            return Token;   
        }

        public void Reset()
        {
            IsLoggedIn = false;
            Token = string.Empty;
        }

        public void SetUser(UserData user)
        {
            this.user = user;
            StateChanged?.Invoke(this, new EventArgs());
        }
    }
}

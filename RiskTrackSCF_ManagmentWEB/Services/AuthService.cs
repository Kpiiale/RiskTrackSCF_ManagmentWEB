using RiskTrackSCF_ManagmentWEB.Models;
using System.Text.Json;

namespace RiskTrackSCF_ManagmentWEB.Services
{
    public class AuthService
    {
        private readonly HttpClient _http;
        public AuthService(HttpClient http) => _http = http;

        public async Task<User?> LoginAsync(LoginRequest request)
        {
            var response = await _http.PostAsJsonAsync("api/auth/login", request);
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadFromJsonAsync<JsonElement>();
            var userData = json.GetProperty("user");

            return new User
            {
                UserId = userData.GetProperty("userId").GetInt32(),
                Username = userData.GetProperty("username").GetString(),
                Email = userData.GetProperty("email").GetString(),
                Role = userData.GetProperty("role").GetString()
            };
        }
    }
}

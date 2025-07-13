using RiskTrackSCF_ManagmentWEB.Models;

namespace RiskTrackSCF_ManagmentWEB.Services
{
    public class UserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<User>?> GetUsersAsync()
        {
            return await _http.GetFromJsonAsync<List<User>>("api/Users");
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<User>($"api/Users/{id}");
        }

        public async Task<bool> CreateUserAsync(User CreateUserRequest)
        {
            var response = await _http.PostAsJsonAsync("api/Users", CreateUserRequest);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateUserAsync(int id, User user)
        {
            var response = await _http.PutAsJsonAsync($"api/Users/{id}", user);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/Users/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

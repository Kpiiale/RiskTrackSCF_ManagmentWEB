﻿using RiskTrackSCF_ManagmentWEB.Models;

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

        public async Task<bool> CreateUserAsync(CreateUserRequest request)
        {
            var existingUsers = await GetUsersAsync();
            bool existingEmail = existingUsers?.Any(u =>
                u.Email.Equals(request.Email, StringComparison.OrdinalIgnoreCase)) ?? false;

            if (existingEmail)
            {
                Console.WriteLine("No se puede crear el usuario: correo ya está en uso.");
                return false;
            }
            var response = await _http.PostAsJsonAsync("api/Users", request);
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

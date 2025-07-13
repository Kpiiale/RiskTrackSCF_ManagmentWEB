using RiskTrackSCF_ManagmentWEB.Models;
namespace RiskTrackSCF_ManagmentWEB.Services
{
    public class CompanyService
    {
        private readonly HttpClient _http;

        public CompanyService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Company>?> GetCompaniesAsync()
        {
            return await _http.GetFromJsonAsync<List<Company>>("api/Companies");
        }

        public async Task<Company?> GetCompanyByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<Company>($"api/Companies/{id}");
        }

        public async Task<bool> CreateCompanyAsync(CreateCompanyRequest request)
        {
            var response = await _http.PostAsJsonAsync("api/Companies", request);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateCompanyAsync(int id, Company company)
        {
            var response = await _http.PutAsJsonAsync($"api/Companies/{id}", company);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCompanyAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/Companies/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}


using System.Net.Http.Json;

namespace PhoneStore.Data.Services
{
    public class CrudService<T>(HttpClient http) : ICrudService<T>
    {
        private readonly HttpClient _http = http;

        public async Task<List<T>> GetAllAsync(string endpoint)
        {
            return await _http.GetFromJsonAsync<List<T>>(endpoint)
                   ?? [];
        }

        public async Task<bool> InsertAsync(string endpoint, T entity)
        {
            var response = await _http.PostAsJsonAsync(endpoint, entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(string endpoint, int? id, T entity)
        {
            var response = await _http.PutAsJsonAsync($"{endpoint}/{id}", entity);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(string endpoint, int? id)
        {
            var response = await _http.DeleteAsync($"{endpoint}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

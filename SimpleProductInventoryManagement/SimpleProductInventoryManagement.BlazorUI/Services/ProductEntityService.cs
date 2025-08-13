
using Blazored.LocalStorage;
using SimpleProductInventoryManagement.Contracts;
using SimpleProductInventoryManagement.BlazorUI.Models;
using SimpleProductInventoryManagement.BlazorUI.Services.Base;
using System.Net.Http.Json;

namespace SimpleProductInventoryManagement.BlazorUI.Services
{
    public class ProductEntityService : IProductEntityService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public ProductEntityService(IHttpClientFactory factory, ILocalStorageService localStorageService) 
        {
            this._httpClient = factory.CreateClient("AuthorizedAPI");
            this._localStorageService = localStorageService;
        }

        public async Task<Response<Guid>> CreateProductEntity(ProductEntityVM productEntity)
        {
            
            await _httpClient.PostAsJsonAsync("api/products", productEntity);
            return new Response<Guid>();

        }

        public async Task<Response<Guid>> DeleteProductEntity(int id)
        {
           
            await _httpClient.DeleteAsync($"api/products/{id}");
            return new Response<Guid>() { Success = true };
        }

        public async Task<ProductEntityVM> GetProductDetails(int id)
        {
           
            var product = await _httpClient.GetFromJsonAsync<ProductEntityVM>($"api/products/{id}");
            if (product is null)
                throw new InvalidOperationException($"Product with id {id} was not found.");
            return product;
        }

        public async Task<List<ProductEntityVM>> GetProductEntities()
        {
            try
            {
                //    var storedToken = await _localStorageService.GetItemAsync<string>("token");
                //    Console.WriteLine($"[DEBUG] Token currently in local storage: {storedToken}");
                var result = await _httpClient.GetFromJsonAsync<List<ProductEntityVM>>("api/products");
                return result?
                    .Where(p => p != null)
                    .ToList()
                     ?? new List<ProductEntityVM>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching products: {ex.Message}");
                return new List<ProductEntityVM>();
            }
        }

        public async Task<Response<Guid>> UpdateProductEntity(int id, ProductEntityVM productEntity)
        {
         
            await _httpClient.PutAsJsonAsync($"api/products/{id}", productEntity);
            return new Response<Guid>() { Success = true };
            }
    }
}

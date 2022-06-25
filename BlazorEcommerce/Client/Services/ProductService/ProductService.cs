namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public ProductService(HttpClient http)
        {
            this.http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProducts()
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }
    }
}

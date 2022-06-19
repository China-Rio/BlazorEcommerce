using BlazorEcommerce.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
        }
    }
}

using Microsoft.AspNetCore.Components;

namespace BlazorEcommerce.Client.Pages
{
    public partial class ProductDetails
    {
        private Product? product = null;

        [Parameter]
        public int Id { get; set; }
        protected override async Task OnParametersSetAsync()
        {
            product = ProductService.Products.Find(p => p.Id == Id);
        }

    }
}

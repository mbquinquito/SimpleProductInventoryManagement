
using Microsoft.AspNetCore.Components;
using SimpleProductInventoryManagement.Contracts;
using SimpleProductInventoryManagement.Models;

namespace SimpleProductInventoryManagement.PLEASE.Pages.ProductEntities
{
    public partial class Edit
    {
        [Inject]
        IProductEntityService ProductEntityService { get; set; }

        [Inject]
        NavigationManager _navManager { get; set; }

        [Parameter]
        public int id { get; set; }
        public string Message { get; private set; }

        ProductEntityVM productEntity = new ProductEntityVM();

        protected async override Task OnParametersSetAsync()
        {
            productEntity = await ProductEntityService.GetProductDetails(id);
        }

        async Task EditProductEntity()
        {
            var response = await ProductEntityService.UpdateProductEntity(id, productEntity);
            if (response.Success)
            {
                _navManager.NavigateTo("/products/");
            }
            Message = response.Message;
        }
    }
}
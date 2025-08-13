using Microsoft.AspNetCore.Components;
using SimpleProductInventoryManagement.Contracts;
using SimpleProductInventoryManagement.Models;

namespace SimpleProductInventoryManagement.PLEASE.Pages.ProductEntities
{
    public partial class Details
    {
        [Inject]
        IProductEntityService ProductEntityService { get; set; }

        [Parameter]
        public int id { get; set; }

        public string Message { get; private set; }

        ProductEntityVM productEntity = new ProductEntityVM();

        protected async override Task OnParametersSetAsync()
        {
            productEntity = await ProductEntityService.GetProductDetails(id);
        }
    }
}
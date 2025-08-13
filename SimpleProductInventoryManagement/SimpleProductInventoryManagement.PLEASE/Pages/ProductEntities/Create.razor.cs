using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using SimpleProductInventoryManagement.Contracts;
using SimpleProductInventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Numerics;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.PLEASE.Pages.ProductEntities
{
    public partial class Create
    {
        [Inject]
        NavigationManager _navManager { get; set; }
        [Inject]
        IProductEntityService ProductEntityService { get; set; }
        public string Message { get; private set; }

        ProductEntityVM productEntity = new ProductEntityVM();
        async Task CreateProductEntity()
        {
            var response = await ProductEntityService.CreateProductEntity(productEntity);
            if(response.Success)
            {
               
                _navManager.NavigateTo("/products/");
            }
            Message = response.Message;
        }
    }
}
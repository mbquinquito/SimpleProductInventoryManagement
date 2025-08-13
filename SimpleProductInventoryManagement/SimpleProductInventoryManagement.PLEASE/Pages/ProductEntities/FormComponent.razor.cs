using Microsoft.AspNetCore.Components;
using SimpleProductInventoryManagement.Models;

namespace SimpleProductInventoryManagement.PLEASE.Pages.ProductEntities
{
    public partial class FormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public ProductEntityVM ProductEntity { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
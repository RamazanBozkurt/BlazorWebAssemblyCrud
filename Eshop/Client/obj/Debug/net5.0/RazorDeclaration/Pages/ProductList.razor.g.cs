// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Eshop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Eshop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Eshop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Eshop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\_Imports.razor"
using Eshop.Client.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\ramaz\Desktop\WebAssemblyTest\Test2\Eshop\Eshop\Client\Pages\ProductList.razor"
       
    public int Id { get; set; }

    List<Product> products = new List<Product>();

    protected override async Task OnInitializedAsync()
    {
        products = await ProductService.GetProducts();
    }

    void BtnAddNewProduct()
    {
        NavigationManager.NavigateTo("addproduct");
        Console.WriteLine("burası çalışıyor");
    }

    async Task RemoveProduct()
    {
        await ProductService.DeleteProduct(Id);
        Console.WriteLine($"{Id} numaralı ürün silindi");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591

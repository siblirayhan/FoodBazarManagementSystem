#pragma checksum "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\OrderManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1add62ef9ea5890af054e01e86e30f8581e2945d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderManager), @"mvc.1.0.view", @"/Views/Home/OrderManager.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\_ViewImports.cshtml"
using FoodBazarManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\_ViewImports.cshtml"
using FoodBazarManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1add62ef9ea5890af054e01e86e30f8581e2945d", @"/Views/Home/OrderManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3f50c86b97959a927b364367ee20141dcd7a7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\OrderManager.cshtml"
  
    ViewData["Title"] = "OrderManager";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Order Manager</h1>
<ul class=""nav nav-tabs nav-justified"" role=""tablist"">
    <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#pending"">Pending</a></li>
    <li class=""nav-item""><a class=""nav-link "" data-toggle=""tab"" href=""#delivered"">Delivered</a></li>
</ul>

<div class=""tab-content"">
    <div class=""tab-pane active"" id=""pending"">
        <p>pending items.</p>
    </div>
    <div class=""tab-pane fade"" id=""delivered"">
        <p>delivered items.</p>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
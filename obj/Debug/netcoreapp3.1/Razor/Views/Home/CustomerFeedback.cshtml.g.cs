#pragma checksum "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a06718494250882128cfd2e4d3baeff85ff6bb5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerFeedback), @"mvc.1.0.view", @"/Views/Home/CustomerFeedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a06718494250882128cfd2e4d3baeff85ff6bb5d", @"/Views/Home/CustomerFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3f50c86b97959a927b364367ee20141dcd7a7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FoodBazarManagementSystem.Models.CustomerFeedback>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
  
    ViewData["Title"] = "CustomerFeedback";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Customer Feedback</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\" data-toggle=\"collapse\" data-target=\"#a_");
#nullable restore
#line 11 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
                                                                       Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <strong>Name:</strong>");
#nullable restore
#line 12 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
                                 Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                <strong>Email:</strong>");
#nullable restore
#line 13 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
                                  Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                <strong>Date:</strong> 03-Mar-2020\r\n            </div>\r\n            <div class=\"card-body collapse\"");
            BeginWriteAttribute("id", " id=\"", 536, "\"", 551, 2);
            WriteAttributeValue("", 541, "a_", 541, 2, true);
#nullable restore
#line 16 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
WriteAttributeValue("", 543, item.id, 543, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 17 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
           Write(item.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\sibli\OneDrive\C# Projects\FoodBazarManagementSystem\FoodBazarManagementSystem\Views\Home\CustomerFeedback.cshtml"
        
        
    }        

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FoodBazarManagementSystem.Models.CustomerFeedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
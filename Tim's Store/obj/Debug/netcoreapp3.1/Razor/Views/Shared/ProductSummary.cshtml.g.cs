#pragma checksum "C:\Users\Timwe\OneDrive\Desktop\Jonesin4Sports-master\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03dc80ebdaa1706cbc8b8a40aba73a65852b400f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
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
#line 1 "C:\Users\Timwe\OneDrive\Desktop\Jonesin4Sports-master\Views\_ViewImports.cshtml"
using OutDoorProducts.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Timwe\OneDrive\Desktop\Jonesin4Sports-master\Views\_ViewImports.cshtml"
using OutDoorProducts.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03dc80ebdaa1706cbc8b8a40aba73a65852b400f", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62eda96f402e724f205ac3ee40a2a2ddbb165ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card card-outline-primary m-1 p-1\">\n    <div class=\"bg-faded p-1\">\n        <h4>\n            ");
#nullable restore
#line 6 "C:\Users\Timwe\OneDrive\Desktop\Jonesin4Sports-master\Views\Shared\ProductSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\n                <small>");
#nullable restore
#line 8 "C:\Users\Timwe\OneDrive\Desktop\Jonesin4Sports-master\Views\Shared\ProductSummary.cshtml"
                  Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </span>\n        </h4>\n    </div>\n    <div class=\"card-text p-1\">");
#nullable restore
#line 12 "C:\Users\Timwe\OneDrive\Desktop\Jonesin4Sports-master\Views\Shared\ProductSummary.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\пк\source\repos\asp\aspshop\Views\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7338370dd3991925f418dbd5454cc6049a46fa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List), @"mvc.1.0.view", @"/Views/List.cshtml")]
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
#line 1 "C:\Users\пк\source\repos\asp\aspshop\Views\List.cshtml"
using aspshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7338370dd3991925f418dbd5454cc6049a46fa1", @"/Views/List.cshtml")]
    public class Views_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\пк\source\repos\asp\aspshop\Views\List.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 6 "C:\Users\пк\source\repos\asp\aspshop\Views\List.cshtml"
       Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        ");
#nullable restore
#line 7 "C:\Users\пк\source\repos\asp\aspshop\Views\List.cshtml"
   Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h4>");
#nullable restore
#line 8 "C:\Users\пк\source\repos\asp\aspshop\Views\List.cshtml"
       Write(p.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\пк\source\repos\asp\aspshop\Views\List.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

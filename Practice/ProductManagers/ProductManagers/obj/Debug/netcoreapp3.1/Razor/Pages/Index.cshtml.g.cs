#pragma checksum "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490e233d3df04f1071e55f8db70d0ff082bc6381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProductManagers.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ProductManagers.Pages
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
#line 1 "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\_ViewImports.cshtml"
using ProductManagers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490e233d3df04f1071e55f8db70d0ff082bc6381", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b8efbb0c1465dee28eb5af876c386045b0454b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 13 "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\Index.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 398, "\"", 446, 4);
            WriteAttributeValue("", 406, "background-image:", 406, 17, true);
            WriteAttributeValue(" ", 423, "url(\'", 424, 6, true);
#nullable restore
#line 16 "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\Index.cshtml"
WriteAttributeValue("", 429, product.Image, 429, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 443, "\');", 443, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\Index.cshtml"
                              Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\Index.cshtml"
                              Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h5>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\User\source\repos\WebForm\Practice\ProductManagers\ProductManagers\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

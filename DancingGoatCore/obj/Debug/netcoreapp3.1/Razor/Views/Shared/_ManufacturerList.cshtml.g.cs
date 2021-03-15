#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "671c856fbb62377a1a02b119783bdf49b2393c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ManufacturerList), @"mvc.1.0.view", @"/Views/Shared/_ManufacturerList.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
using DancingGoat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671c856fbb62377a1a02b119783bdf49b2393c0e", @"/Views/Shared/_ManufacturerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ManufacturerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ManufactureListItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row manufacturer-list\">\r\n");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
     if (Model != null && Model.Any())
    {
        foreach (var manufacturer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-xs-12 col-md-4 col-lg-3 manufacturer-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 311, "\"", 335, 1);
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
WriteAttributeValue("", 318, manufacturer.Url, 318, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 363, "\"", 392, 1);
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
WriteAttributeValue("", 369, manufacturer.ImagePath, 369, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 393, "\"", 417, 1);
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
WriteAttributeValue("", 399, manufacturer.Name, 399, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 418, "\"", 444, 1);
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
WriteAttributeValue("", 426, manufacturer.Name, 426, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"ContentLabel\">");
#nullable restore
#line 18 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
                              Write(HtmlLocalizer["No matching manufacturers."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 19 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_ManufacturerList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ManufactureListItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\ViewComponents\SocialLinks\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63f5bb9a00d7a1f93e6eccf9213ad0c6519ac142"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_ViewComponents_SocialLinks_Default), @"mvc.1.0.view", @"/Components/ViewComponents/SocialLinks/Default.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f5bb9a00d7a1f93e6eccf9213ad0c6519ac142", @"/Components/ViewComponents/SocialLinks/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    public class Components_ViewComponents_SocialLinks_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DancingGoat.Models.SocialLinkViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"social-links\">\n");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\ViewComponents\SocialLinks\Default.cshtml"
     foreach (var link in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"followus-link\"");
            BeginWriteAttribute("href", " href=\"", 158, "\"", 174, 1);
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\ViewComponents\SocialLinks\Default.cshtml"
WriteAttributeValue("", 165, link.Url, 165, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 209, "\"", 229, 1);
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\ViewComponents\SocialLinks\Default.cshtml"
WriteAttributeValue("", 215, link.IconPath, 215, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 230, "\"", 247, 1);
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\ViewComponents\SocialLinks\Default.cshtml"
WriteAttributeValue("", 236, link.Title, 236, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 248, "\"", 267, 1);
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\ViewComponents\SocialLinks\Default.cshtml"
WriteAttributeValue("", 256, link.Title, 256, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </a>\n");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\ViewComponents\SocialLinks\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DancingGoat.Models.SocialLinkViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

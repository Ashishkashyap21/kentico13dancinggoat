#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Orders\DisplayTemplates\OrderAddressViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6f42e2e0b99ea8b516d93a70537c26bf4e67bb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_DisplayTemplates_OrderAddressViewModel), @"mvc.1.0.view", @"/Views/Orders/DisplayTemplates/OrderAddressViewModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f42e2e0b99ea8b516d93a70537c26bf4e67bb5", @"/Views/Orders/DisplayTemplates/OrderAddressViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_DisplayTemplates_OrderAddressViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.OrderAddressViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Orders\DisplayTemplates\OrderAddressViewModel.cshtml"
Write(Model.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Orders\DisplayTemplates\OrderAddressViewModel.cshtml"
Write(Model.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Orders\DisplayTemplates\OrderAddressViewModel.cshtml"
Write(Model.AddressCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Orders\DisplayTemplates\OrderAddressViewModel.cshtml"
Write(Model.AddressPostalCode);

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Orders\DisplayTemplates\OrderAddressViewModel.cshtml"
                         Write(string.IsNullOrEmpty(Model.AddressState) ? string.Empty : ", " + Model.AddressState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Orders\DisplayTemplates\OrderAddressViewModel.cshtml"
Write(Model.AddressCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.OrderAddressViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

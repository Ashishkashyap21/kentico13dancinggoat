#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\Sections\ThreeColumnSection\_DancingGoat_ThreeColumnSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32dd941ca66372288d866bdf54a9abd1473c179c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_Sections_ThreeColumnSection__DancingGoat_ThreeColumnSection), @"mvc.1.0.view", @"/Components/Sections/ThreeColumnSection/_DancingGoat_ThreeColumnSection.cshtml")]
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
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\Sections\ThreeColumnSection\_DancingGoat_ThreeColumnSection.cshtml"
using DancingGoat.Sections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32dd941ca66372288d866bdf54a9abd1473c179c", @"/Components/Sections/ThreeColumnSection/_DancingGoat_ThreeColumnSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    public class Components_Sections_ThreeColumnSection__DancingGoat_ThreeColumnSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComponentViewModel<ThreeColumnSectionProperties>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper __Kentico_Content_Web_Mvc_WidgetZoneTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\Sections\ThreeColumnSection\_DancingGoat_ThreeColumnSection.cshtml"
 if (!string.IsNullOrWhiteSpace(Model.Properties.Title))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"title-wrapper\">\r\n            <h1 class=\"title-tab\">");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\Sections\ThreeColumnSection\_DancingGoat_ThreeColumnSection.cshtml"
                             Write(Model.Properties.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\Sections\ThreeColumnSection\_DancingGoat_ThreeColumnSection.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 310, "\"", 368, 3);
            WriteAttributeValue("", 318, "row", 318, 3, true);
            WriteAttributeValue(" ", 321, "row--with-cols-padding", 322, 23, true);
#nullable restore
#line 13 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Components\Sections\ThreeColumnSection\_DancingGoat_ThreeColumnSection.cshtml"
WriteAttributeValue(" ", 344, Model.Properties.Theme, 345, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget-zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32dd941ca66372288d866bdf54a9abd1473c179c5955", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_WidgetZoneTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_WidgetZoneTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget-zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32dd941ca66372288d866bdf54a9abd1473c179c6901", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_WidgetZoneTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_WidgetZoneTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("widget-zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32dd941ca66372288d866bdf54a9abd1473c179c7847", async() => {
            }
            );
            __Kentico_Content_Web_Mvc_WidgetZoneTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.WidgetZoneTagHelper>();
            __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_WidgetZoneTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComponentViewModel<ThreeColumnSectionProperties>> Html { get; private set; }
    }
}
#pragma warning restore 1591

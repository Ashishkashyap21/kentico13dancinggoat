#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6237bf00119f219d65e9d248ff28b0b9751bb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6237bf00119f219d65e9d248ff28b0b9751bb6", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Register"].Value;
    ViewData["PageClass"] = "inverted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"signin-register\">\n    <div class=\"row\">\n        <div class=\"col-md-6 zone-dark\">\n            <h2>");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
           Write(HtmlLocalizer["Register"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n            <p>");
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
          Write(HtmlLocalizer["Create your own account and enjoy smooth shopping experience at Dancing Goat."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <div class=\"separator\"></div>\n            <div class=\"form-group-input\">\n                <div class=\"logon-page-background\">\n                    <div class=\"logon-panel\">\n                        \n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6237bf00119f219d65e9d248ff28b0b9751bb65786", async() => {
                WriteLiteral("\n                            <div class=\"form-horizontal\" role=\"form\">\n                                ");
#nullable restore
#line 20 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                <div class=\"form-group\">\n                                    <div class=\"editing-form-label-cell\">\n                                        ");
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                    <div class=\"editing-form-value-cell\">\n                                        ");
#nullable restore
#line 26 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        ");
#nullable restore
#line 27 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                </div>\n\n                                <div class=\"form-group\">\n                                    <div class=\"editing-form-label-cell\">\n                                        ");
#nullable restore
#line 33 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                    <div class=\"editing-form-value-cell\">\n                                        ");
#nullable restore
#line 36 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        ");
#nullable restore
#line 37 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                </div>\n\n                                <div class=\"form-group\">\n                                    <div class=\"editing-form-label-cell\">\n                                        ");
#nullable restore
#line 43 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                    <div class=\"editing-form-value-cell\">\n                                        ");
#nullable restore
#line 46 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        ");
#nullable restore
#line 47 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                </div>\n\n                                <div class=\"form-group\">\n                                    <div class=\"editing-form-label-cell\">\n                                        ");
#nullable restore
#line 53 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                    <div class=\"editing-form-value-cell\">\n                                        ");
#nullable restore
#line 56 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.PasswordFor(model => model.Password, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        ");
#nullable restore
#line 57 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                </div>\n\n                                <div class=\"form-group\">\n                                    <div class=\"editing-form-label-cell\">\n                                        ");
#nullable restore
#line 63 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.LabelFor(model => model.PasswordConfirmation, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                    <div class=\"editing-form-value-cell\">\n                                        ");
#nullable restore
#line 66 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.PasswordFor(model => model.PasswordConfirmation, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        ");
#nullable restore
#line 67 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.PasswordConfirmation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                </div>\n\n                                <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 4561, "\"", 4595, 1);
#nullable restore
#line 71 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
WriteAttributeValue("", 4569, HtmlLocalizer["Register"], 4569, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" />\n                            </div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n        <div class=\"col-md-6 zone-light\">\n            <h2>");
#nullable restore
#line 79 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
           Write(HtmlLocalizer["Already have an account?"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n            ");
#nullable restore
#line 80 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Account\Register.cshtml"
       Write(Html.ActionLink(HtmlLocalizer["Sign in"].Value, "Login", null, new { @class = "btn btn-secondary btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

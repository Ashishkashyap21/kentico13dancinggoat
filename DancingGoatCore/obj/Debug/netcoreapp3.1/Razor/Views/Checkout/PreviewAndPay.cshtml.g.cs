#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a535ae36f09a96a64fa004ff3b88c8704b951f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_PreviewAndPay), @"mvc.1.0.view", @"/Views/Checkout/PreviewAndPay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3a535ae36f09a96a64fa004ff3b88c8704b951f", @"/Views/Checkout/PreviewAndPay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_PreviewAndPay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.PreviewViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeliveryDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ErrorLabel red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ShoppingCartContentPreview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ShoppingCartTotals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PreviewAndPay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Preview"].Value;
    ViewData["PageClass"] = "inverted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"checkout-container\">\r\n    <div class=\"cart\">\r\n        <div class=\"continue-shopping-link\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3a535ae36f09a96a64fa004ff3b88c8704b951f7049", async() => {
                WriteLiteral("&larr; ");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                                              Write(HtmlLocalizer["back to Billing & Delivery"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3a535ae36f09a96a64fa004ff3b88c8704b951f8496", async() => {
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                                                                  Write(HtmlLocalizer["Your order cannot be completed"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
       Write(Html.ValidationMessage("shipping", new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 19 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
       Write(Html.ValidationMessage("cart.empty", new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-8 cart-content\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <h2>");
#nullable restore
#line 25 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                   Write(HtmlLocalizer["Billing details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                    ");
#nullable restore
#line 27 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
               Write(Html.DisplayFor(m => m.CustomerDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <br />\r\n\r\n                    ");
#nullable restore
#line 31 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
               Write(Html.DisplayFor(m => m.BillingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                 if (Model.DeliveryDetails.ShippingOption.IsVisible)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6\">\r\n                        <h2>");
#nullable restore
#line 36 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                       Write(HtmlLocalizer["Shipping details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span>");
#nullable restore
#line 37 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                         Write(Model.ShippingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br />\r\n                        <div>");
#nullable restore
#line 39 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                        Write(Model.CustomerDetails.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        <br />\r\n\r\n                        ");
#nullable restore
#line 43 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                   Write(Html.DisplayFor(m => m.BillingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n                <h2>");
#nullable restore
#line 48 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
               Write(HtmlLocalizer["Ordered items"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <hr class=\"first-separator\" />\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3a535ae36f09a96a64fa004ff3b88c8704b951f14297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 51 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.CartModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"cart-right-panel floating-box\">\r\n                <div id=\"shoppingCartTotals\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3a535ae36f09a96a64fa004ff3b88c8704b951f16084", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 57 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.CartModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3a535ae36f09a96a64fa004ff3b88c8704b951f17709", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 61 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
               Write(Html.EditorFor(m => m.PaymentMethod));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2298, "\"", 2339, 1);
#nullable restore
#line 62 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Checkout\PreviewAndPay.cshtml"
WriteAttributeValue("", 2306, HtmlLocalizer["Confirm and pay"], 2306, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn-primary checkout-button btn btn-default\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.PreviewViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

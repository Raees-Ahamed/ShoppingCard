#pragma checksum "D:\Inexis\ShoppingCard\ShoppingCard.Web\ShoppingCard.Web\Views\OrderLine\EditOrderLine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f030483985a7948820ad4ebfbbf5f96cb644947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderLine_EditOrderLine), @"mvc.1.0.view", @"/Views/OrderLine/EditOrderLine.cshtml")]
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
#line 1 "D:\Inexis\ShoppingCard\ShoppingCard.Web\ShoppingCard.Web\Views\_ViewImports.cshtml"
using ShoppingCard.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Inexis\ShoppingCard\ShoppingCard.Web\ShoppingCard.Web\Views\_ViewImports.cshtml"
using ShoppingCard.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f030483985a7948820ad4ebfbbf5f96cb644947", @"/Views/OrderLine/EditOrderLine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be728112cac539601283df2937fdb236dfd179ce", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderLine_EditOrderLine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Inexis\ShoppingCard\ShoppingCard.Web\ShoppingCard.Web\Views\OrderLine\EditOrderLine.cshtml"
  
    ViewData["Title"] = "EditOrderLine";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>EditOrderLine</h1>\r\n<div class=\"container-fluid\">\r\n    <div class=\"form-group\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f030483985a7948820ad4ebfbbf5f96cb6449473985", async() => {
                WriteLiteral("\r\n            <label>Order Line Id   :</label>\r\n            <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 626, "\"", 634, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" disabled /><br />\r\n            <label>Product Name  :</label>\r\n            <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 762, "\"", 770, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" /><br />\r\n            <label>Quantity  :</label>\r\n            <input type=\"number\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 887, "\"", 895, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" /><br />\r\n            <label>Price   :</label>\r\n            <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1008, "\"", 1016, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" disabled /><br />\r\n            <label>Order Id  :</label>\r\n            <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1140, "\"", 1148, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" disabled/><br />\r\n            <br />\r\n            <input type=\"submit\" class=\"btn btn-success\" value=\"Edit\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
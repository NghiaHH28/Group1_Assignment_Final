#pragma checksum "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b3f4a86f969badf005779e5bec48fa90ff1d8f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetails), @"mvc.1.0.view", @"/Views/Home/ProductDetails.cshtml")]
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
#line 1 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\_ViewImports.cshtml"
using G1FOOD_User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\_ViewImports.cshtml"
using G1FOOD_User.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3f4a86f969badf005779e5bec48fa90ff1d8f8", @"/Views/Home/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7247bd2c46371573bfee073826d5a3a0103f427f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.DTO.ProductDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ProductDTO</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductSalePercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductSalePercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1714, "\"", 1739, 1);
#nullable restore
#line 55 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 1720, Model.ProductImage, 1720, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1740, "\"", 1746, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width : 100px; height : 100px;\">\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b3f4a86f969badf005779e5bec48fa90ff1d8f810912", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"accountID\"");
                BeginWriteAttribute("value", " value=\"", 2154, "\"", 2201, 1);
#nullable restore
#line 67 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 2162, Context.Session.GetString("AccountID"), 2162, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"productID\"");
                BeginWriteAttribute("value", " value=\"", 2252, "\"", 2276, 1);
#nullable restore
#line 68 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 2260, Model.ProductId, 2260, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <div class=""product-detail-btn-group"">
            <button class=""btn-primary btn-change-quantity"" type=""button"" onclick=""decrement()"">-</button>
            <input class=""product-detail-quantity"" type=""text"" id=""number"" name=""quantity"" value=""1"" readonly min=""0"" max=""50"">
            <button class=""btn-primary btn-change-quantity"" type=""button"" onclick=""increment()"">+</button>
        </div>
");
#nullable restore
#line 74 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
         if (Context.Session != null && Context.Session.GetString("AccountID") != null && Context.Session.GetString("AccountID").Contains("US"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\">Add into cart</button>\r\n");
#nullable restore
#line 77 "D:\2023\[SP23]PRN211\Group1_Assignment_Final\G1FOOD_User\Views\Home\ProductDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b3f4a86f969badf005779e5bec48fa90ff1d8f814751", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script>
    function increment() {
        var numberInput = document.getElementById(""number"");
        var currentValue = parseInt(numberInput.value);
        if (currentValue < 100) {
            numberInput.value = currentValue + 1;
        }
    }
    function decrement() {
        var numberInput = document.getElementById(""number"");
        var currentValue = parseInt(numberInput.value);
        if (currentValue > 1) {
            numberInput.value = currentValue - 1;
        }
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.DTO.ProductDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
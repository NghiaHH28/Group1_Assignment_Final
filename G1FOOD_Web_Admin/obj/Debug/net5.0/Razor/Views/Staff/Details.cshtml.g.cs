#pragma checksum "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "074db8a76c9e7c4c0ba0ae44fd8d42f3da635077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Details), @"mvc.1.0.view", @"/Views/Staff/Details.cshtml")]
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
#line 1 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\_ViewImports.cshtml"
using G1FOOD_Web_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\_ViewImports.cshtml"
using G1FOOD_Web_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"074db8a76c9e7c4c0ba0ae44fd8d42f3da635077", @"/Views/Staff/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7adb123e638e0873c8de42e423f4af812b946c8f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Staff_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.DTO.AccountDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid wrapper"">
    <div class=""container-fluid container-fluid-form"">
        <div class=""wrapper-form text-left"">
            <div class=""form-heading-group"">
                <i class=""fa-solid fa-clipboard-user fa-circle""></i>
                <h2 class=""form-heading"">STAFF PROFILE</h2>
            </div>
            <div class=""form-control-group"">
                <label class=""form-text-label""> ");
#nullable restore
#line 16 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label>");
#nullable restore
#line 17 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                  Write(Html.DisplayFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\"> ");
#nullable restore
#line 20 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AccountEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label>");
#nullable restore
#line 21 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                  Write(Html.DisplayFor(model => model.AccountEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">");
#nullable restore
#line 24 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                          Write(Html.DisplayNameFor(model => model.AccountStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label> ");
#nullable restore
#line 25 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                   Write(Html.DisplayFor(model => model.AccountStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\"> ");
#nullable restore
#line 28 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label> ");
#nullable restore
#line 29 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                   Write(Html.DisplayFor(model => model.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">  ");
#nullable restore
#line 32 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                            Write(Html.DisplayNameFor(model => model.AccountAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label>");
#nullable restore
#line 33 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                  Write(Html.DisplayFor(model => model.AccountAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">");
#nullable restore
#line 36 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                          Write(Html.DisplayNameFor(model => model.AccountPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label>");
#nullable restore
#line 37 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                  Write(Html.DisplayFor(model => model.AccountPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\">");
#nullable restore
#line 40 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                          Write(Html.DisplayNameFor(model => model.AccountBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label>");
#nullable restore
#line 41 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                  Write(Html.DisplayFor(model => model.AccountBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-control-group\">\r\n                <label class=\"form-text-label\"> ");
#nullable restore
#line 44 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                                           Write(Html.DisplayNameFor(model => model.AccountStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                <label>");
#nullable restore
#line 45 "D:\2023\[SP23]PRN211\Project\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\Staff\Details.cshtml"
                  Write(Html.DisplayFor(model => model.AccountStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-btn-group\">\r\n                <button type=\"button\" name=\"button\" class=\"btn-primary\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "074db8a76c9e7c4c0ba0ae44fd8d42f3da63507710371", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.DTO.AccountDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

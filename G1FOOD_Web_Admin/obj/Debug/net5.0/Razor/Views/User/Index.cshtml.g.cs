#pragma checksum "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "671b95a132eca647e0f9942cc29aceb484fc0eb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\_ViewImports.cshtml"
using G1FOOD_Web_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\_ViewImports.cshtml"
using G1FOOD_Web_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671b95a132eca647e0f9942cc29aceb484fc0eb4", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7adb123e638e0873c8de42e423f4af812b946c8f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccess.DTO.AccountDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid wrapper"">
    <div class=""container-fluid table-container"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h6 class=""table-header"">MANAGE USER</h6>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <table class=""table table-striped text-center align-middle"">
                        <thead class=""table-heading"">
                            <tr>
                                <th class=""table-heading-text"">
                                    ");
#nullable restore
#line 22 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"table-heading-text\">\r\n                                    ");
#nullable restore
#line 25 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"table-heading-text\">\r\n                                    ");
#nullable restore
#line 28 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.AccountEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"table-heading-text\">\r\n                                    ");
#nullable restore
#line 31 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.AccountStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"table-heading-text\">Options</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"table-order\">\r\n                                        ");
#nullable restore
#line 41 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table-name\">\r\n                                        ");
#nullable restore
#line 44 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table-name\">\r\n                                        ");
#nullable restore
#line 47 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.AccountEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table-name\">\r\n                                        ");
#nullable restore
#line 50 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.AccountStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table-btn\">\r\n                                        ");
#nullable restore
#line 53 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                                   Write(Html.ActionLink("Details", "Details", new { id = item.AccountId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\PC\Documents\University\Semester_5_Spring_2023\PRN211\Group1_Assignment_Final\G1FOOD_Web_Admin\Views\User\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccess.DTO.AccountDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

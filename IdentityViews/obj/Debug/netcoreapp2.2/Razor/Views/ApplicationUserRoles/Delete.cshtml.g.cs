#pragma checksum "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUserRoles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ef86f3131559110d1877c196a0c56f86a826c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUserRoles_Delete), @"mvc.1.0.view", @"/Views/ApplicationUserRoles/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplicationUserRoles/Delete.cshtml", typeof(AspNetCore.Views_ApplicationUserRoles_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ef86f3131559110d1877c196a0c56f86a826c0", @"/Views/ApplicationUserRoles/Delete.cshtml")]
    public class Views_ApplicationUserRoles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityData.ApplicationUserRole<Guid>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUserRoles\Delete.cshtml"
      
        ViewData["Title"] = "Delete";
    

#line default
#line hidden
            BeginContext(103, 686, true);
            WriteLiteral(@"
    <h1>Delete</h1>

    <h3>Are you sure you want to delete this?</h3>
    <div>
        <h4>Application UserRole</h4>
        <hr />
        <dl class=""row""></dl>

        <form asp-action=""Delete"">
            <input type=""hidden"" asp-for=""UserId"" />
            <input type=""hidden"" asp-for=""RoleId"" />
            <table>
                <thead>
                    <tr>
                        <th>RoleName</th>
                        <th>UserName</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <label asp-for=""RoleId"" class=""control-label"">");
            EndContext();
            BeginContext(790, 14, false);
#line 28 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUserRoles\Delete.cshtml"
                                                                     Write(Model.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(804, 145, true);
            WriteLiteral("</label>\r\n                        </td>\r\n                        <td>\r\n                            <label asp-for=\"RoleId\" class=\"control-label\">");
            EndContext();
            BeginContext(950, 14, false);
#line 31 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUserRoles\Delete.cshtml"
                                                                     Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(964, 309, true);
            WriteLiteral(@"</label>
                        </td>
                        <td></td>
                    </tr>
                </tbody>
            </table>
            <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
            <a asp-action=""Index"">Back to List</a>
        </form>
    </div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityData.ApplicationUserRole<Guid>> Html { get; private set; }
    }
}
#pragma warning restore 1591
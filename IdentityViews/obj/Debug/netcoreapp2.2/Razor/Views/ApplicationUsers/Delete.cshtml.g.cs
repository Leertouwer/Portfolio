#pragma checksum "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e65d2d585c7207ceed0167a6e5b0be561db156b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUsers_Delete), @"mvc.1.0.view", @"/Views/ApplicationUsers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplicationUsers/Delete.cshtml", typeof(AspNetCore.Views_ApplicationUsers_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e65d2d585c7207ceed0167a6e5b0be561db156b", @"/Views/ApplicationUsers/Delete.cshtml")]
    public class Views_ApplicationUsers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityData.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 185, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ApplicationUser</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(267, 45, false);
#line 15 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(312, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(376, 41, false);
#line 18 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(417, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(480, 44, false);
#line 21 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(524, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(588, 40, false);
#line 24 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(628, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(691, 44, false);
#line 27 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(735, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(799, 40, false);
#line 30 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(839, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(902, 54, false);
#line 33 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
            EndContext();
            BeginContext(956, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1020, 50, false);
#line 36 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedUserName));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1133, 41, false);
#line 39 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1238, 37, false);
#line 42 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1338, 51, false);
#line 45 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1453, 47, false);
#line 48 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1563, 50, false);
#line 51 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1677, 46, false);
#line 54 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1786, 48, false);
#line 57 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1898, 44, false);
#line 60 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHash));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2005, 49, false);
#line 63 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2118, 45, false);
#line 66 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecurityStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2226, 52, false);
#line 69 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2342, 48, false);
#line 72 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2390, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2453, 47, false);
#line 75 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2500, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2564, 43, false);
#line 78 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2607, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2670, 56, false);
#line 81 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2790, 52, false);
#line 84 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2842, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2905, 52, false);
#line 87 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(2957, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3021, 48, false);
#line 90 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(3069, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3132, 46, false);
#line 93 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(3178, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3242, 42, false);
#line 96 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(3284, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3347, 50, false);
#line 99 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(3397, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3461, 46, false);
#line 102 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(3507, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3570, 53, false);
#line 105 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(3623, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3687, 49, false);
#line 108 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(3736, 254, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityData.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591

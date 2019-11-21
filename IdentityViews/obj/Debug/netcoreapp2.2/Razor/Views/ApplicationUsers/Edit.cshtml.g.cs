#pragma checksum "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a46a41631c8756c900aa62b2191635ace20433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUsers_Edit), @"mvc.1.0.view", @"/Views/ApplicationUsers/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplicationUsers/Edit.cshtml", typeof(AspNetCore.Views_ApplicationUsers_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a46a41631c8756c900aa62b2191635ace20433", @"/Views/ApplicationUsers/Edit.cshtml")]
    public class Views_ApplicationUsers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityData.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(79, 2168, true);
            WriteLiteral(@"
<h1>Edit</h1>

<h4>ApplicationUser</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""FirstName"" class=""control-label""></label>
                <input asp-for=""FirstName"" class=""form-control"" />
                <span asp-validation-for=""FirstName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LastName"" class=""control-label""></label>
                <input asp-for=""LastName"" class=""form-control"" />
                <span asp-validation-for=""LastName"" class=""text-danger""></span>
            </div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""UserName"" class=""control-label""></label>
                <input asp-for=""UserName"" class=""form-control"" />
                <s");
            WriteLiteral(@"pan asp-validation-for=""UserName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NormalizedUserName"" class=""control-label""></label>
                <input asp-for=""NormalizedUserName"" class=""form-control"" />
                <span asp-validation-for=""NormalizedUserName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NormalizedEmail"" class=""control-label""></label>
                <input asp-for=""NormalizedEmail"" class=""form-control"" />
                <span asp-validation-for=""NormalizedEmail"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
          ");
            WriteLiteral("      <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"EmailConfirmed\" /> ");
            EndContext();
            BeginContext(2248, 50, false);
#line 48 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Edit.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 1413, true);
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""PasswordHash"" class=""control-label""></label>
                <input asp-for=""PasswordHash"" class=""form-control"" />
                <span asp-validation-for=""PasswordHash"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SecurityStamp"" class=""control-label""></label>
                <input asp-for=""SecurityStamp"" class=""form-control"" />
                <span asp-validation-for=""SecurityStamp"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ConcurrencyStamp"" class=""control-label""></label>
                <input asp-for=""ConcurrencyStamp"" class=""form-control"" />
                <span asp-validation-for=""ConcurrencyStamp"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PhoneNumber"" cl");
            WriteLiteral(@"ass=""control-label""></label>
                <input asp-for=""PhoneNumber"" class=""form-control"" />
                <span asp-validation-for=""PhoneNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""PhoneNumberConfirmed"" /> ");
            EndContext();
            BeginContext(3712, 56, false);
#line 73 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Edit.cshtml"
                                                                                 Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(3768, 229, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"TwoFactorEnabled\" /> ");
            EndContext();
            BeginContext(3998, 52, false);
#line 78 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Edit.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(4050, 513, true);
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""LockoutEnd"" class=""control-label""></label>
                <input asp-for=""LockoutEnd"" class=""form-control"" />
                <span asp-validation-for=""LockoutEnd"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""LockoutEnabled"" /> ");
            EndContext();
            BeginContext(4564, 50, false);
#line 88 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Edit.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(4614, 591, true);
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""AccessFailedCount"" class=""control-label""></label>
                <input asp-for=""AccessFailedCount"" class=""form-control"" />
                <span asp-validation-for=""AccessFailedCount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5223, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 108 "C:\Users\jeroe\source\repos\core\Portfolio\IdentityViews\Views\ApplicationUsers\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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

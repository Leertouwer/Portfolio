#pragma checksum "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Tournements\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d9ec113e749f16120aea71eacc46201e09b63d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Tournements_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Tournements/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Tournements/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Tournements_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d9ec113e749f16120aea71eacc46201e09b63d", @"/Areas/Admin/Views/Tournements/Edit.cshtml")]
    public class Areas_Admin_Views_Tournements_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchaakData.Tournement>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Tournements\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 2015, true);
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Tournement</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RegistrationStartDate"" class=""control-label""></label>
                <input asp-for=""RegistrationStartDate"" class=""form-control"" />
                <span asp-validation-for=""RegistrationStartDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RegistrationEndDate"" class=""control-label""></label>
                <input asp-for=""RegistrationEndDate"" cl");
            WriteLiteral(@"ass=""form-control"" />
                <span asp-validation-for=""RegistrationEndDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TournementStartDate"" class=""control-label""></label>
                <input asp-for=""TournementStartDate"" class=""form-control"" />
                <span asp-validation-for=""TournementStartDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TournementEndDate"" class=""control-label""></label>
                <input asp-for=""TournementEndDate"" class=""form-control"" />
                <span asp-validation-for=""TournementEndDate"" class=""text-danger""></span>
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
                BeginContext(2152, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 54 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Tournements\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchaakData.Tournement> Html { get; private set; }
    }
}
#pragma warning restore 1591
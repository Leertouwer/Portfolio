#pragma checksum "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969ff995613892ebb54f7ac2b907a3c5277a5deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contestents_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contestents/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Contestents/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Contestents_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969ff995613892ebb54f7ac2b907a3c5277a5deb", @"/Areas/Admin/Views/Contestents/Index.cshtml")]
    public class Areas_Admin_Views_Contestents_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Schaak.Areas.Admin.Models.ContestentsListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(214, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(243, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969ff995613892ebb54f7ac2b907a3c5277a5deb4367", async() => {
                BeginContext(266, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(280, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(373, 44, false);
#line 17 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 46, false);
#line 20 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EnlistDate));

#line default
#line hidden
            EndContext();
            BeginContext(519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(575, 50, false);
#line 23 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TournementName));

#line default
#line hidden
            EndContext();
            BeginContext(625, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(681, 57, false);
#line 26 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RegistrationStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(738, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(794, 55, false);
#line 29 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RegistrationEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(849, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(905, 55, false);
#line 32 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TournementStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(960, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1016, 53, false);
#line 35 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TournementEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1125, 48, false);
#line 38 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TournementId));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1229, 43, false);
#line 41 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UsersId));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1407, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1468, 43, false);
#line 51 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1579, 45, false);
#line 54 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EnlistDate));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1692, 49, false);
#line 57 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TournementName));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1809, 56, false);
#line 60 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RegistrationStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1933, 54, false);
#line 63 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RegistrationEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2055, 54, false);
#line 66 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TournementStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2177, 52, false);
#line 69 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TournementEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2297, 47, false);
#line 72 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TournementId));

#line default
#line hidden
            EndContext();
            BeginContext(2344, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2412, 42, false);
#line 75 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UsersId));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2521, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969ff995613892ebb54f7ac2b907a3c5277a5deb14372", async() => {
                BeginContext(2576, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
                                           WriteLiteral(item.ContestentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2584, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2608, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969ff995613892ebb54f7ac2b907a3c5277a5deb16754", async() => {
                BeginContext(2666, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
                                              WriteLiteral(item.ContestentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2677, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2701, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969ff995613892ebb54f7ac2b907a3c5277a5deb19142", async() => {
                BeginContext(2758, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
                                             WriteLiteral(item.ContestentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2768, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 83 "C:\Users\jeroe\source\repos\core\Portfolio\SchaakViews\Areas\Admin\Views\Contestents\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2823, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Schaak.Areas.Admin.Models.ContestentsListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

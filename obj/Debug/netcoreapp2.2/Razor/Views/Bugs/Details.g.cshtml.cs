#pragma checksum "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "740ba50cb6fe9bbe2c18adb40ccde0fc113deaf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bugs_Details), @"mvc.1.0.view", @"/Views/Bugs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bugs/Details.cshtml", typeof(AspNetCore.Views_Bugs_Details))]
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
#line 1 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\_ViewImports.cshtml"
using BugReportingManagement;

#line default
#line hidden
#line 2 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\_ViewImports.cshtml"
using BugReportingManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740ba50cb6fe9bbe2c18adb40ccde0fc113deaf8", @"/Views/Bugs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ada33712a54725fcae84c3daf527cd46b7cc98f", @"/Views/_ViewImports.cshtml")]
    public class Views_Bugs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BugReportingManagement.Models.Bugs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 108, true);
            WriteLiteral("\r\n<h3>Details</h3>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(197, 48, false);
#line 13 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugCreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(245, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(309, 44, false);
#line 16 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugCreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(353, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(416, 48, false);
#line 19 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugCreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(464, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(528, 44, false);
#line 22 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugCreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(572, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(635, 47, false);
#line 25 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugClosedBy));

#line default
#line hidden
            EndContext();
            BeginContext(682, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(746, 43, false);
#line 28 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugClosedBy));

#line default
#line hidden
            EndContext();
            BeginContext(789, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(852, 47, false);
#line 31 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugClosedOn));

#line default
#line hidden
            EndContext();
            BeginContext(899, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(963, 43, false);
#line 34 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugClosedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1069, 56, false);
#line 37 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugResolutionSummary));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1189, 52, false);
#line 40 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugResolutionSummary));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1304, 46, false);
#line 43 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Attachment));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1414, 42, false);
#line 46 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Attachment));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1519, 47, false);
#line 49 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugPriority));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1630, 59, false);
#line 52 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugPriority.BugPriorityType));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1752, 45, false);
#line 55 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BugStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1861, 55, false);
#line 58 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.BugStatus.BugStatusType));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1979, 43, false);
#line 61 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2086, 44, false);
#line 64 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2177, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740ba50cb6fe9bbe2c18adb40ccde0fc113deaf812725", async() => {
                BeginContext(2247, 6, true);
                WriteLiteral("Update");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\Peter\source\repos\BugReportingManagement\BugReportingManagement\Views\Bugs\Details.cshtml"
                                                   WriteLiteral(Model.Id);

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
            BeginContext(2257, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2263, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740ba50cb6fe9bbe2c18adb40ccde0fc113deaf815174", async() => {
                BeginContext(2309, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2319, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BugReportingManagement.Models.Bugs> Html { get; private set; }
    }
}
#pragma warning restore 1591

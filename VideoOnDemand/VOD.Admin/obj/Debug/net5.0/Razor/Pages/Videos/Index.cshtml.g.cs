#pragma checksum "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d6b409592a522868b6ad2050659154776ebab8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VOD.Admin.Pages.Videos.Pages_Videos_Index), @"mvc.1.0.razor-page", @"/Pages/Videos/Index.cshtml")]
namespace VOD.Admin.Pages.Videos
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
#line 1 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\_ViewImports.cshtml"
using VOD.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\_ViewImports.cshtml"
using VOD.Common.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\_ViewImports.cshtml"
using VOD.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\_ViewImports.cshtml"
using VOD.Common.DTOModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\_ViewImports.cshtml"
using VOD.Common.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d6b409592a522868b6ad2050659154776ebab8a", @"/Pages/Videos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d51f2ab71839d97de052533220e8432022f81d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Videos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alert-type", "success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PageButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableRowButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::VOD.Admin.TagHelpers.AlertTagHelper __VOD_Admin_TagHelpers_AlertTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
  
    ViewData["Title"] = "Videos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-10 offset-md-1\" style=\"padding-left:0; padding-right:0;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("alert", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d6b409592a522868b6ad2050659154776ebab8a5518", async() => {
#nullable restore
#line 12 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
                                   Write(Model.Alert);

#line default
#line hidden
#nullable disable
            }
            );
            __VOD_Admin_TagHelpers_AlertTagHelper = CreateTagHelper<global::VOD.Admin.TagHelpers.AlertTagHelper>();
            __tagHelperExecutionContext.Add(__VOD_Admin_TagHelpers_AlertTagHelper);
            __VOD_Admin_TagHelpers_AlertTagHelper.AlertType = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-8 offset-md-2\">\r\n            <h1>");
#nullable restore
#line 18 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d6b409592a522868b6ad2050659154776ebab8a7207", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <table style=""margin-top:20px;"" class=""table"">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Course</th>
                        <th>Module</th>
                        <th>Description</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 32 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
                     foreach (var item in Model.Items)
                    {
                        var description = item.Description.Truncate(100);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Module));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"min-width:100px;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d6b409592a522868b6ad2050659154776ebab8a10425", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 40 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.ButtonDTO;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-md-1\">\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 49 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Videos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<VODUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

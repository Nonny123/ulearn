#pragma checksum "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60120dd5479e014d50a79af596958c0c243d2d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Membership_Dashboard), @"mvc.1.0.view", @"/Views/Membership/Dashboard.cshtml")]
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
#line 1 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.DTOModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.DTOModels.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI.Models.MembershipViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60120dd5479e014d50a79af596958c0c243d2d9d", @"/Views/Membership/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca705fb843df3b5685e4ef67a698b8fe0dbe332", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Membership_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CourseCardPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dashboard</h1>\r\n<hr>\r\n");
#nullable restore
#line 9 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\Dashboard.cshtml"
 foreach (var dashboardRow in Model.Courses)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\Dashboard.cshtml"
         foreach (var course in dashboardRow)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60120dd5479e014d50a79af596958c0c243d2d9d5111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = course;

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
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\Dashboard.cshtml"
                                                                      
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 18 "C:\Users\TMP11255\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\Dashboard.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

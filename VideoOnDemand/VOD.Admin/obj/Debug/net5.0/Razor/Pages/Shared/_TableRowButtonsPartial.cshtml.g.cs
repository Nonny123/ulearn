#pragma checksum "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Shared\_TableRowButtonsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc5253aa6f83bd4d74455b9875829db7153a7560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VOD.Admin.Pages.Shared.Pages_Shared__TableRowButtonsPartial), @"mvc.1.0.view", @"/Pages/Shared/_TableRowButtonsPartial.cshtml")]
namespace VOD.Admin.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5253aa6f83bd4d74455b9875829db7153a7560", @"/Pages/Shared/_TableRowButtonsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d51f2ab71839d97de052533220e8432022f81d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__TableRowButtonsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ButtonDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("icon", "close", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("icon", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::VOD.Admin.TagHelpers.BtnTagHelper __VOD_Admin_TagHelpers_BtnTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("btn", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5253aa6f83bd4d74455b9875829db7153a75605846", async() => {
            }
            );
            __VOD_Admin_TagHelpers_BtnTagHelper = CreateTagHelper<global::VOD.Admin.TagHelpers.BtnTagHelper>();
            __tagHelperExecutionContext.Add(__VOD_Admin_TagHelpers_BtnTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __VOD_Admin_TagHelpers_BtnTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __VOD_Admin_TagHelpers_BtnTagHelper.Icon = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__VOD_Admin_TagHelpers_BtnTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "VOD.Admin.TagHelpers.BtnTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Shared\_TableRowButtonsPartial.cshtml"
       WriteLiteral(Model.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Shared\_TableRowButtonsPartial.cshtml"
             WriteLiteral(Model.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["courseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseId", __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["courseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Shared\_TableRowButtonsPartial.cshtml"
             WriteLiteral(Model.ModuleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["moduleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-moduleId", __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["moduleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("btn", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5253aa6f83bd4d74455b9875829db7153a75609438", async() => {
            }
            );
            __VOD_Admin_TagHelpers_BtnTagHelper = CreateTagHelper<global::VOD.Admin.TagHelpers.BtnTagHelper>();
            __tagHelperExecutionContext.Add(__VOD_Admin_TagHelpers_BtnTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __VOD_Admin_TagHelpers_BtnTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __VOD_Admin_TagHelpers_BtnTagHelper.Icon = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__VOD_Admin_TagHelpers_BtnTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "VOD.Admin.TagHelpers.BtnTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Shared\_TableRowButtonsPartial.cshtml"
       WriteLiteral(Model.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Shared\_TableRowButtonsPartial.cshtml"
             WriteLiteral(Model.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["courseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseId", __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["courseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.Admin\Pages\Shared\_TableRowButtonsPartial.cshtml"
             WriteLiteral(Model.ModuleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["moduleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-moduleId", __VOD_Admin_TagHelpers_BtnTagHelper.RouteValues["moduleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ButtonDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591

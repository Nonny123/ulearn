#pragma checksum "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\_InstructorBioPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc2ad5f8cbfecf93200784b0cdae9211e873211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Membership__InstructorBioPartial), @"mvc.1.0.view", @"/Views/Membership/_InstructorBioPartial.cshtml")]
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
#line 1 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.DTOModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.Common.DTOModels.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\_ViewImports.cshtml"
using VOD.UI.Models.MembershipViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc2ad5f8cbfecf93200784b0cdae9211e873211", @"/Views/Membership/_InstructorBioPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca705fb843df3b5685e4ef67a698b8fe0dbe332", @"/Views/_ViewImports.cshtml")]
    public class Views_Membership__InstructorBioPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InstructorDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"instructor-bio card no-border-radius\">\r\n    <div class=\"card-body\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 117, "\"", 146, 1);
#nullable restore
#line 5 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\_InstructorBioPartial.cshtml"
WriteAttributeValue("", 123, Model.InstructorAvatar, 123, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"avatar rounded-circle\">\r\n        <h4>");
#nullable restore
#line 6 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\_InstructorBioPartial.cshtml"
       Write(Model.InstructorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h5 class=\"text-primary\">Instructor</h5>\r\n        <p>");
#nullable restore
#line 8 "C:\Users\NONSO\source\repos\ulearn\VideoOnDemand\VOD.UI\Views\Membership\_InstructorBioPartial.cshtml"
      Write(Model.InstructorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InstructorDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591

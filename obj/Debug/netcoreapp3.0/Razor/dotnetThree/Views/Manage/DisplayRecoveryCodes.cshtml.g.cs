#pragma checksum "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36241319c12cb597c5b3a317ff3e6bc3f4a37644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.dotnetThree_Views_Manage_DisplayRecoveryCodes), @"mvc.1.0.view", @"/dotnetThree/Views/Manage/DisplayRecoveryCodes.cshtml")]
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
#line 1 "C:\www\dotnetThreeOne\dotnetThree\Views\_ViewImports.cshtml"
using dotnetThree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\www\dotnetThreeOne\dotnetThree\Views\_ViewImports.cshtml"
using dotnetThree.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml"
using dotnetThree.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36241319c12cb597c5b3a317ff3e6bc3f4a37644", @"/dotnetThree/Views/Manage/DisplayRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0f5ef189d8006bb71e7faef6d6e2e8fad118b84", @"/dotnetThree/Views/_ViewImports.cshtml")]
    public class dotnetThree_Views_Manage_DisplayRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DisplayRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Your recovery codes:";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\r\n<p class=\"text-success\">");
#nullable restore
#line 9 "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml"
                   Write(ViewData["StatusMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div>\r\n    <h4>Here are your new recovery codes</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Codes:</dt>\r\n");
#nullable restore
#line 16 "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml"
         foreach (var code in Model.Codes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd>\r\n            <text>");
#nullable restore
#line 19 "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml"
             Write(code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n        </dd>\r\n");
#nullable restore
#line 21 "C:\www\dotnetThreeOne\dotnetThree\Views\Manage\DisplayRecoveryCodes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DisplayRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

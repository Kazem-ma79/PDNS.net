#pragma checksum "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7685c0ce65ba8f0984e5df62dd874c1c6a821ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PingCard), @"mvc.1.0.view", @"/Views/Shared/_PingCard.cshtml")]
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
#line 1 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\_ViewImports.cshtml"
using PDNS.net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7685c0ce65ba8f0984e5df62dd874c1c6a821ca4", @"/Views/Shared/_PingCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376c943860c5d7bff736034ee35c1de36574a994", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PingCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml"
  
    Dictionary<string, PingResult> ServerStatus = ViewBag.ServerStatus;
    foreach (var Server in ServerStatus)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card bg-dark\">\r\n            <div class=\"card-body\">\r\n                <div class=\"d-flex justify-content-between\">\r\n                    <div>\r\n                        <h5 class=\"text-muted font-weight-bold\">");
#nullable restore
#line 9 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml"
                                                           Write(Server.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <h5 class=\"text-info fw-bold\">");
#nullable restore
#line 11 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml"
                                             Write(Server.Value.Delay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ms</h5>\r\n                </div>\r\n                <div class=\"progress progress-sm\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 577, "\"", 651, 4);
            WriteAttributeValue("", 585, "progress-bar", 585, 12, true);
            WriteAttributeValue(" ", 597, "bg-warning-gradient", 598, 20, true);
            WriteAttributeValue(" ", 617, "w-", 618, 3, true);
#nullable restore
#line 14 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml"
WriteAttributeValue("", 620, Server.Value.SuccessPercentage, 620, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 671, "\"", 718, 1);
#nullable restore
#line 14 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml"
WriteAttributeValue("", 687, Server.Value.SuccessPercentage, 687, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                </div>\r\n                <div class=\"mt-1\">\r\n                    <p class=\"text-danger mb-0\">Lost ");
#nullable restore
#line 17 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml"
                                                 Write(100 - Server.Value.SuccessPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_PingCard.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

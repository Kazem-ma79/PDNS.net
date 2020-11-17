#pragma checksum "C:\Users\Kazem\source\repos\PDNS.net\PDNS.net\Views\Shared\_ThemeSwitcher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3424153130ff3f4925ee5548626bb21bda47e3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThemeSwitcher), @"mvc.1.0.view", @"/Views/Shared/_ThemeSwitcher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3424153130ff3f4925ee5548626bb21bda47e3de", @"/Views/Shared/_ThemeSwitcher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376c943860c5d7bff736034ee35c1de36574a994", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThemeSwitcher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Theme Switcher -->
<div class=""theme-panel"">
    <div class=""title text-center"">Settings</div>
    <div class=""theme-content"" data-background-color=""dark"">
        <div class=""switcher"">
            <div class=""switch-block"">
                <h4>Logo Header</h4>
                <div class=""btnSwitch"">
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""dark""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""blue""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""purple""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""light-blue""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""green""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""orange""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""red""></");
            WriteLiteral(@"button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""white""></button>
                    <br />
                    <button type=""button"" class=""selected changeLogoHeaderColor"" data-color=""dark2""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""blue2""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""purple2""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""light-blue2""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""green2""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""orange2""></button>
                    <button type=""button"" class=""changeLogoHeaderColor"" data-color=""red2""></button>
                </div>
            </div>
            <div class=""switch-block"">
                <h4>Navbar Header</h4>
                <div class=""");
            WriteLiteral(@"btnSwitch"">
                    <button type=""button"" class=""selected changeTopBarColor"" data-color=""dark""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""blue""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""purple""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""light-blue""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""green""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""orange""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""red""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""white""></button>
                    <br />
                    <button type=""button"" class=""changeTopBarColor"" data-color=""dark2""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""blue2""></");
            WriteLiteral(@"button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""purple2""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""light-blue2""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""green2""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""orange2""></button>
                    <button type=""button"" class=""changeTopBarColor"" data-color=""red2""></button>
                </div>
            </div>
            <div class=""switch-block"">
                <h4>Sidebar</h4>
                <div class=""btnSwitch"">
                    <button type=""button"" class=""changeSideBarColor"" data-color=""white""></button>
                    <button type=""button"" class=""changeSideBarColor"" data-color=""dark""></button>
                    <button type=""button"" class=""selected changeSideBarColor"" data-color=""dark2""></button>
                </div>
            </div>
       ");
            WriteLiteral(@"     <div class=""switch-block"">
                <h4>Footer</h4>
                <div class=""btnSwitch"">
                    <button type=""button"" class=""changeFooterColor"" data-color=""bg2""></button>
                    <button type=""button"" class=""changeFooterColor"" data-color=""bg1""></button>
                    <button type=""button"" class=""changeFooterColor"" data-color=""bg3""></button>
                    <button type=""button"" class=""changeFooterColor selected"" data-color=""dark""></button>
                    <button type=""button"" class=""changeFooterColor"" data-color=""dark2""></button>
                </div>
            </div>
            <div class=""switch-block"">
                <h4>Background</h4>
                <div class=""btnSwitch"">
                    <button type=""button"" class=""changeBackgroundColor"" data-color=""bg2""></button>
                    <button type=""button"" class=""changeBackgroundColor"" data-color=""bg1""></button>
                    <button type=""button"" class=""changeBackgrou");
            WriteLiteral(@"ndColor"" data-color=""bg3""></button>
                    <button type=""button"" class=""selected changeBackgroundColor"" data-color=""dark""></button>
                </div>
            </div>
            <div class=""switch-block"">
                <h4>Theme Switcher</h4>
                <div class=""btnSwitch"">
                    <button type=""button"" class=""changeTSwitchColor"" data-color=""bg2""></button>
                    <button type=""button"" class=""changeTSwitchColor"" data-color=""bg1""></button>
                    <button type=""button"" class=""changeTSwitchColor"" data-color=""bg3""></button>
                    <button type=""button"" class=""selected changeTSwitchColor"" data-color=""dark""></button>
                </div>
            </div>
        </div>
    </div>
    <div class=""theme-toggle"">
        <i class=""flaticon-settings""></i>
    </div>
</div>
<!-- End Theme Switcher -->");
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

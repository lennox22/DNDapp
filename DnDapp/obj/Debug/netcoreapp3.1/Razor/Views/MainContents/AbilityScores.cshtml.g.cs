#pragma checksum "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\MainContents\AbilityScores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbe208b99bc195eb5511696f56e8e22372c55a94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainContents_AbilityScores), @"mvc.1.0.view", @"/Views/MainContents/AbilityScores.cshtml")]
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
#line 1 "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\_ViewImports.cshtml"
using DnDapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\_ViewImports.cshtml"
using DnDapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe208b99bc195eb5511696f56e8e22372c55a94", @"/Views/MainContents/AbilityScores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b24f054eb1d403fd9e57b16ca4f46af6e8e866", @"/Views/_ViewImports.cshtml")]
    public class Views_MainContents_AbilityScores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AbilityScores>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\MainContents\AbilityScores.cshtml"
  
    ViewData["Title"] = "AbilityScores";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ability Scores</h1>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\MainContents\AbilityScores.cshtml"
 foreach (Result menu in Model.results)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 164, "\"", 210, 2);
            WriteAttributeValue("", 171, "/", 171, 1, true);
#nullable restore
#line 11 "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\MainContents\AbilityScores.cshtml"
WriteAttributeValue("", 172, menu.url.Remove(0,5).Replace("-", ""), 172, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\MainContents\AbilityScores.cshtml"
                                                 Write(menu.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    <br />\r\n");
#nullable restore
#line 13 "C:\Users\lbrown4\dev\BreakWeek2\DnDapp\Views\MainContents\AbilityScores.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AbilityScores> Html { get; private set; }
    }
}
#pragma warning restore 1591

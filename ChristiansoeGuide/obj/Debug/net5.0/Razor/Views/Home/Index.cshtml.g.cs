#pragma checksum "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bfd0d7afed05f1decc2fbea1ede6e61b4e8bd37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\_ViewImports.cshtml"
using ChristiansoeGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\_ViewImports.cshtml"
using ChristiansoeGuide.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bfd0d7afed05f1decc2fbea1ede6e61b4e8bd37", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff90cfc4654ca3236bca0105c902954465f34c2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Startside";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bfd0d7afed05f1decc2fbea1ede6e61b4e8bd373327", async() => {
                WriteLiteral("\r\n\r\n<div class=\"højre-div\">\r\n    <div class=\"next-ferry-div\">\r\n");
#nullable restore
#line 9 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\Index.cshtml"
          
            var timeToNextFerry = ViewBag.Message;
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h4>Næste færge går om:</h4>\r\n        <p>");
#nullable restore
#line 13 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\Index.cshtml"
      Write(timeToNextFerry);

#line default
#line hidden
#nullable disable
                WriteLiteral(" timer</p>\r\n    </div>\r\n    <table>\r\n        <h2>Færge tider</h2>\r\n        <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\Index.cshtml"
          
            foreach (var Data in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\Index.cshtml"
                   Write(Data.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""venstre-div"">
    <h2>Velkommen til Christiansø Turist Guide</h2>
    <p>
        Christiansø er del af øgruppen Ertholmene.
        Øgruppen er ejet af den danske stat og hører under Forsvarsministeriet.
        Den ligger ca. 20 km nordøst for Bornholm og består af de to beboede øer Christiansø og Frederiksø,
        fuglereservatet Græsholm og et antal større og mindre klippeskær.
        Alt er totalfredet, både fæstning, natur og dyreliv. Der bor i dag ca. 90 mennesker på øerne.
    </p>
    <img class=""map"" src=""image/map.png"" alt=""Kort ikke findet"">
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

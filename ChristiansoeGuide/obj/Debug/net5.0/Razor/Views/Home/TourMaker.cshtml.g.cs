#pragma checksum "C:\Niko\SynologyDrive\Labtop\semester4\Rider\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfbafad0ac1652646124c5d1d3fd068c1e7aad1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TourMaker), @"mvc.1.0.view", @"/Views/Home/TourMaker.cshtml")]
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
#line 1 "C:\Niko\SynologyDrive\Labtop\semester4\Rider\ChristiansoeGuide\ChristiansoeGuide\Views\_ViewImports.cshtml"
using ChristiansoeGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Niko\SynologyDrive\Labtop\semester4\Rider\ChristiansoeGuide\ChristiansoeGuide\Views\_ViewImports.cshtml"
using ChristiansoeGuide.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfbafad0ac1652646124c5d1d3fd068c1e7aad1f", @"/Views/Home/TourMaker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff90cfc4654ca3236bca0105c902954465f34c2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TourMaker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Niko\SynologyDrive\Labtop\semester4\Rider\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
  
    ViewData["Title"] = "Toue Maker";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    $(document).ready(function(){
        $("".andeDam"").on(""click"", function(){
            alert('test');
        });
        $("".FroeDam"").on(""click"", function(){
            alert('test');
        });
        $("".DamDam"").on(""click"", function(){
            alert('test');
        });
    });
</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfbafad0ac1652646124c5d1d3fd068c1e7aad1f3845", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Lav din egen tur her</h1>
        <img src=""../image/map.png"" alt=""Kort ikke findet"" usemap=""#tourmap"">
        <map name=""tourmap"">
            <area class=""andeDam"" shape=""circle"" coords=""10,10,100""");
                BeginWriteAttribute("href", " href=\"", 736, "\"", 743, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <area class=\"FroeDam\" shape=\"circle\" coords=\"290,172,50\"");
                BeginWriteAttribute("href", " href=\"", 815, "\"", 822, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <area class=\"DamDam\" shape=\"circle\" coords=\"337,300,50\"");
                BeginWriteAttribute("href", " href=\"", 893, "\"", 900, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </map>\r\n    </div>\r\n");
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

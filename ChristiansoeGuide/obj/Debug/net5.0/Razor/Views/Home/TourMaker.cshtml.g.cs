#pragma checksum "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "836253936f9be0aebe872c8e93fdf2ae85fe0ac5"
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
#line 1 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/_ViewImports.cshtml"
using ChristiansoeGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/_ViewImports.cshtml"
using ChristiansoeGuide.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836253936f9be0aebe872c8e93fdf2ae85fe0ac5", @"/Views/Home/TourMaker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e65415fb3e0bb0b0211c57bd08be8dc372987047", @"/Views/_ViewImports.cshtml")]
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
#line 1 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
  
    ViewData["Title"] = "Tur laveren";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\n\n<script>\n    $(document).ready(function(){\n        $(\".andeDam\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 9 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("xy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {str: \"andedam\"},\n            });\n        });\n        $(\".FroeDam\").on(\"click\", function(){\n            alert(\'test\');\n        });\n        $(\".DamDam\").on(\"click\", function(){\n            alert(\'test\');\n        });\n    });\n</script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "836253936f9be0aebe872c8e93fdf2ae85fe0ac54087", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Lav din egen tur her</h1>
        <img src=""../image/map.png"" alt=""Kort ikke findet"" usemap=""#tourmap"">
        <map name=""tourmap"">
            <area class=""andeDam"" shape=""circle"" coords=""10,10,100""");
                BeginWriteAttribute("href", " href=\"", 788, "\"", 795, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"FroeDam\" shape=\"circle\" coords=\"290,172,50\"");
                BeginWriteAttribute("href", " href=\"", 866, "\"", 873, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"DamDam\" shape=\"circle\" coords=\"337,300,50\"");
                BeginWriteAttribute("href", " href=\"", 943, "\"", 950, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        </map>\n    </div>\n");
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

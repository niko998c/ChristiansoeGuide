#pragma checksum "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c8c85cebcb92880c201ebed34321079379cbee5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c85cebcb92880c201ebed34321079379cbee5", @"/Views/Home/TourMaker.cshtml")]
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
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\n\n<script>\n    $(document).ready(function(){\n        $(\".Færgen\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 9 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Færgen\", tmpX: 440, tmpY: 490}});\n            return false;\n        });\n        $(\".LilleTårn\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 13 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Lille Tårn\", tmpX: 230 , tmpY: 255}});\n            return false;\n        });\n        $(\".Fængsel\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 17 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Fængsel\", tmpX: 312, tmpY: 615}});\n            return false;\n        });\n        $(\".HesteHytten\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 21 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Heste Hytten\", tmpX: 582, tmpY: 224}});\n            return false;\n        });\n        $(\".GlasShop\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 25 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Glas Shop\", tmpX: 501, tmpY: 654}});\n            return false;\n        });\n        $(\".HertugindensBastion\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 29 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Hertugindens Bastion\", tmpX: 792, tmpY: 300}});\n            return false;\n        });\n        $(\".StoreBrønd\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 33 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Store Brønd\", tmpX: 792, tmpY: 714}});\n            return false;\n        });\n        $(\".VerdensEnde\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 37 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Verdens Ende\", tmpX: 930, tmpY: 118}});\n            return false;\n        });\n        $(\".ØsteligePunkt\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 41 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Danmarks Østelige Punkt\", tmpX: 1113, tmpY: 572}});\n            return false;\n        });\n        $(\".KongensBastion\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 45 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Kongens Bastion\", tmpX: 680, tmpY: 962}});\n            return false;\n        });\n        $(\".StoreTårn\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 49 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Store Tårn\", tmpX: 369, tmpY: 343}});\n            return false;\n        });\n        \n        $(\".clearTourButton\").on(\"click\", function(){\n            $.ajax({url: \'");
#nullable restore
#line 54 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                     Write(Url.Action("ClearTour"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\'});\n            return false;\n        });\n        \n    });\n</script>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c8c85cebcb92880c201ebed34321079379cbee59116", async() => {
                WriteLiteral("\n    <div class=\"højre-div\">\n        <h2>Her er din rute</h2>\n        <table>\n            <tbody>\n");
#nullable restore
#line 66 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
              
                foreach (var Data in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 70 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                       Write(Data.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                    </tr>\n");
#nullable restore
#line 72 "/Users/adamkanstruphviid/OneDrive/KEA/C#/ChristiansoeGuide/ChristiansoeGuide/Views/Home/TourMaker.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
        <button type=""button"" class=""clearTourButton"">Ryd Tour</button>
    </div>

    <div class=""venstre-div"">
        <h2>Lav din egen tur på øen</h2>
        <p>tryk på de seværdigheder du vil til, resten ordner vi ;)</p>
        <img class=""tour-map"" src=""../image/mapWithPins.png"" alt=""Kort ikke findet"" usemap=""#tourmap"">
        <map name=""tourmap"">
            <area class=""Færgen"" shape=""circle"" coords=""308, 343, 30"" href=""#"">
            <area class=""LilleTårn"" shape=""circle"" coords=""161, 178, 30"" href=""#"">
            <area class=""Fængsel"" shape=""circle"" coords=""218, 430, 30"" href=""#"">
            <area class=""HesteHytten"" shape=""circle"" coords=""407, 156, 30"" href=""#"">
            <area class=""StoreTårn"" shape=""circle"" coords=""369, 343, 30""");
                BeginWriteAttribute("href", " href=\"", 3897, "\"", 3904, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"GlasShop\" shape=\"circle\" coords=\"350, 457, 30\"");
                BeginWriteAttribute("href", " href=\"", 3978, "\"", 3985, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"HertugindensBastion\" shape=\"circle\" coords=\"554, 210, 30\"");
                BeginWriteAttribute("href", " href=\"", 4070, "\"", 4077, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"StoreBrønd\" shape=\"circle\" coords=\"554, 499, 30\"");
                BeginWriteAttribute("href", " href=\"", 4153, "\"", 4160, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"VerdensEnde\" shape=\"circle\" coords=\"651, 82, 30\"");
                BeginWriteAttribute("href", " href=\"", 4236, "\"", 4243, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"ØsteligePunkt\" shape=\"circle\" coords=\"770, 400, 30\"");
                BeginWriteAttribute("href", " href=\"", 4322, "\"", 4329, 0);
                EndWriteAttribute();
                WriteLiteral(">\n            <area class=\"KongensBastion\" shape=\"circle\" coords=\"476, 673, 30\"");
                BeginWriteAttribute("href", " href=\"", 4409, "\"", 4416, 0);
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

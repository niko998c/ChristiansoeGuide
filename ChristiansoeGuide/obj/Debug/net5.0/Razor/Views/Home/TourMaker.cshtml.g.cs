#pragma checksum "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1500e41c91fa6f691a4fcf3778b17a79edbdc770"
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
#line 1 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\_ViewImports.cshtml"
using ChristiansoeGuide;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1500e41c91fa6f691a4fcf3778b17a79edbdc770", @"/Views/Home/TourMaker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c1223c3dadc0c4f80eea8b3fce7dc9a494a5dcb", @"/Views/_ViewImports.cshtml")]
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
#line 1 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
  
    ViewData["Title"] = "Tur laveren";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n\r\n<script>\r\n    $(document).ready(function(){\r\n        $(\".Færgen\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 9 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Færgen\", tmpX: 308, tmpY: 343}});\r\n        });\r\n        $(\".LilleTårn\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 12 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Lille Tårn\", tmpX: 161 , tmpY: 178}});\r\n        });\r\n        $(\".Fængsel\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 15 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Fængsel\", tmpX: 218, tmpY: 430}});\r\n        });\r\n        $(\".HesteHytten\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 18 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Heste Hytten\", tmpX: 407, tmpY: 156}});\r\n        });\r\n        $(\".GlasShop\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 21 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Glas Shop\", tmpX: 350, tmpY: 457}});\r\n        });\r\n        $(\".HertugindensBastion\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 24 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Hertugindens Bastion\", tmpX: 554, tmpY: 210}});\r\n        });\r\n        $(\".StoreBrønd\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 27 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Store Brønd\", tmpX: 554, tmpY: 499}});\r\n        });\r\n        $(\".VerdensEnde\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 30 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Verdens Ende\", tmpX: 651, tmpY: 82}});\r\n        });\r\n        $(\".ØsteligePunkt\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 33 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Danmarks Østelige Punkt\", tmpX: 770, tmpY: 400}});\r\n        });\r\n        $(\".KongensBastion\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 36 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Kongens Bastion\", tmpX: 476, tmpY: 673}});\r\n        });\r\n        $(\".StoreTårn\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 39 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("AddTourToDatabase"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'GET\', data: {tmpName: \"Store Tårn\", tmpX: 369, tmpY: 343}});\r\n        });\r\n        \r\n        $(\".clearTourButton\").on(\"click\", function(){\r\n            $.ajax({url: \'");
#nullable restore
#line 43 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                     Write(Url.Action("ClearTour"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', type: \'POST\'});\r\n            location.reload();\r\n        });\r\n    }); \r\n</script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1500e41c91fa6f691a4fcf3778b17a79edbdc7708669", async() => {
                WriteLiteral("\r\n    <div class=\"højre-div\">\r\n        <h2>Her er din rute</h2>\r\n        <table class=\"table table-striped\">\r\n            <tbody>\r\n");
#nullable restore
#line 54 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
              
                foreach (string Data in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                       Write(Data);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "C:\Users\hviid\RiderProjects\ChristiansoeGuide\ChristiansoeGuide\Views\Home\TourMaker.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
        <button type=""button"" class=""btn btn-success clearTourButton"">Ryd Tur</button>
    </div>

    <div class=""venstre-div"">
        <h2>Lav din egen tur på øen</h2>
        <p>
            Tryk på de seværdigheder du vil til, resten ordner vi!<br>
            Vi anbefaler en tur på 20 minutter, hvor det sidste punkt er færgen
        </p>
        <img class=""tour-map"" src=""../image/mapWithPins.png"" alt=""Kort ikke findet"" usemap=""#tourmap"">
        <map name=""tourmap"">
            <area class=""Færgen"" shape=""circle"" coords=""308, 343, 30""");
                BeginWriteAttribute("href", " href=\"", 3488, "\"", 3495, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Færgen\">\r\n            <area class=\"LilleTårn\" shape=\"circle\" coords=\"161, 178, 30\"");
                BeginWriteAttribute("href", " href=\"", 3608, "\"", 3615, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Lille Tårn\">\r\n            <area class=\"Fængsel\" shape=\"circle\" coords=\"218, 430, 30\"");
                BeginWriteAttribute("href", " href=\"", 3730, "\"", 3737, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Fængsel\">\r\n            <area class=\"HesteHytten\" shape=\"circle\" coords=\"407, 156, 30\"");
                BeginWriteAttribute("href", " href=\"", 3853, "\"", 3860, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Heste Hytten\">\r\n            <area class=\"StoreTårn\" shape=\"circle\" coords=\"369, 343, 30\"");
                BeginWriteAttribute("href", " href=\"", 3979, "\"", 3986, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Store Tårn\">\r\n            <area class=\"GlasShop\" shape=\"circle\" coords=\"350, 457, 30\"");
                BeginWriteAttribute("href", " href=\"", 4102, "\"", 4109, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Glas Shop\">\r\n            <area class=\"HertugindensBastion\" shape=\"circle\" coords=\"554, 210, 30\"");
                BeginWriteAttribute("href", " href=\"", 4235, "\"", 4242, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Hertugindens Bastion\">\r\n            <area class=\"StoreBrønd\" shape=\"circle\" coords=\"554, 499, 30\"");
                BeginWriteAttribute("href", " href=\"", 4370, "\"", 4377, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Store Brønd\">\r\n            <area class=\"VerdensEnde\" shape=\"circle\" coords=\"651, 82, 30\"");
                BeginWriteAttribute("href", " href=\"", 4496, "\"", 4503, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Verdenens Ende\">\r\n            <area class=\"ØsteligePunkt\" shape=\"circle\" coords=\"770, 400, 30\"");
                BeginWriteAttribute("href", " href=\"", 4628, "\"", 4635, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Østelige Punkt\">\r\n            <area class=\"KongensBastion\" shape=\"circle\" coords=\"476, 673, 30\"");
                BeginWriteAttribute("href", " href=\"", 4761, "\"", 4768, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" title=\"Kongens Bastion\">\r\n        </map>\r\n    </div>\r\n");
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

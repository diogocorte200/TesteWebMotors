#pragma checksum "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182001f18db6c5f65cafde61816c65d8f07ac86e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CriaAnuncio), @"mvc.1.0.view", @"/Views/Home/CriaAnuncio.cshtml")]
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
#line 1 "C:\TesteWebMotors\TesteWebMotors.UI\Views\_ViewImports.cshtml"
using TesteWebMotors.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TesteWebMotors\TesteWebMotors.UI\Views\_ViewImports.cshtml"
using TesteWebMotors.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182001f18db6c5f65cafde61816c65d8f07ac86e", @"/Views/Home/CriaAnuncio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61e81dbc8d14aec363235152e5b787ee4dd1d8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CriaAnuncio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteWebMotors.Domain.Domain.AnuncionWebMotorsModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
  
    ViewBag.Title = "Cria Anuncio";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Cria Anuncio</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182001f18db6c5f65cafde61816c65d8f07ac86e3311", async() => {
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
 using (Html.BeginForm("Create","Home"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset>\r\n    <legend>Anuncio Model</legend>\r\n\r\n    <div class=\"editor-label\">");
#nullable restore
#line 16 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                         Write(Html.LabelFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">\r\n");
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.DropDownList("Marca", (IEnumerable<SelectListItem>)ViewBag.Marcas, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    </div>\r\n\r\n    <div class=\"editor-label\">");
#nullable restore
#line 26 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                         Write(Html.LabelFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 28 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.DropDownList("Modelo", new SelectList(""), "-- Selecione Modelo --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <div class=\"editor-label\">");
#nullable restore
#line 34 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                         Write(Html.LabelFor(model => model.Versao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 36 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.DropDownList("Versao", new SelectList(""), "-- Selecione Versão --", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    <div class=\"editor-label\">");
#nullable restore
#line 41 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                         Write(Html.LabelFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 43 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.EditorFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.ValidationMessageFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">");
#nullable restore
#line 47 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                         Write(Html.LabelFor(model => model.Quilometragem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 49 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.EditorFor(model => model.Quilometragem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 50 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.ValidationMessageFor(model => model.Quilometragem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"editor-label\">");
#nullable restore
#line 53 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                         Write(Html.LabelFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"editor-field\">\r\n        ");
#nullable restore
#line 55 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.EditorFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 56 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
   Write(Html.ValidationMessageFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <p>\r\n        <input type=\"submit\" value=\"Create\" />\r\n    </p>\r\n</fieldset>\r\n");
#nullable restore
#line 63 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 65 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>



<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<script type=""text/javascript"">
 $(function(){

     $(""#Marca"").change(function() {

            var t = $(this).val();

            if (t !== """") {
                $.post(""");
#nullable restore
#line 80 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                   Write(Url.Action("GetModels", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?val="" + t, function (res) {
                    $(""#Modelo"").empty();
                    $(""#Versao"").empty();
                    $(""#Modelo"").append(res);
                    //if (res.Success === ""true"") {
                    //    debugger
                    //  //enable the text boxes and set the value
                    //    alert(""Fucnionou!"");
                    //    $(""#Modelos"").empty();
                    //    /$(""#Modelos"").append(res);
                    //    //$(""#Width"").prop('disabled', false).val(res.Data.Width);
                    //    //$(""#Height"").prop('disabled', false).val(res.Data.Height);

                    //} else {
                    //    alert(res);
                    //    alert(""Error getting data!"");
                    //}
                });
            } else {
                //Let's clear the values and disable :)
                alert(""ELSESEEE Fucnionou!"");
                /*$(""input.editableItems"").val('').prop('disabled', true);*/");
            WriteLiteral("\r\n            }\r\n\r\n     });\r\n     $(\"#Modelo\").change(function() {\r\n\r\n            var t = $(this).val();\r\n\r\n            if (t !== \"\") {\r\n                $.post(\"");
#nullable restore
#line 110 "C:\TesteWebMotors\TesteWebMotors.UI\Views\Home\CriaAnuncio.cshtml"
                   Write(Url.Action("GetVersoes", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?val="" + t, function (res) {
                    $(""#Versao"").empty();
                    $(""#Versao"").append(res);
                    //if (res.Success === ""true"") {
                    //    debugger
                    //  //enable the text boxes and set the value
                    //    alert(""Fucnionou!"");
                    //    $(""#Modelos"").empty();
                    //    /$(""#Modelos"").append(res);
                    //    //$(""#Width"").prop('disabled', false).val(res.Data.Width);
                    //    //$(""#Height"").prop('disabled', false).val(res.Data.Height);

                    //} else {
                    //    alert(res);
                    //    alert(""Error getting data!"");
                    //}
                });
            } else {
                //Let's clear the values and disable :)
                alert(""ELSESEEE Fucnionou!"");
                /*$(""input.editableItems"").val('').prop('disabled', true);*/
            }

        });
 });

</s");
            WriteLiteral("cript>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteWebMotors.Domain.Domain.AnuncionWebMotorsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

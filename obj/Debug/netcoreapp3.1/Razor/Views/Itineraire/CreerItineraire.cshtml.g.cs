#pragma checksum "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be1338334d5920bc19a8a18ab9f8c0f39ea6b4a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Itineraire_CreerItineraire), @"mvc.1.0.view", @"/Views/Itineraire/CreerItineraire.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1338334d5920bc19a8a18ab9f8c0f39ea6b4a9", @"/Views/Itineraire/CreerItineraire.cshtml")]
    #nullable restore
    public class Views_Itineraire_CreerItineraire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodeVoyage.Models.Itineraire>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
  
    ViewBag.Title = "Formulaire";
    Layout = "_LayoutDuSite";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be1338334d5920bc19a8a18ab9f8c0f39ea6b4a93157", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>CréerItineraire</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be1338334d5920bc19a8a18ab9f8c0f39ea6b4a94218", async() => {
                WriteLiteral("\n");
#nullable restore
#line 15 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <fieldset>\n            <legend>Créer un itinéraire: </legend>\n            ");
#nullable restore
#line 19 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.LabelFor(m => Model.LieuDepart));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 20 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.TextBoxFor(m => Model.LieuDepart));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("            <br />\n            ");
#nullable restore
#line 23 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.LabelFor(m => Model.Destination));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 24 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.TextBoxFor(m => Model.Destination));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("            <br />\n            ");
#nullable restore
#line 27 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.LabelFor(m => Model.Prix));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 28 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.TextBoxFor(m => Model.Prix));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("            <br />\n            ");
#nullable restore
#line 31 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.LabelFor(m => Model.Transport));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 32 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.DropDownListFor(m => m.Transport, Html.GetEnumSelectList<CodeVoyage.Models.MoyenDeTransport>(), "Selectionner un transport"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n          \n");
                WriteLiteral("            <br/>\n            ");
#nullable restore
#line 36 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.LabelFor(m => Model.NombreVoyageur));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 37 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.TextBoxFor(m => Model.NombreVoyageur));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("            <br />\n            ");
#nullable restore
#line 40 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.LabelFor(m => Model.DateDepart ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 41 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.TextBoxFor(m => Model.DateDepart, new { type="date"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("            <br />\n            ");
#nullable restore
#line 44 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.LabelFor(m => Model.DateArrivee));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
#nullable restore
#line 45 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.TextBoxFor(m => Model.DateArrivee , new { type="date"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
                WriteLiteral("            <br />\n\n            <input type=\"submit\" value=\"Ajouter\" />\n        </fieldset>\n");
#nullable restore
#line 51 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
            DefineSection("Menu", async() => {
                WriteLiteral("\n    <ul>\n        <li>");
#nullable restore
#line 55 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
       Write(Html.ActionLink("Accueil", "Index","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n        <li class=\"selectionne\">");
#nullable restore
#line 56 "D:\TELECHARGEMENTS\c sharp renaud isika\HTML ISIKA\Projet2\CodeVoyage\Views\Itineraire\CreerItineraire.cshtml"
                           Write(Html.ActionLink("Ajout d'itineraire", "CreerItineraire", "Itineraire"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n\n\n    </ul>\n");
            }
            );
            WriteLiteral("</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CodeVoyage.Models.Itineraire> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7788dffb3121be75868a981366274a70e6ca0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_ModifierService), @"mvc.1.0.view", @"/Views/Service/ModifierService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc7788dffb3121be75868a981366274a70e6ca0b", @"/Views/Service/ModifierService.cshtml")]
    #nullable restore
    public class Views_Service_ModifierService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodeVoyage.Models.Service>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate-vsdoc.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
  
    ViewBag.Title = "Formulaire";
    Layout = "_LayoutDuSite";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7788dffb3121be75868a981366274a70e6ca0b4708", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ModifierService</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7788dffb3121be75868a981366274a70e6ca0b5777", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <fieldset>\r\n            <legend>Modifier un service: </legend>\r\n            ");
#nullable restore
#line 17 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.LabelFor(m => Model.nomService));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.TextBoxFor(m => Model.nomService));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 19 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ValidationMessageFor(m => Model.nomService));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 21 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.LabelFor(m => Model.TypeService));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.TextBoxFor(m => Model.TypeService));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 23 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ValidationMessageFor(m => Model.TypeService));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 25 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.LabelFor(m => Model.Capacite));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 26 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.TextBoxFor(m => Model.Capacite));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 27 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ValidationMessageFor(m => Model.Capacite));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 29 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.LabelFor(m => Model.DateDeb));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 30 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.TextBoxFor(m => Model.DateDeb, new { type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 31 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ValidationMessageFor(m => Model.DateDeb));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 33 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.LabelFor(m => Model.DateFin));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 34 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.TextBoxFor(m => Model.DateFin, new { type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 35 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ValidationMessageFor(m => Model.DateFin));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 37 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.LabelFor(m => Model.Prix));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 38 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.TextBoxFor(m => Model.Prix));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 39 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ValidationMessageFor(m => Model.Prix));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Modifier\" />\r\n        </fieldset>\r\n");
#nullable restore
#line 42 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"

        
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7788dffb3121be75868a981366274a70e6ca0b11918", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7788dffb3121be75868a981366274a70e6ca0b13105", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7788dffb3121be75868a981366274a70e6ca0b14292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            DefineSection("Menu", async() => {
                WriteLiteral("\r\n    <ul>\r\n        <li>");
#nullable restore
#line 51 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ActionLink("Accueil", "Index","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 52 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
       Write(Html.ActionLink("Ajout de service", "CreerService", "Service"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        <li class=\"selectionne\">");
#nullable restore
#line 53 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
                           Write(Html.ActionLink("Modification de service", "ModifierService", "Service"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 54 "D:\Users\Stagiaite\source\repos\gitrepertoire2\CodeVoyage\Views\Service\ModifierService.cshtml"
   Write(Html.ActionLink("Ajout d'Evenement", "CreerEvenement", "Evenement"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n\r\n    </ul>\r\n");
            }
            );
            WriteLiteral("</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CodeVoyage.Models.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

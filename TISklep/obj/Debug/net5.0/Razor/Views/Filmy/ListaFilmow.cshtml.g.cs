#pragma checksum "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f219f759e36a2795e1bdafb0fc45b431565347f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_ListaFilmow), @"mvc.1.0.view", @"/Views/Filmy/ListaFilmow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f219f759e36a2795e1bdafb0fc45b431565347f", @"/Views/Filmy/ListaFilmow.cshtml")]
    public class Views_Filmy_ListaFilmow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TISklep.ViewModels.KategoriaViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
  
    ViewData["Title"] = "Lista z kategorii";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table>\n    <tr class=\"banner\">\n");
#nullable restore
#line 8 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
         foreach (var film in Model.FilmyTop3Najnowsze)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class=\"film\">\n                <h3>");
#nullable restore
#line 11 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
               Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f219f759e36a2795e1bdafb0fc45b431565347f3300", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 287, "~/content/", 287, 10, true);
#nullable restore
#line 12 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
AddHtmlAttributeValue("", 297, film.Plakat, 297, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <p>");
#nullable restore
#line 13 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
              Write(film.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </td>\n");
#nullable restore
#line 15 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n</table>\n\n<h1>");
#nullable restore
#line 19 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
Write(Model.Kategoria.Nazwa);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 19 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
                        Write(Model.Kategoria.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Tytuł filmu</th>\n            <th>Reżyser</th>\n            <th>Data dodania</th>\n            <th>Cena</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 30 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
         foreach (var film in Model.FilmyKategorii)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 33 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
               Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 34 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
               Write(film.Rezyser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 35 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
               Write(film.DataDodania);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 36 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
               Write(film.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 937, "\"", 1004, 1);
#nullable restore
#line 38 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
WriteAttributeValue("", 944, Url.Action("Szczegoly", "Filmy", new { idFilmu = film.Id }), 944, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&#128270;</a>\n                </td>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1158, 1);
#nullable restore
#line 41 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
WriteAttributeValue("", 1092, Url.Action("DodajDoKoszyka", "Koszyk", new { idFilmu = film.Id }), 1092, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        &#128722;\n                    </a>\n                </td>\n            </tr>\n");
#nullable restore
#line 46 "F:\TISklep\TISklep\Views\Filmy\ListaFilmow.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TISklep.ViewModels.KategoriaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

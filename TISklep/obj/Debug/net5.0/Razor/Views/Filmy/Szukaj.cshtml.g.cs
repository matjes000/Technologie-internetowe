#pragma checksum "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e70b01be4c48a2d174782dbf249dd11656e3391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmy_Szukaj), @"mvc.1.0.view", @"/Views/Filmy/Szukaj.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e70b01be4c48a2d174782dbf249dd11656e3391", @"/Views/Filmy/Szukaj.cshtml")]
    public class Views_Filmy_Szukaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TISklep.Models.Film>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h3>Filmy zawierające frazę: ");
#nullable restore
#line 3 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
                        Write(ViewBag.szukanie);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Tytuł filmu</th>\n            <th>Reżyser</th>\n            <th>Data dodania</th>\n            <th>Cena</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 15 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
         foreach (var film in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 18 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
               Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 19 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
               Write(film.Rezyser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
               Write(film.DataDodania);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
               Write(film.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 565, "\"", 632, 1);
#nullable restore
#line 23 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
WriteAttributeValue("", 572, Url.Action("Szczegoly", "Filmy", new { idFilmu = film.Id }), 572, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&#128270;</a>\n                </td>\n            </tr>\n");
#nullable restore
#line 26 "F:\TISklep\TISklep\Views\Filmy\Szukaj.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TISklep.Models.Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
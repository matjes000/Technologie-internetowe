#pragma checksum "F:\TISklep\TISklep\Views\Shared\Components\FilmyKategorii\_FilmyKategorii.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a4c3ee65bdea3f2179b816db10e24e13d1fe6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FilmyKategorii__FilmyKategorii), @"mvc.1.0.view", @"/Views/Shared/Components/FilmyKategorii/_FilmyKategorii.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a4c3ee65bdea3f2179b816db10e24e13d1fe6e", @"/Views/Shared/Components/FilmyKategorii/_FilmyKategorii.cshtml")]
    public class Views_Shared_Components_FilmyKategorii__FilmyKategorii : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TISklep.Models.Film>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<ul>\n");
#nullable restore
#line 4 "F:\TISklep\TISklep\Views\Shared\Components\FilmyKategorii\_FilmyKategorii.cshtml"
     foreach (var film in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 99, "\"", 166, 1);
#nullable restore
#line 6 "F:\TISklep\TISklep\Views\Shared\Components\FilmyKategorii\_FilmyKategorii.cshtml"
WriteAttributeValue("", 106, Url.Action("Szczegoly", "Filmy", new { idFilmu = film.Id }), 106, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 6 "F:\TISklep\TISklep\Views\Shared\Components\FilmyKategorii\_FilmyKategorii.cshtml"
                                                                               Write(film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 7 "F:\TISklep\TISklep\Views\Shared\Components\FilmyKategorii\_FilmyKategorii.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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

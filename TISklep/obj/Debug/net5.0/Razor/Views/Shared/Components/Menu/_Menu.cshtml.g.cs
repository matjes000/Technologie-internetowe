#pragma checksum "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd40e45a8fd00181acf972e29c1c0e5a4b9b6e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu__Menu), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/_Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd40e45a8fd00181acf972e29c1c0e5a4b9b6e39", @"/Views/Shared/Components/Menu/_Menu.cshtml")]
    public class Views_Shared_Components_Menu__Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TISklep.Models.Kategoria>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<header class=\"menu-bar\">\n    <div id=\"menu\">\n");
#nullable restore
#line 7 "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml"
         foreach (var kategoria in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 163, "\"", 247, 1);
#nullable restore
#line 9 "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml"
WriteAttributeValue("", 170, Url.Action("ListaFilmow", "Filmy", new { nazwaKategorii = kategoria.Nazwa }), 170, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link\"> ");
#nullable restore
#line 9 "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml"
                                                                                                                  Write(kategoria.Nazwa);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n");
#nullable restore
#line 10 "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 310, "\"", 355, 1);
#nullable restore
#line 11 "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml"
WriteAttributeValue("", 317, Url.Action("WszystkieFilmy", "Filmy"), 317, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link\"> Wszystkie </a>\n");
#nullable restore
#line 12 "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml"
         using (Html.BeginForm("Szukaj", "Filmy"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""input-group"">
            <div class=""form-outline"">
                <input type=""search"" class=""form-control"" name=""fraza""/>
                
            </div>
            <button class=""btn btn-primary"" type=""submit"">Szukaj</button>
        </div>
");
#nullable restore
#line 21 "E:\TISklep\TISklep\Views\Shared\Components\Menu\_Menu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TISklep.Models.Kategoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\TISklep\TISklep\Views\Koszyk\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd4b5992efa31fec84de701e449c9a4a8f25168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Koszyk_Index), @"mvc.1.0.view", @"/Views/Koszyk/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd4b5992efa31fec84de701e449c9a4a8f25168", @"/Views/Koszyk/Index.cshtml")]
    public class Views_Koszyk_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TISklep.Models.CartItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n");
#nullable restore
#line 4 "E:\TISklep\TISklep\Views\Koszyk\Index.cshtml"
     foreach (var cartItem in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 7 "E:\TISklep\TISklep\Views\Koszyk\Index.cshtml"
           Write(cartItem.film.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 8 "E:\TISklep\TISklep\Views\Koszyk\Index.cshtml"
           Write(cartItem.Ilosc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "E:\TISklep\TISklep\Views\Koszyk\Index.cshtml"
           Write(cartItem.Wartosc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł</td>\r\n        </tr>\r\n");
#nullable restore
#line 11 "E:\TISklep\TISklep\Views\Koszyk\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<div>\r\n    Razem: ");
#nullable restore
#line 16 "E:\TISklep\TISklep\Views\Koszyk\Index.cshtml"
      Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" zł\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TISklep.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

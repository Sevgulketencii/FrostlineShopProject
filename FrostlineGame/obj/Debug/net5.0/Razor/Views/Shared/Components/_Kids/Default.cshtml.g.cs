#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_Kids\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0bfde169388041060f1ecc9b3ea28565660ec45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Kids_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Kids/Default.cshtml")]
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
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\_ViewImports.cshtml"
using FrostlineGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\_ViewImports.cshtml"
using FrostlineGame.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0bfde169388041060f1ecc9b3ea28565660ec45", @"/Views/Shared/Components/_Kids/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb18e8e24a44c9ee8503e6df27338dbe703b846e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Kids_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""section"" id=""kids"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""section-heading"">
                    <h2>Çocuk Giyim</h2>
                    <span>Çocuklarınızın sağlığını bizlerde düşünüyoruz.</span>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""kid-item-carousel"">
                    <div class=""owl-kid-item owl-carousel"">

");
#nullable restore
#line 20 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_Kids\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""item"">
                                <div class=""thumb"">
                                    <div class=""hover-content"">
                                        <ul>

                                            <li><a href=""single-product.html""><i class=""fa fa-eye""></i></a></li>

                                        </ul>
                                    </div>
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1112, "\"", 1141, 1);
#nullable restore
#line 31 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_Kids\Default.cshtml"
WriteAttributeValue("", 1118, item.ProductImageCover, 1118, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1142, "\"", 1148, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n                                <div class=\"down-content\">\n                                    <h4>");
#nullable restore
#line 34 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_Kids\Default.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                    <span>");
#nullable restore
#line 35 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_Kids\Default.cshtml"
                                     Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</span>\n                                    <ul class=\"stars\">\n");
            WriteLiteral("                                    </ul>\n                                </div>\n                            </div>\n");
#nullable restore
#line 41 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_Kids\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
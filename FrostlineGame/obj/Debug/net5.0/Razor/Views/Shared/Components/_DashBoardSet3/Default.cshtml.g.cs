#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_DashBoardSet3\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bcd93c1accf8331e099d84e43ae56222402c1e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DashBoardSet3_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DashBoardSet3/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcd93c1accf8331e099d84e43ae56222402c1e7", @"/Views/Shared/Components/_DashBoardSet3/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb18e8e24a44c9ee8503e6df27338dbe703b846e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__DashBoardSet3_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-lg-4 col-md-4 order-1"">
    <div class=""row"">
        <div class=""col-lg-12 col-md-12 col-6 mb-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-title d-flex align-items-start justify-content-between"">
                        <div class=""avatar flex-shrink-0"">
                            <img src=""/admin/assets/img/icons/unicons/cc-warning.png""
                                 alt=""chart success""
                                 class=""rounded"" />
                        </div>
                        <div class=""dropdown"">
                            <button class=""btn p-0""
                                    type=""button""
                                    id=""cardOpt3""
                                    data-bs-toggle=""dropdown""
                                    aria-haspopup=""true""
                                    aria-expanded=""false"">
                                <i class=""bx bx-dots-vertical-rounde");
            WriteLiteral(@"d""></i>
                            </button>
                            <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""cardOpt3"">
                                <a class=""dropdown-item"" href=""/Admin/Product/Index"">Tüm Ürünler</a>
                            </div>
                        </div>
                    </div>
                    <span class=""fw-semibold d-block mb-1"">Aktif Kampanya Sayısı</span>
                    <h1 class=""card-title mb-2"">");
#nullable restore
#line 27 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\Shared\Components\_DashBoardSet3\Default.cshtml"
                                           Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>");
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

#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\AdminLayoutPartial\_AdminNavbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebc91079c14cf71daf6d3e894dccb1e488e12df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayoutPartial__AdminNavbar), @"mvc.1.0.view", @"/Views/AdminLayoutPartial/_AdminNavbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc91079c14cf71daf6d3e894dccb1e488e12df7", @"/Views/AdminLayoutPartial/_AdminNavbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb18e8e24a44c9ee8503e6df27338dbe703b846e", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminLayoutPartial__AdminNavbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Views\AdminLayoutPartial\_AdminNavbar.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<ul class=""menu-inner py-1"">
    <!-- Dashboard -->
    <li class=""menu-item"">
        <a href=""/admin/DashBoard/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-home-circle""></i>
            <div data-i18n=""Analytics"">Dashboard</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""/Admin/Product/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxl-product-hunt""></i>
            <div data-i18n=""Analytics"">Ürünler</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""/Admin/Contact/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-message""></i>
            <div data-i18n=""Analytics"">Mesajlar</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-store""></i>
            <div data-i18n=""Analytics"">Kampanya Oluştur</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""index.html"" class=""men");
            WriteLiteral(@"u-link"">
            <i class=""menu-icon tf-icons bx bx-list-check""></i>
            <div data-i18n=""Analytics"">Devam Eden Kampanyalar</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-error-circle""></i>
            <div data-i18n=""Analytics"">Biten Kampanyalar</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""/Home/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-arrow-back""></i>
            <div data-i18n=""Analytics"">Siteye Dön</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""/Login/LogOut"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-log-out""></i>
            <div data-i18n=""Analytics"">Çıkış Yap</div>
        </a>
    </li>
</ul>");
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

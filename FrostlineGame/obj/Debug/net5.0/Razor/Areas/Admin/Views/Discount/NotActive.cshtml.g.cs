#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Discount\NotActive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3379fc8b1d1b5ee7d019a4e78dd48cbbbfb1186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Discount_NotActive), @"mvc.1.0.view", @"/Areas/Admin/Views/Discount/NotActive.cshtml")]
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
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\_ViewImports.cshtml"
using FrostlineGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\_ViewImports.cshtml"
using FrostlineGame.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\_ViewImports.cshtml"
using FrostlineGame.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3379fc8b1d1b5ee7d019a4e78dd48cbbbfb1186", @"/Areas/Admin/Views/Discount/NotActive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef7c7338a3173d4c12cfc3e8044355219f44d7a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Discount_NotActive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Discount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Discount\NotActive.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row row-cols-1 row-cols-md-4 g-1 mb-5\" style=\"margin-top:15px\">\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Discount\NotActive.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\">\r\n            <div class=\"card h-100\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 290, "\"", 313, 1);
#nullable restore
#line 13 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Discount\NotActive.cshtml"
WriteAttributeValue("", 296, item.DiscountImg, 296, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" />\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Discount\NotActive.cshtml"
                                      Write(item.DiscountName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">\r\n                        Kampanya Oranı: % <strong>");
#nullable restore
#line 17 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Discount\NotActive.cshtml"
                                             Write(item.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Discount\NotActive.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8d1febfbea7ed1c7109c6e4eb13538e3bb2444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8d1febfbea7ed1c7109c6e4eb13538e3bb2444", @"/Areas/Admin/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef7c7338a3173d4c12cfc3e8044355219f44d7a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
   
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<h1 style=\"margin-top:20px\">Gelen İletiler</h1>\n<div class=\"row mb-5\" style=\"margin-top:20px\">\n   \n");
#nullable restore
#line 9 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-lg-4 mb-3\">\n            <div class=\"card\">\n                <div class=\"card-header\">");
#nullable restore
#line 13 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
                                    Write(item.ContactMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
                                      Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\">\n                        ");
#nullable restore
#line 17 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
                   Write(item.ContactDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n\n                    <a");
            BeginWriteAttribute("href", " href=\"", 581, "\"", 630, 2);
            WriteAttributeValue("", 588, "/Admin/Contact/ReadContact/", 588, 27, true);
#nullable restore
#line 20 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 615, item.ContactID, 615, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Okundu İşaretle</a>\n");
#nullable restore
#line 21 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
                      
                        if (item.ContactStatus == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"margin-left:100px\" class=\"badge bg-danger\">Okunmadı</span>\n");
#nullable restore
#line 25 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"margin-left:100px\" class=\"badge bg-success\">Okundu</span>\n");
#nullable restore
#line 30 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 36 "C:\Users\Sevgül KETENCİ\Source\Repos\FrostlineShopProject\FrostlineGame\Areas\Admin\Views\Contact\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6e6b0d703fa269ae875f2bc9f0eadee54f97f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategori_Index), @"mvc.1.0.view", @"/Views/Kategori/Index.cshtml")]
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
#line 1 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\_ViewImports.cshtml"
using Kutuphane2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
using Kutuphane2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6e6b0d703fa269ae875f2bc9f0eadee54f97f5", @"/Views/Kategori/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bb5ed3196c316ec1e98923ed21459006adb0020", @"/Views/_ViewImports.cshtml")]
    public class Views_Kategori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kategori>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
  
    ViewData["Title"] = "Kategoriler";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table id=\"example\" class=\"display\" style=\"width:100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>Kategori Adı</th>\r\n            <th>Kitap Adeti</th>\r\n            <th>Güncelle</th>\r\n            <th>Sil</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
         foreach (var ktg in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
               Write(ktg.KategoriAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
               Write(ktg.Kitaplar.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button class=\"guncelle btn btn-custom\"");
            BeginWriteAttribute("value", " value=\"", 566, "\"", 581, 1);
#nullable restore
#line 22 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
WriteAttributeValue("", 574, ktg.Id, 574, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</button></td>\r\n                <td><button class=\"sil btn btn-danger\"");
            BeginWriteAttribute("value", " value=\"", 661, "\"", 676, 1);
#nullable restore
#line 23 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
WriteAttributeValue("", 669, ktg.Id, 669, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</button></td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\mcanb\source\repos\Kutuphane2\Kutuphane2\Views\Kategori\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <th>Kategori Adı</th>\r\n            <th>Kitap Adeti</th>\r\n            <th>Güncelle</th>\r\n            <th>Sil</th>\r\n        </tr>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kategori>> Html { get; private set; }
    }
}
#pragma warning restore 1591
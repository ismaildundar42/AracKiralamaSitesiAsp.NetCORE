#pragma checksum "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b2e0d7e6455a364960be1991eef3e03b0ee54b6cf1eb4b56b83fb6409c90bed7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Musteri_Index), @"mvc.1.0.view", @"/Views/Musteri/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\_ViewImports.cshtml"
using AracKiralamaSitesiCoreProje

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
 using AracKiralamaSitesiCoreProje.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b2e0d7e6455a364960be1991eef3e03b0ee54b6cf1eb4b56b83fb6409c90bed7", @"/Views/Musteri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c9b9350d7434bdd221d5329aaa61c1e9dcb36359a9c6cb8eb51864fef5734564", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Musteri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
       List<Musteri>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Musteri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-4 d-flex gap-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AnaTema.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>Müşteri Listesi</h2>\r\n\r\n<!-- 🔍 Arama Formu -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e0d7e6455a364960be1991eef3e03b0ee54b6cf1eb4b56b83fb6409c90bed75307", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"search\" class=\"form-control w-25\" placeholder=\"Müşteri adı giriniz...\" />\r\n    <button type=\"submit\" class=\"btn btn-primary\">Ara</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table table-dark table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Müşteri İd</th>
            <th scope=""col"">Müşteri Ad Soyad</th>
            <th scope=""col"">Müşteri Telefon</th>
            <th scope=""col"">Müşteri TC</th>
            <th scope=""col"">Müşteri Şifre</th>
            <th scope=""col"">Güncelle</th>
            <th scope=""col"">Sil</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 33 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
                     x.MusteriId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 34 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
                     x.MusteriAdSoyad

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 35 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
                     x.MusteriTelefon

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 36 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
                     x.MusteriTc

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 37 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
                     x.MusteriSifre

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1212, "\"", 1256, 2);
            WriteAttributeValue("", 1219, "/Musteri/MusteriGuncelle/", 1219, 25, true);
            WriteAttributeValue("", 1244, 
#nullable restore
#line 38 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
                                                       x.MusteriId

#line default
#line hidden
#nullable disable
            , 1244, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1320, "\"", 1359, 2);
            WriteAttributeValue("", 1327, "/Musteri/MusteriSil/", 1327, 20, true);
            WriteAttributeValue("", 1347, 
#nullable restore
#line 39 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
                                                  x.MusteriId

#line default
#line hidden
#nullable disable
            , 1347, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\ismail\Desktop\EFCoreProje\AracKiralamaSitesiCoreProje\Views\Musteri\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"/Musteri/MusteriEkle\" class=\"btn btn-primary\">Yeni Müşteri Ekle</a>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Musteri>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

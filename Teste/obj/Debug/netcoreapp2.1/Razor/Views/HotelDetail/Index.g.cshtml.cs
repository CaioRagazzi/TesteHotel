#pragma checksum "C:\Users\g0ysb\source\repos\Teste\Teste\Views\HotelDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31727078cee8faad085e81986565f22d0f9348eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelDetail_Index), @"mvc.1.0.view", @"/Views/HotelDetail/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelDetail/Index.cshtml", typeof(AspNetCore.Views_HotelDetail_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31727078cee8faad085e81986565f22d0f9348eb", @"/Views/HotelDetail/Index.cshtml")]
    public class Views_HotelDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teste.Models.HotelDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\HotelDetail\Index.cshtml"
  
    ViewData["Title"] = "Detalhes do Hotel " + Model.name;

#line default
#line hidden
            BeginContext(103, 9, true);
            WriteLiteral("\r\n<title>");
            EndContext();
            BeginContext(113, 17, false);
#line 7 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\HotelDetail\Index.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(130, 16, true);
            WriteLiteral("</title>\r\n\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 146, "\"", 167, 1);
#line 9 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\HotelDetail\Index.cshtml"
WriteAttributeValue("", 152, Model.urlThumb, 152, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(168, 20, true);
            WriteLiteral(" alt=\"Imagem Hotel\">");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teste.Models.HotelDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
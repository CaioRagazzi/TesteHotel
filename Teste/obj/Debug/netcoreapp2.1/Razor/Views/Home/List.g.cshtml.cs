#pragma checksum "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10c13e61d42518ba8badade48e72da5b1359ad1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c13e61d42518ba8badade48e72da5b1359ad1f", @"/Views/Home/List.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teste.Models.Hotel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8824d856e12f475f86ee4c7f41ac6d46", async() => {
                BeginContext(110, 171, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n    ");
                EndContext();
                BeginContext(281, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5d8e9e9c83fc47658d4159bce1620229", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(326, 107, true);
                WriteLiteral("\r\n    <title>Create</title>\r\n    <meta http-equiv=”Content-Type” content=”text/html; charset=iso-8859-1″>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(440, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(442, 1856, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627a9166a2094b31b7db8efdd965e1b7", async() => {
                BeginContext(448, 34, true);
                WriteLiteral("\r\n    <div class=\"div-content2\">\r\n");
                EndContext();
#line 19 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(531, 83, true);
                WriteLiteral("            <div style=\"border:solid; padding:5px; margin: 10px\">\r\n                ");
                EndContext();
                BeginContext(615, 90, false);
#line 22 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
           Write(Html.ActionLink("Detalhes do Hotel", "HotelsDetails", "Home", new { @item.HotelId }, null));

#line default
#line hidden
                EndContext();
                BeginContext(705, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                 foreach (var item2 in item.Rooms)
                {


#line default
#line hidden
                BeginContext(780, 808, true);
                WriteLiteral(@"                    <table class=""table table-bordered"" style=""padding: 10px"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>Quarto ID</th>
                                <th>Adicionais</th>
                                <th>Número de adultos</th>
                                <th>Número de quartos</th>
                                <th>Disponível</th>
                                <th>Descrição do Quarto</th>
                                <th>Preço total</th>
                                <th>Preço do quarto</th>
                                <th>Mais informações</th>
                            </tr>
                        </thead>
                        <tr>
                            <td>");
                EndContext();
                BeginContext(1589, 8, false);
#line 41 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1597, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1637, 22, false);
#line 42 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.BoardDescription);

#line default
#line hidden
                EndContext();
                BeginContext(1659, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1699, 15, false);
#line 43 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.NumAdults);

#line default
#line hidden
                EndContext();
                BeginContext(1714, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1754, 14, false);
#line 44 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(1768, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1808, 17, false);
#line 45 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.IsAvailable);

#line default
#line hidden
                EndContext();
                BeginContext(1825, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1865, 21, false);
#line 46 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.RoomDescription);

#line default
#line hidden
                EndContext();
                BeginContext(1886, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1926, 29, false);
#line 47 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.TotalSellingPrice.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1955, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1957, 32, false);
#line 47 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                                                          Write(item2.TotalSellingPrice.Currency);

#line default
#line hidden
                EndContext();
                BeginContext(1989, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2029, 31, false);
#line 48 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.SellingPricePerRoom.Value);

#line default
#line hidden
                EndContext();
                BeginContext(2060, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2062, 34, false);
#line 48 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                                                            Write(item2.SellingPricePerRoom.Currency);

#line default
#line hidden
                EndContext();
                BeginContext(2096, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2136, 21, false);
#line 49 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
                           Write(item2.MoreInformation);

#line default
#line hidden
                EndContext();
                BeginContext(2157, 70, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                    </table>\r\n");
                EndContext();
#line 53 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"

                }

#line default
#line hidden
                BeginContext(2248, 20, true);
                WriteLiteral("            </div>\r\n");
                EndContext();
#line 56 "C:\Users\g0ysb\source\repos\Teste\Teste\Views\Home\List.cshtml"
        }

#line default
#line hidden
                BeginContext(2279, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2298, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teste.Models.Hotel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

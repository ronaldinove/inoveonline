#pragma checksum "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe0c1181697344fb1d262750177d78967a180155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Listagem), @"mvc.1.0.view", @"/Views/Contato/Listagem.cshtml")]
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
#line 1 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\_ViewImports.cshtml"
using Atv3._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\_ViewImports.cshtml"
using Atv3._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe0c1181697344fb1d262750177d78967a180155", @"/Views/Contato/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae5129c6324a87d61a366d30f0f9fa7eda608a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemContato>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <table class=""table"">

        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Telefone</th>
                <th>Email</th>
                <th>Serviço</th>
                <th>Mensagem</th>
                <th>Manutenção</th>
            </tr>
        </thead>

");
#nullable restore
#line 17 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
         foreach (ItemContato c in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
               Write(c.idContato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
               Write(c.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
               Write(c.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
               Write(c.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
               Write(c.servico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
               Write(c.mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 698, "\"", 743, 2);
            WriteAttributeValue("", 705, "/Contato/Editar?idContato=", 705, 26, true);
#nullable restore
#line 27 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
WriteAttributeValue("", 731, c.idContato, 731, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>   <a");
            BeginWriteAttribute("href", " href=\"", 760, "\"", 806, 2);
            WriteAttributeValue("", 767, "/Contato/Deletar?idContato=", 767, 27, true);
#nullable restore
#line 27 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
WriteAttributeValue("", 794, c.idContato, 794, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Usuario\Downloads\Atv4CarlosMachado\Atv3.1\Views\Contato\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemContato>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Raniel\source\repos\Fiap.Ipark\IPark.UI\Views\Locatario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f29fe562ef047a3954c55d6d91dd0c0cea5054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locatario_Index), @"mvc.1.0.view", @"/Views/Locatario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Locatario/Index.cshtml", typeof(AspNetCore.Views_Locatario_Index))]
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
#line 1 "C:\Users\Raniel\source\repos\Fiap.Ipark\IPark.UI\Views\_ViewImports.cshtml"
using IPark.UI;

#line default
#line hidden
#line 2 "C:\Users\Raniel\source\repos\Fiap.Ipark\IPark.UI\Views\_ViewImports.cshtml"
using IPark.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f29fe562ef047a3954c55d6d91dd0c0cea5054", @"/Views/Locatario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ebd482e1e48b2af71ec27524bb31b7ad2f57946", @"/Views/_ViewImports.cshtml")]
    public class Views_Locatario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Raniel\source\repos\Fiap.Ipark\IPark.UI\Views\Locatario\Index.cshtml"
  
    ViewData["Title"] = "Locatário";

#line default
#line hidden
            BeginContext(47, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(54, 17, false);
#line 6 "C:\Users\Raniel\source\repos\Fiap.Ipark\IPark.UI\Views\Locatario\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(71, 1473, true);
            WriteLiteral(@"</h2>


<div class=""card shadow mb-4"" ng-app=""app"">
    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
        <h6 class=""m-0 font-weight-bold text-primary"">Lista de Clientes</h6>
        <div class=""dropdown no-arrow show"">
            <button class=""btn btn-sm btn-outline-primary"">
                <i class=""fas fa-plus-circle""></i> Novo
            </button>
        </div>
    </div>
    <div class=""card-body"">
        <table class=""table table-hover table-sm"">
            <thead>
                <tr>
                    <th style=""width:5% !important"">Cod</th>
                    <th style=""width:50% !important"">Nome</th>
                    <th>CPF</th>
                    <th style=""width:10% !important""></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Locatario 1</td>
                    <td>111.222.000-00</td>
                    <td><butt");
            WriteLiteral(@"on class=""btn btn-sm btn-info btn-xs""><i class=""fas fa-edit""></i> Editar</button></td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Locatario 2</td>
                    <td>000.000.00-00</td>
                    <td><button class=""btn btn-sm btn-info btn-xs""><i class=""fas fa-edit""></i> Editar</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

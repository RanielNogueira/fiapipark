#pragma checksum "C:\Users\Raniel\source\repos\Fiap.Ipark\IPark.UI\Views\Locatario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8531908a9e06c52fae8e8d7d1a0e2c4deff8b3b6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8531908a9e06c52fae8e8d7d1a0e2c4deff8b3b6", @"/Views/Locatario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ebd482e1e48b2af71ec27524bb31b7ad2f57946", @"/Views/_ViewImports.cshtml")]
    public class Views_Locatario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formLocatario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formLocatario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-submit", new global::Microsoft.AspNetCore.Html.HtmlString("salvar(locatario)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/angular-resource/angular-resource.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/angular-mask/ngMask.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/app/controller/locatario.controller.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Raniel\source\repos\Fiap.Ipark\IPark.UI\Views\Locatario\Index.cshtml"
  
    ViewData["Title"] = "Locatários";

#line default
#line hidden
            BeginContext(48, 2165, true);
            WriteLiteral(@"
<div class=""card shadow"" ng-app=""app"" ng-controller=""locatarioController"">
    <div class=""card-header py-2 d-flex flex-row align-items-center justify-content-between"">
        <h6 class=""m-0 font-weight-bold text-primary"">Lista de Locatarios</h6>
        <div class=""dropdown no-arrow show"">
            <button class=""btn btn-sm btn-outline-primary"" ng-click=""novo()"">
                <i class=""fas fa-plus-circle""></i> Novo
            </button>
        </div>
    </div>
    <div class=""card-body"">
        <table class=""table table-hover table-sm"" datatable=""ng"" dt-options=""dtOptions"">
            <thead>
                <tr>
                    <th style=""width:5% !important"">Cod</th>
                    <th style=""width:30% !important"">Nome</th>
                    <th>CPF</th>
                    <th>E-mail</th>
                    <th style=""width:20% !important""></th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat=""item in locatarios"">
");
            WriteLiteral(@"                    <td>{{item.idLocatario}}</td>
                    <td>{{item.Nome}}</td>
                    <td>{{item.Email}}</td>
                    <td>{{item.Cpf}}</td>
                    <td>
                        <button ng-click=""editar(item,formLocatario)"" class=""btn btn-sm btn-info btn-xs""><i class=""fas fa-edit""></i> Editar</button>
                        <button ng-click=""remover(item.idLocatario)"" class=""btn btn-sm btn-danger btn-xs""><i class=""fas fa-times-circle""></i> Remover</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modalLocatario"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Novo locatario</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                   ");
            WriteLiteral("     <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(2213, 2514, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88215d9682b047f397bc154b200d8006", async() => {
                BeginContext(2289, 2431, true);
                WriteLiteral(@"
                    <div class=""modal-body"">

                        <div class=""form-row"">
                            <div class=""col-6"">
                                <label>Nome</label>
                                <input name=""nome"" required ng-model=""locatario.Nome"" autocomplete=""off"" id=""nome"" ng-class=""!formLocatario.nome.$dirty ? 'form-control' : (formLocatario.nome.$dirty && formLocatario.nome.$valid ? 'form-control is-valid' : 'form-control is-invalid')"" />
                            </div>
                            <div class=""col-6"">
                                <label>E-mail</label>
                                <input type=""email"" required ng-model=""locatario.Email"" autocomplete=""off"" name=""email"" id=""email"" class=""form-control"" ng-class=""!formLocatario.email.$dirty ? 'form-control' : (formLocatario.email.$dirty && formLocatario.email.$valid ? 'form-control is-valid' : 'form-control is-invalid')"" />
                            </div>
                        </div>
  ");
                WriteLiteral(@"                      <div class=""form-row"">
                            <div class=""col-3"">
                                <label>Telefone</label>
                                <input name=""telefone"" required mask=""(99)99999-9999"" ng-model=""locatario.Telefone"" autocomplete=""off"" id=""telefone"" class=""form-control"" ng-class=""!formLocatario.telefone.$dirty ? 'form-control' : (formLocatario.telefone.$dirty && formLocatario.telefone.$valid ? 'form-control is-valid' : 'form-control is-invalid')"" />
                            </div>
                            <div class=""col-3"">
                                <label>CPF</label>
                                <input type=""text"" required ng-model=""locatario.Cpf"" autocomplete=""off"" mask=""999.999.999-99"" name=""cpf"" id=""cpf"" class=""form-control"" ng-class=""!formLocatario.cpf.$dirty ? 'form-control' : (formLocatario.cpf.$dirty && formLocatario.cpf.$valid ? 'form-control is-valid' : 'form-control is-invalid')""/>
                            </div>
          ");
                WriteLiteral(@"              </div>

                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                        <button type=""submit"" class=""btn btn-success""><span class=""fas fa-check-circle""></span> Salvar</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4727, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4804, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4810, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b753a683decf456fbbb03892e30c0e83", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4876, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4882, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd317ad5a6b47318e225d18e5a6b937", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4938, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4944, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe09ad0722a045c0bd168f94dac49568", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5008, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
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

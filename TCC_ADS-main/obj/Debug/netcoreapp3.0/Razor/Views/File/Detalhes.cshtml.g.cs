#pragma checksum "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09dd92982f570dd78e1f44f40eb7028613d590d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Detalhes), @"mvc.1.0.view", @"/Views/File/Detalhes.cshtml")]
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
#line 1 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\_ViewImports.cshtml"
using Gerenciador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\_ViewImports.cshtml"
using Gerenciador.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09dd92982f570dd78e1f44f40eb7028613d590d7", @"/Views/File/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b9a71efee69a608b8f60beebd18d6b6a041482", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GERENCIADOR_TESTE_TEMPLANTE.Models.FileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "File", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Autor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
  
    ViewData["Title"] = "DetailsFileFromDatabase";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""card card-success"">
        <div class=""card-header"">
            <h3 class=""card-title"">Detalhes do Arquivo</h3>
        </div>
        <div>
            <hr />
            <div class=""form-group"">
                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        ");
#nullable restore
#line 17 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 20 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 23 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 26 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 29 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 32 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 35 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.PalavraChave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 38 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.PalavraChave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 41 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.AnoPubli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 44 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.AnoPubli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 47 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.NomeArquivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 50 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.NomeArquivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 53 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataCriacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 56 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.DataCriacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 59 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoArquivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 62 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.TipoArquivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 65 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Estensao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 68 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.Estensao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        ");
#nullable restore
#line 71 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 74 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        Categoria\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 80 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.categoria.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        Orientador\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 86 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.professor.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        Tipo Trabalho\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 92 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                   Write(Html.DisplayFor(model => model.TipoTrabalho.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n\n                </dl>\n            </div>\n            <div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09dd92982f570dd78e1f44f40eb7028613d590d713796", async() => {
                WriteLiteral("Download");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\O'Conner\Desktop\TCC_ADS-main\Views\File\Detalhes.cshtml"
                                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09dd92982f570dd78e1f44f40eb7028613d590d716385", async() => {
                WriteLiteral("Voltar a Lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GERENCIADOR_TESTE_TEMPLANTE.Models.FileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e5a5620694acb21712cbbf3cb1bdf26d379c89b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Create), @"mvc.1.0.view", @"/Views/Usuario/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Create.cshtml", typeof(AspNetCore.Views_Usuario_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e5a5620694acb21712cbbf3cb1bdf26d379c89b", @"/Views/Usuario/Create.cshtml")]
    public class Views_Usuario_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CFApi.Model.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(72, 1806, true);
            WriteLiteral(@"
<h1>Create</h1>

<h4>Usuario</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cpf"" class=""control-label""></label>
                <input asp-for=""Cpf"" class=""form-control"" />
                <span asp-validation-for=""Cpf"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Senha"" class=""control-label""></label>
                <input asp-for=""Senha"" class=""form-control"" />
                <span asp-validation-for=""Senha"" class=""text-danger""></span>
            </div>
          ");
            WriteLiteral(@"  <div class=""form-group"">
                <label asp-for=""NumeroSus"" class=""control-label""></label>
                <input asp-for=""NumeroSus"" class=""form-control"" />
                <span asp-validation-for=""NumeroSus"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1896, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CFApi.Model.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32c80edbf749e61289ceeb345fac52ef552a17ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c80edbf749e61289ceeb345fac52ef552a17ed", @"/Views/Usuario/Index.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CFApi.Model.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 158, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(243, 40, false);
#line 16 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(283, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(339, 39, false);
#line 19 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(378, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(434, 41, false);
#line 22 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(475, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 45, false);
#line 25 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroSus));

#line default
#line hidden
            EndContext();
            BeginContext(576, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(632, 41, false);
#line 28 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(673, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(791, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(840, 39, false);
#line 37 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(879, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(935, 38, false);
#line 40 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1029, 40, false);
#line 43 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1125, 44, false);
#line 46 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroSus));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1225, 40, false);
#line 49 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1340, "\"", 1363, 1);
#line 52 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1355, item.Id, 1355, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1364, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1416, "\"", 1439, 1);
#line 53 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1431, item.Id, 1431, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1440, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1494, "\"", 1517, 1);
#line 54 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1509, item.Id, 1509, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1518, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\filli\Desktop\MeuIF\CFApi\CFApi\Views\Usuario\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1568, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CFApi.Model.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591

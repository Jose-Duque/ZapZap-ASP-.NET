#pragma checksum "C:\Users\DESKTOP\Desktop\Zap-Zap .NET\ZapZap\ZapZap\Views\Home\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf9d74b81e2bfc0bf5ea8558b3ab464e90d49fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cadastro), @"mvc.1.0.view", @"/Views/Home/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cadastro.cshtml", typeof(AspNetCore.Views_Home_Cadastro))]
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
#line 1 "C:\Users\DESKTOP\Desktop\Zap-Zap .NET\ZapZap\ZapZap\Views\_ViewImports.cshtml"
using ZapZap;

#line default
#line hidden
#line 2 "C:\Users\DESKTOP\Desktop\Zap-Zap .NET\ZapZap\ZapZap\Views\_ViewImports.cshtml"
using ZapZap.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf9d74b81e2bfc0bf5ea8558b3ab464e90d49fc", @"/Views/Home/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8757b1f678c19bfbc571e71982282fcd90143c9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("style", async() => {
                BeginContext(16, 184, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        body {\r\n            background-color: #32A060;\r\n        }\r\n\r\n        input[type=text] {\r\n            max-width: 690px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(203, 537, true);
            WriteLiteral(@"
<div class=""container-login"" id=""cadastrar"">
    <img src=""/imagem/logo.png"" />
    <h1>ZapZap</h1>
    <div class=""container-form"">
        <input type=""text"" placeholder=""Nome"" id=""name""/>
        <br />
        <input type=""text"" placeholder=""E-mail"" id=""email""/>
        <br />
        <input type=""text"" placeholder=""Senha"" id=""password""/>

        <div class=""container-button"">
            <input type=""button"" value=""CADASTRAR"" id=""btnCadastrar""/>
        </div>
    </div>
    <span id=""mensagem""></span>
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
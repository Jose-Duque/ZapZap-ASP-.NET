#pragma checksum "C:\Users\DESKTOP\Desktop\Zap-Zap .NET\ZapZap\ZapZap\Views\Home\Conversacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0fc6b5bbbabdc4294aba6424c8d3c96f4f881ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Conversacao), @"mvc.1.0.view", @"/Views/Home/Conversacao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Conversacao.cshtml", typeof(AspNetCore.Views_Home_Conversacao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0fc6b5bbbabdc4294aba6424c8d3c96f4f881ae", @"/Views/Home/Conversacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8757b1f678c19bfbc571e71982282fcd90143c9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Conversacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("style", async() => {
                BeginContext(16, 112, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        body {\r\n            background-color: #F0F0F0;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(131, 1661, true);
            WriteLiteral(@"
<!-- Side navigation -->
<div class=""sidenav"">
    
    <div class=""container-logo"">
        
        <img src=""/imagem/logo.png"" style=""width: 50%;"" />
    </div>
    <div id=""users"">
        <a href=""#"" id=""logaut"">Sair</a>
        <div class=""container-user-item"">
            <img src=""/imagem/logo.png"" style=""width: 20%;"" />
            <div>
                <span>Aline (online)</span>
                <span class=""email"">aline123@gmail.com</span>
            </div>
        </div>
        <div class=""container-user-item"">
            <img src=""/imagem/logo.png"" style=""width: 20%;"" />
            <div>
                <span>Aline (offline)</span>
                <span class=""email"">aline123@gmail.com</span>
            </div>
        </div>
    </div>

</div>

<!-- Page content -->
<div class=""main"" id=""tela-conversacao"">
    <div class=""container-messages"">
        <div class=""message message-left"">
            <div class=""message-head"">
                <img src=""/imagem/c");
            WriteLiteral(@"hat.png"" />
                Aline
            </div>
            <div class=""message-message"">
                Olá José! Como vai?
            </div>


        </div>
        <div class=""message message-right"">
            <div class=""message-head"">
                <img src=""/imagem/chat.png"" />
                Eu
            </div>
            <div class=""message-message"">
                Olá José! Como vai?
            </div>
        </div>

    </div>

    <div class=""container-button"">
        <input type=""text"" placeholder=""Mensagem"" />
        <button class=""btn-send""></button>
    </div>

</div>
");
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

#pragma checksum "C:\Users\MARCO\Desktop\Progra_proyecto\PlayToy\Views\Home\inicio2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9976a0d67da1c9540dc34673aacf0188e0cf2d66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_inicio2), @"mvc.1.0.view", @"/Views/Home/inicio2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/inicio2.cshtml", typeof(AspNetCore.Views_Home_inicio2))]
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
#line 1 "C:\Users\MARCO\Desktop\Progra_proyecto\PlayToy\Views\_ViewImports.cshtml"
using PlayToy;

#line default
#line hidden
#line 2 "C:\Users\MARCO\Desktop\Progra_proyecto\PlayToy\Views\_ViewImports.cshtml"
using PlayToy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9976a0d67da1c9540dc34673aacf0188e0cf2d66", @"/Views/Home/inicio2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c3e479aa09aab0715ab07e07ff86ae26311325", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_inicio2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\MARCO\Desktop\Progra_proyecto\PlayToy\Views\Home\inicio2.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
            BeginContext(42, 777, true);
            WriteLiteral(@"
<style>
    img{
        margin-top: 40px;
    }
    .imagen{
        width: 200px;

    }
    .lego{
        width: 150px;
        margin-top: 75px;
    }
</style>
<div class=""container"">
    <div class=""row"">
        <div class=""col-12 col-md-8"">
            <img src=""/images/Robot.PNG"">
        </div>
        <div class=""row"">
            
            <div class=""col-3 col-md-2"">
                <img class=""imagen"" src=""/images/disney.jpg"">
                <img class=""imagen"" src=""/images/barbie.PNG"">
            </div>
            <div class=""col-3 col-md-2"">
                <img class=""lego"" src=""/images/lego.jpg"">
                <img class=""imagen"" src=""/images/hasbro.PNG"">
            </div>
    </div>

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

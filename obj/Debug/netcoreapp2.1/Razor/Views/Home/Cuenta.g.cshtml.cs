#pragma checksum "D:\Documentos\a\PlayToy\Views\Home\Cuenta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdaab6150dcfe49d570caed60a80cddcc3991eeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cuenta), @"mvc.1.0.view", @"/Views/Home/Cuenta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cuenta.cshtml", typeof(AspNetCore.Views_Home_Cuenta))]
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
#line 1 "D:\Documentos\a\PlayToy\Views\_ViewImports.cshtml"
using PlayToy;

#line default
#line hidden
#line 2 "D:\Documentos\a\PlayToy\Views\_ViewImports.cshtml"
using PlayToy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdaab6150dcfe49d570caed60a80cddcc3991eeb", @"/Views/Home/Cuenta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c3e479aa09aab0715ab07e07ff86ae26311325", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cuenta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Documentos\a\PlayToy\Views\Home\Cuenta.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
            BeginContext(42, 3075, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""../../wwwroot/css/cuenta.css"">
<div>
<h2>Vertical Tabs</h2>
<p>Click on the buttons inside the tabbed menu:</p>
<div class=""user"">
<div class=""tab"">
  <img src=""user.png"" alt=""""  height=""100px"" width=""100px"" style=""margin-left:90px;"">

  <button class=""tablinks"" onclick=""openCity(event, 'Misdatos')"" id=""defaultOpen"">Mis datos</button>
  <button class=""tablinks"" onclick=""openCity(event, 'Mispedidos')"">Mis pedidos</button>
  <button class=""tablinks"" onclick=""openCity(event, 'Paneldecontrol')"">Panel de control</button>
  <button class=""tablinks"">Cerrar sesión</button>
</div>

<div id=""Misdatos"" class=""tabcontent"">
  <div class=""c1"">
  <h3>Mis datos</h3>
  <div class=""row"">
  <div class=""c2"">
    <div class=""col-md-12"">
    <a id=""myBtn""><i class='far fa-edit' style=""font-size:26px;""></i></a>
  </div>
  <label class=""col-md-12"" for=""Name"">Nombre: Pocho Alberto</label>
</div>
</div>
</div>
</div>







<div id=""Mispedidos"" class=""tabcontent"">
  <div ");
            WriteLiteral(@"class=""c1"">
  <h3>Mis pedidos</h3>
  <p> Esta vacío </p>
  <button class=""btn btn-success""> Continuar comprando</button>
</div>
</div>

<div id=""Paneldecontrol"" class=""tabcontent"">
  <div class=""c1"">
  <h3>Panel de control</h3>
  <p></p>
</div>
</div>
</div>


<!-- Trigger/Open The Modal -->


<!-- The Modal -->
<div id=""myModal"" class=""modal"">

  <!-- Modal content -->
  <div class=""modal-content"">
    <div class=""modal-header"">
      <span class=""close"">&times;</span>

    </div>
    <div class=""modal-body"">
      <p>Some text in the Modal Body</p>
      <p>Some other text...</p>
    </div>
    <div class=""modal-footer"">
      <h3>Modal Footer</h3>
    </div>
  </div>

</div>

</div>
<script>
function openCity(evt, cityName) {
  var i, tabcontent, tablinks;
  tabcontent = document.getElementsByClassName(""tabcontent"");
  for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = ""none"";
  }
  tablinks = document.getElementsByClassName(""tablinks""");
            WriteLiteral(@");
  for (i = 0; i < tablinks.length; i++) {
    tablinks[i].className = tablinks[i].className.replace("" active"", """");
  }
  document.getElementById(cityName).style.display = ""block"";
  evt.currentTarget.className += "" active"";
}

// Get the element with id=""defaultOpen"" and click on it
document.getElementById(""defaultOpen"").click();



var modal = document.getElementById(""myModal"");

// Get the button that opens the modal
var btn = document.getElementById(""myBtn"");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName(""close"")[0];

// When the user clicks the button, open the modal
btn.onclick = function() {
  modal.style.display = ""block"";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
  modal.style.display = ""none"";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = ""none"";
  }
}
</script");
            WriteLiteral(">\r\n");
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

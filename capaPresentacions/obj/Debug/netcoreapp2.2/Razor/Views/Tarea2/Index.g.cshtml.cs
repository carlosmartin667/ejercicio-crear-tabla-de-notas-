#pragma checksum "C:\Users\carloscornejo\Desktop\tarea\capaPresentacions\Views\Tarea2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e8a8e5f554f66058dbc44465781ebf82577610f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarea2_Index), @"mvc.1.0.view", @"/Views/Tarea2/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarea2/Index.cshtml", typeof(AspNetCore.Views_Tarea2_Index))]
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
#line 1 "C:\Users\carloscornejo\Desktop\tarea\capaPresentacions\Views\_ViewImports.cshtml"
using capaPresentacions;

#line default
#line hidden
#line 2 "C:\Users\carloscornejo\Desktop\tarea\capaPresentacions\Views\_ViewImports.cshtml"
using capaPresentacions.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e8a8e5f554f66058dbc44465781ebf82577610f", @"/Views/Tarea2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58cfb0214bed0c4e645fa0e20dbff4ac99dc3495", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarea2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ordenarNombre.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\carloscornejo\Desktop\tarea\capaPresentacions\Views\Tarea2\Index.cshtml"
  
  ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 2535, true);
            WriteLiteral(@"

<div id=""app"" class=""grid"">
  <h1>notas de alumnos</h1>
  <hr>
  <h2 class=""text-primary"">agregar nombre: </h2>

  <input type=""text"" maxlength=""25"" v-model=""newUser"" placeholder=""Nombre"" required>
  <button type=""button"" v-on:click=""addUser()"" class=""btn"">agregar</button>


  <hr>
  <h1>lista de nombres </h1>

  <table class=""table table-dark table-striped"">
    <thead>
      <tr>
        <th>Nombre</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for=""name in names "">
        <td>{{name}}</td>
      </tr>
    </tbody>
  </table>

  <hr />

  <h2>lista de nombre con vocales </h2>

  <table class=""table table-dark table-striped"">
    <thead>
      <tr>
        <th>Nombre</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for=""name in vocales"">
        <td>{{name}}</td>
      </tr>
    </tbody>
  </table>

  <h2>lista de nombre con consonantes </h2>

  <table class=""table table-dark table-striped"">
    <thead>
      <tr>
        <th>Nombre</th>
      <");
            WriteLiteral(@"/tr>
    </thead>
    <tbody>
      <tr v-for=""name in consonantes"">
        <td>{{name}}</td>
      </tr>
    </tbody>
  </table>

  <h2>lista de nombre con vocales arodenadas asendentemente </h2>

  <table class=""table table-dark table-striped"">
    <thead>
      <tr>
        <th>Nombre</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for=""name in vocalesAscendentes"">
        <td>{{name}}</td>
      </tr>
    </tbody>
  </table>

  <h2>lista de nombre con vocales arodenadas Desedente </h2>

  <table class=""table table-dark table-striped"">
    <thead>
      <tr>
        <th>Nombre</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for=""name in vocalesDescendentes"">
        <td>{{name}}</td>
      </tr>
    </tbody>
  </table>

  <h2>lista de nombre con consonantes arodenadas desedente </h2>

  <table class=""table table-dark table-striped"">
    <thead>
      <tr>
        <th>Nombre</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for=""name in conson");
            WriteLiteral(@"antesDescendentes"">
        <td>{{name}}</td>
      </tr>
    </tbody>
  </table>

  <h2>lista de nombre con consonantes arodenadas asedente </h2>

  <table class=""table table-dark table-striped"">
    <thead>
      <tr>
        <th>Nombre</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for=""name in consonantesAscendentes"">
        <td>{{name}}</td>
      </tr>
    </tbody>
  </table>


</div>
  <script src=""https://cdn.jsdelivr.net/npm/vue""></script>
  ");
            EndContext();
            BeginContext(2576, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e8a8e5f554f66058dbc44465781ebf82577610f6493", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2621, 2, true);
            WriteLiteral("\r\n");
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

#pragma checksum "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f203fc058b0d5197782f0fa0849414cc88ee7cfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ArbolBinario_Rellenar), @"mvc.1.0.view", @"/Views/ArbolBinario/Rellenar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ArbolBinario/Rellenar.cshtml", typeof(AspNetCore.Views_ArbolBinario_Rellenar))]
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
#line 1 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\_ViewImports.cshtml"
using Lab_2_JoseDiaz;

#line default
#line hidden
#line 2 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\_ViewImports.cshtml"
using Lab_2_JoseDiaz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f203fc058b0d5197782f0fa0849414cc88ee7cfb", @"/Views/ArbolBinario/Rellenar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5155aa7ddea1df35968418aac248a8afa1e436f", @"/Views/_ViewImports.cshtml")]
    public class Views_ArbolBinario_Rellenar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab_2_JoseDiaz.Entities.FarmacoEntity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Actualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
  
    ViewData["Title"] = "Rellenar";

#line default
#line hidden
            BeginContext(105, 32, true);
            WriteLiteral("\r\n<h2>Rellenar</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(137, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80e5f78f64e4cbc81f1aeda8cfd01e2", async() => {
                BeginContext(164, 18, true);
                WriteLiteral("Rellenar productos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(279, 42, false);
#line 16 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(321, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(377, 47, false);
#line 19 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(424, 125, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Casa productora\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(550, 42, false);
#line 25 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(592, 59, true);
            WriteLiteral(" ($)\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(652, 46, false);
#line 28 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Existencia));

#line default
#line hidden
            EndContext();
            BeginContext(698, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(816, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 41, false);
#line 37 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(906, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(962, 46, false);
#line 40 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1064, 49, false);
#line 43 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.CasaProductora));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1169, 41, false);
#line 46 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1266, 45, false);
#line 49 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Existencia));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\ArbolBinario\Rellenar.cshtml"
}

#line default
#line hidden
            BeginContext(1364, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab_2_JoseDiaz.Entities.FarmacoEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ef87e9f63e4317af2f7ca69e0709887ef74f8f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Simulacion_Terminar), @"mvc.1.0.view", @"/Views/Simulacion/Terminar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Simulacion/Terminar.cshtml", typeof(AspNetCore.Views_Simulacion_Terminar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef87e9f63e4317af2f7ca69e0709887ef74f8f6", @"/Views/Simulacion/Terminar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5155aa7ddea1df35968418aac248a8afa1e436f", @"/Views/_ViewImports.cshtml")]
    public class Views_Simulacion_Terminar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab_2_JoseDiaz.Models.EmpleadoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
  
    ViewData["Title"] = "Terminar";

#line default
#line hidden
            BeginContext(107, 32, true);
            WriteLiteral("\r\n<h2>Terminar</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(139, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1bf4454c2fb4e3e96585607221a7d51", async() => {
                BeginContext(162, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(176, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(269, 42, false);
#line 16 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 38, false);
#line 19 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(405, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(461, 42, false);
#line 22 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(503, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(559, 52, false);
#line 25 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayNameFor(model => model.horas_trabajadas));

#line default
#line hidden
            EndContext();
            BeginContext(611, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(667, 50, false);
#line 28 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayNameFor(model => model.hora_deEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(717, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(773, 42, false);
#line 31 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayNameFor(model => model.Sueldo));

#line default
#line hidden
            EndContext();
            BeginContext(815, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(933, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(982, 41, false);
#line 40 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1079, 37, false);
#line 43 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1172, 41, false);
#line 46 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1269, 51, false);
#line 49 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayFor(modelItem => item.horas_trabajadas));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1376, 49, false);
#line 52 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
           Write(Html.DisplayFor(modelItem => item.hora_deEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               Q. ");
            EndContext();
            BeginContext(1483, 41, false);
#line 55 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
             Write(Html.DisplayFor(modelItem => item.Sueldo));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 53, true);
            WriteLiteral(".00\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Simulacion\Terminar.cshtml"
}

#line default
#line hidden
            BeginContext(1580, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab_2_JoseDiaz.Models.EmpleadoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e944ddd3601db1c2087914d6e64d0964a949ed89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_OfiF), @"mvc.1.0.view", @"/Views/Empleado/OfiF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleado/OfiF.cshtml", typeof(AspNetCore.Views_Empleado_OfiF))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e944ddd3601db1c2087914d6e64d0964a949ed89", @"/Views/Empleado/OfiF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5155aa7ddea1df35968418aac248a8afa1e436f", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_OfiF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab_2_JoseDiaz.Models.EmpleadoViewModel>>
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
#line 3 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
  
    ViewData["Title"] = "OfiF";

#line default
#line hidden
            BeginContext(103, 28, true);
            WriteLiteral("\r\n<h2>OfiF</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf5e858eb8e40c3bb720eac2f509f43", async() => {
                BeginContext(154, 10, true);
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
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 42, false);
#line 16 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(303, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 38, false);
#line 19 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 42, false);
#line 22 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 52, false);
#line 25 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayNameFor(model => model.horas_trabajadas));

#line default
#line hidden
            EndContext();
            BeginContext(603, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 50, false);
#line 28 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayNameFor(model => model.hora_deEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(709, 100, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(841, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(890, 41, false);
#line 38 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(987, 37, false);
#line 41 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1080, 41, false);
#line 44 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1177, 51, false);
#line 47 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayFor(modelItem => item.horas_trabajadas));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1284, 49, false);
#line 50 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.DisplayFor(modelItem => item.hora_deEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 67, true);
            WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1401, 65, false);
#line 53 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1487, 71, false);
#line 54 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1579, 69, false);
#line 55 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\OfiF.cshtml"
}

#line default
#line hidden
            BeginContext(1687, 24, true);
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

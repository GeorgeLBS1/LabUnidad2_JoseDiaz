#pragma checksum "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e8d1c653c8d298104be306a8695921bc118e60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Details), @"mvc.1.0.view", @"/Views/Empleado/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleado/Details.cshtml", typeof(AspNetCore.Views_Empleado_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e8d1c653c8d298104be306a8695921bc118e60", @"/Views/Empleado/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5155aa7ddea1df35968418aac248a8afa1e436f", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab_2_JoseDiaz.Models.EmpleadoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>EmpleadoViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(225, 42, false);
#line 14 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(311, 38, false);
#line 17 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(393, 38, false);
#line 20 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(475, 34, false);
#line 23 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(509, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(553, 42, false);
#line 26 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(595, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(639, 38, false);
#line 29 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(677, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(721, 52, false);
#line 32 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.horas_trabajadas));

#line default
#line hidden
            EndContext();
            BeginContext(773, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(817, 48, false);
#line 35 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.horas_trabajadas));

#line default
#line hidden
            EndContext();
            BeginContext(865, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(909, 50, false);
#line 38 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.hora_deEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(959, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1003, 46, false);
#line 41 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.hora_deEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1097, 68, false);
#line 46 "C:\Users\Jorge\Desktop\Est_GIT\LabUnidad2_JoseDiaz\Lab_2_JoseDiaz\Views\Empleado\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1173, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fd5fe5a2cf402088f776da53f42e10", async() => {
                BeginContext(1195, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1211, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab_2_JoseDiaz.Models.EmpleadoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

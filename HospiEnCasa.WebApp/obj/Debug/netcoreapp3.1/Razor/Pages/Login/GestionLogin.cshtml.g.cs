#pragma checksum "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Login\GestionLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75b2743f661e6a924dcd55dda7d9922acff9be17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.WebApp.Pages.Login.Pages_Login_GestionLogin), @"mvc.1.0.razor-page", @"/Pages/Login/GestionLogin.cshtml")]
namespace HospiEnCasa.WebApp.Pages.Login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\_ViewImports.cshtml"
using HospiEnCasa.WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b2743f661e6a924dcd55dda7d9922acff9be17", @"/Pages/Login/GestionLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad804e27c17b5eb4fefb73f0a3f2cf1858fb0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_GestionLogin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Login\GestionLogin.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Login\GestionLogin.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1 style=\"text-align: center;\">Login</h1>\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-sm-4 offset-sm-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b2743f661e6a924dcd55dda7d9922acff9be173782", async() => {
                WriteLiteral(@"
            <div class=""mb-3"">
                <label for=""exampleInputEmail1"">Email</label>
                <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp""
                    placeholder=""Enter email"">
                <small id=""emailHelp"" class=""form-text text-muted"">Nunca compartiremos tu correo electrónico con nadie más..</small>
            </div>
            <div class=""mb-3"">
                <label for=""exampleInputPassword1"">Password</label>
                <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
            </div>            
            <button type=""submit"" class=""btn btn-primary"">Ingresar</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.WebApp.Pages.Login.GestionLogin> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Login.GestionLogin> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Login.GestionLogin>)PageContext?.ViewData;
        public HospiEnCasa.WebApp.Pages.Login.GestionLogin Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Dhiraj\source\repos\CoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beacfdc2a9c08e2d7163e47dcc1e044ce79b2b78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beacfdc2a9c08e2d7163e47dcc1e044ce79b2b78", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreApp.ViewModels.EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 5, true);
            WriteLiteral("<h1> ");
            EndContext();
            BeginContext(51, 11, false);
#line 2 "C:\Users\Dhiraj\source\repos\CoreApp\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(62, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Dhiraj\source\repos\CoreApp\Views\Home\Index.cshtml"
 foreach (var emp in Model.Employees)
{

#line default
#line hidden
            BeginContext(113, 21, true);
            WriteLiteral("    <div>\r\n\r\n        ");
            EndContext();
            BeginContext(135, 6, false);
#line 8 "C:\Users\Dhiraj\source\repos\CoreApp\Views\Home\Index.cshtml"
   Write(emp.ID);

#line default
#line hidden
            EndContext();
            BeginContext(141, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(152, 8, false);
#line 9 "C:\Users\Dhiraj\source\repos\CoreApp\Views\Home\Index.cshtml"
   Write(emp.Name);

#line default
#line hidden
            EndContext();
            BeginContext(160, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(171, 10, false);
#line 10 "C:\Users\Dhiraj\source\repos\CoreApp\Views\Home\Index.cshtml"
   Write(emp.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(181, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 12 "C:\Users\Dhiraj\source\repos\CoreApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(198, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreApp.ViewModels.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

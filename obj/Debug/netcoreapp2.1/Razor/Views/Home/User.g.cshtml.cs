#pragma checksum "/Users/ricardorivera/cSharp/MVC/viewModelFun/Views/Home/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d054d17d61c5c111930c09daf0c65a368660737e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/User.cshtml", typeof(AspNetCore.Views_Home_User))]
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
#line 1 "/Users/ricardorivera/cSharp/MVC/viewModelFun/Views/_ViewImports.cshtml"
using viewModelFun;

#line default
#line hidden
#line 2 "/Users/ricardorivera/cSharp/MVC/viewModelFun/Views/Home/User.cshtml"
using viewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d054d17d61c5c111930c09daf0c65a368660737e", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ce21e87e6e3b5d780dfa533ad9c7b04016b7cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 85, true);
            WriteLiteral("    <p class=\"text-center\">Sample of a string model:</p>\n    <h1 class=\"text-center\">");
            EndContext();
            BeginContext(139, 15, false);
#line 5 "/Users/ricardorivera/cSharp/MVC/viewModelFun/Views/Home/User.cshtml"
                       Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(154, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(156, 14, false);
#line 5 "/Users/ricardorivera/cSharp/MVC/viewModelFun/Views/Home/User.cshtml"
                                        Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(170, 6, true);
            WriteLiteral("</h1>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\user\Desktop\GitHub\Asp.Net-Core-Mvc-Film-Projesi\MovieApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "350f0c2c3b459ec06272bb488df1302bd35facf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\user\Desktop\GitHub\Asp.Net-Core-Mvc-Film-Projesi\MovieApp\Views\_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\GitHub\Asp.Net-Core-Mvc-Film-Projesi\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"350f0c2c3b459ec06272bb488df1302bd35facf1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301d5cca4a9345895d039cc67d16e7b77f0437f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieCategoryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 6 "C:\Users\user\Desktop\GitHub\Asp.Net-Core-Mvc-Film-Projesi\MovieApp\Views\Home\Index.cshtml"
   Write(Html.Partial("_Menu",Model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-md-9\">\r\n\r\n        ");
#nullable restore
#line 11 "C:\Users\user\Desktop\GitHub\Asp.Net-Core-Mvc-Film-Projesi\MovieApp\Views\Home\Index.cshtml"
   Write(Html.Partial("_Movies",Model.Movies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8db91aafb76519e59d994d1df6931bd23f135aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_myBooks), @"mvc.1.0.view", @"/Views/Books/myBooks.cshtml")]
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
#line 1 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\_ViewImports.cshtml"
using OBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\_ViewImports.cshtml"
using OBS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\_ViewImports.cshtml"
using OBS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8db91aafb76519e59d994d1df6931bd23f135aa", @"/Views/Books/myBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f8bd3c70f1e82532e59fc6b7dea60766184789", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_myBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OBS.Models.MyBooks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
  
    ViewData["Title"] = "My Books";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<style>
    .aboutheading {
        height: 0;
        padding-bottom: 0;
    }

    h1 {
        font-size: 40px;
        padding-bottom: 0;
        margin-bottom: 22px;
    }

    .dimg {
        padding-top: 95px;
    }

    .about {
        padding: 50px 0px;
    }

    .clbl {
        font-size: 25px;
        font-weight: 600;
        font-family: cursive;
    }

    .val {
        font-size: 20px;
        /*font-weight: 600;*/
        font-family: cursive;
    }

    .crinpt {
        border-radius: 15px;
        border: 1px solid #949494;
        padding: 3px 35px;
        margin-left: 65px;
        width: 45%;
    }
</style>


<h1>My Books</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 58 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
           Write(Html.DisplayNameFor(model => model.Book));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 63 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
           Write(Html.DisplayNameFor(model => model.Bought));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 72 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
           Write(Html.DisplayFor(modelItem => item.Book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
#nullable restore
#line 78 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
             if (item.Rating == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Not Rated</td>\r\n");
#nullable restore
#line 81 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <td>\r\n                           ");
#nullable restore
#line 85 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      </td>\r\n");
#nullable restore
#line 87 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            <td>\r\n                ");
#nullable restore
#line 90 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bought));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
           Write(Html.ActionLink("Rate", "Edit", new { id = item.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 94 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 98 "F:\ITI_ASP-MVC\Reado-main\OBS\Views\Books\myBooks.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OBS.Models.MyBooks>> Html { get; private set; }
    }
}
#pragma warning restore 1591

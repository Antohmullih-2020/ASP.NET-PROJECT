#pragma checksum "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f6f8dc2b9e3f9d9d79669583e4b0bfaff550e86"
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
#line 6 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\_ViewImports.cshtml"
using MVC_SETUP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f6f8dc2b9e3f9d9d79669583e4b0bfaff550e86", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed266d3681b1f5e6ba3aece9b1ea8ffb57cc231", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
   
    var bookstory = ViewData["book"] as Bookmodel;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"jumbotron text-center\">\r\n    <h1>Welcom to Antony BookStore Application ");
#nullable restore
#line 7 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
                                          Write(ViewData["property1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>\r\n        Please Enjoy yourself\r\n    </p><br />\r\n    <p>Id= ");
#nullable restore
#line 11 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
      Write(bookstory.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Author= ");
#nullable restore
#line 12 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
          Write(bookstory.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-4"">

            <div class=""card"" style=""width: 18rem;"">
                <img src=""..."" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                </div>
            </div>

        </div>
        <div class=""col-sm-4"">

            <div class=""card"" style=""width: 18rem;"">
                <img src=""..."" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                </div>
            </div>

        </div>
        <div class=""col-sm-4"">
            <div class=""card"" style=""width: 18rem;"">
                <img src=""..."" class=""card-img-top"" alt=""..."">
                ");
            WriteLiteral("<div class=\"card-body\">\r\n                    <p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card\'s content.</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n\r\n            //alert(\"succesfull executed\");\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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

#pragma checksum "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3684c680fa9ea693ec2a61214a31ee41be81a13a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3684c680fa9ea693ec2a61214a31ee41be81a13a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3684c680fa9ea693ec2a61214a31ee41be81a13a2918", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3684c680fa9ea693ec2a61214a31ee41be81a13a3977", async() => {
                WriteLiteral("\r\n    <h1>Welcome to my App</h1>\r\n    <p> ");
#nullable restore
#line 15 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
   Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p> Sum=");
#nullable restore
#line 16 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
        Write(10 + 18);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
      
        int a = 67;
        int b = 87;
        int c = a + b;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h1>");
#nullable restore
#line 23 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
   Write(c);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <h3>Email-antohmulli@outlook.com</h3>\r\n");
                WriteLiteral("\r\n    <h2>Twitter-");
                WriteLiteral("@santozpalmer</h2>\r\n");
#nullable restore
#line 28 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
      
        int k = 29;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
     if (k <= 10)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h1>Hello my name is (IF statement)</h1>\r\n");
#nullable restore
#line 34 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h1>My name is (Else statement)</h1>\r\n");
#nullable restore
#line 38 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
      
        int m = 30;
        int u = 0;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h1>Tenary-");
#nullable restore
#line 46 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
           Write(m == 30 ? u = 20 : u = 7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <h1>Tenary-u =");
#nullable restore
#line 47 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
             Write(u);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
      
        int w = 10;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
     switch (w)
    {
        case 1:

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1>I am 1</h1>\r\n");
#nullable restore
#line 56 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
            break;
        case 2:

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1>I am 2</h1>\r\n");
#nullable restore
#line 58 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
            break;
        case 3:

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1>I am 3</h1>\r\n");
#nullable restore
#line 60 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
            break;
        default:

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1>I am default</h1>\r\n");
#nullable restore
#line 62 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
            break;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
     for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h1>I am For Loop function</h1>\r\n");
#nullable restore
#line 68 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
      
            var list = new List<int>() { 1, 2, 3, 4, 5, 6 };
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
     foreach (var item in list)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h1>");
#nullable restore
#line 77 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
       Write(list);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
#nullable restore
#line 78 "C:\Users\maure\source\repos\MVC-SETUP\MVC-SETUP\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n</html>\r\n");
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

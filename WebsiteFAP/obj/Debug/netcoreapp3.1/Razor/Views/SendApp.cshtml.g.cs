#pragma checksum "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\SendApp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c41bfc8682cee5ab9cd9a3dfcaafaa14b888bee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SendApp), @"mvc.1.0.view", @"/Views/SendApp.cshtml")]
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
#line 7 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\SendApp.cshtml"
using WebsiteFAP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c41bfc8682cee5ab9cd9a3dfcaafaa14b888bee3", @"/Views/SendApp.cshtml")]
    public class Views_SendApp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Applications>
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
#nullable restore
#line 4 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\SendApp.cshtml"
  
    Layout = "/Pages/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c41bfc8682cee5ab9cd9a3dfcaafaa14b888bee33156", async() => {
                WriteLiteral(@"
    <title>FAP - Send applications</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c41bfc8682cee5ab9cd9a3dfcaafaa14b888bee34389", async() => {
                WriteLiteral("\r\n    <h1>Send an application</h1>\r\n");
#nullable restore
#line 16 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\SendApp.cshtml"
     using (Html.BeginForm("SendApp", "Default", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table class=\"table table-bordered\">\r\n            <tr>\r\n                <td>Application type: </td>\r\n                <td>\r\n\r\n");
                WriteLiteral("                    ");
#nullable restore
#line 24 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\SendApp.cshtml"
               Write(Html.DropDownListFor(m => m.TypeId, @ViewBag.typeid as SelectList, "Choose Application Type"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </td>
            </tr>
            <tr>
                <td>Purpose: </td>
                
                <td><textarea name=""Purpose"" class=""form-control"" rows=""7"" cols=""15"" id=""Purpose"" style=""width:786px;""></textarea></td>
            </tr>
            <tr>
                <td>Link Attach: (Upload your file on Google drive and enter link) </td>
                <td>
                    <input type=""url"" name=""FileUploaded"" id=""FileUploaded"" placeholder=""Enter link here...."" size=""80"" />
                    <br />
");
                WriteLiteral(@"                        Template <a href=""https://fap.fpt.edu.vn/temp/pdf/AppTemplate.zip"">Click here</a><br />
                </td>
            </tr>
            <tr>
                <td></td>
                <td><input type=""submit"" name=""ctl00$mainContent$btSubmit"" value=""Send"" id=""ctl00_mainContent_btSubmit"" class=""btn btn-success""></td>
            </tr>
        </table>
");
#nullable restore
#line 47 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\SendApp.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Applications> Html { get; private set; }
    }
}
#pragma warning restore 1591

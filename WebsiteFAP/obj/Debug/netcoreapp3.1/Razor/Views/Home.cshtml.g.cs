#pragma checksum "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b8832ea46ea18735eff29c4367d0bff5bc8bd4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home), @"mvc.1.0.view", @"/Views/Home.cshtml")]
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
#line 7 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
using WebsiteFAP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8832ea46ea18735eff29c4367d0bff5bc8bd4c", @"/Views/Home.cshtml")]
    public class Views_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Students>
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
#line 4 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
  
    Layout = "/Pages/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b8832ea46ea18735eff29c4367d0bff5bc8bd4c3135", async() => {
                WriteLiteral(@"
    <title>FAP - Homepage</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        /* Full-width input fields */
        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        /* Set a style for all buttons */
        button {
            background-color: #04AA6D;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

            button:hover {
                opacity: 0.8;
            }

        /* Ex");
                WriteLiteral(@"tra styles for the cancel button */
        .cancelbtn {
            width: auto;
            padding: 10px 18px;
            background-color: #f44336;
        }

        /* Center the image and position the close button */
        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
            position: relative;
        }

        img.avatar {
            width: 40%;
            border-radius: 50%;
        }

        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 80%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            ba");
                WriteLiteral(@"ckground-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
            padding-top: 60px;
        }

        /* Modal Content/Box */
        .modal-content {
            background-color: #fefefe;
            margin: 5% auto 15% auto; /* 5% from the top, 15% from the bottom and centered */
            border: 1px solid #888;
            width: 40%; /* Could be more or less, depending on screen size */
        }

        /* The Close Button (x) */
        .close {
            position: absolute;
            right: 25px;
            top: 0;
            color: #000;
            font-size: 35px;
            font-weight: bold;
        }

            .close:hover,
            .close:focus {
                color: red;
                cursor: pointer;
            }

        /* Add Zoom Animation */
        .animate {
            -webkit-animation: animatezoom 0.6s;
            animation: animatezoom 0.6s
        }

       ");
                WriteLiteral(" ");
                WriteLiteral("@-webkit-keyframes animatezoom {\r\n            from {\r\n                -webkit-transform: scale(0)\r\n            }\r\n\r\n            to {\r\n                -webkit-transform: scale(1)\r\n            }\r\n        }\r\n\r\n        ");
                WriteLiteral(@"@keyframes animatezoom {
            from {
                transform: scale(0)
            }

            to {
                transform: scale(1)
            }
        }

        /* Change styles for span and cancel button on extra small screens */
        ");
                WriteLiteral("@media screen and (max-width: 300px) {\r\n            span.psw {\r\n                display: block;\r\n                float: none;\r\n            }\r\n\r\n            .cancelbtn {\r\n                width: 100%;\r\n            }\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b8832ea46ea18735eff29c4367d0bff5bc8bd4c8159", async() => {
                WriteLiteral(@"
    <h2>Homepage </h2>

    <div>
        <a type=""button"" class=""btn btn-success"" href=""/Default/SendApp"">Send an application</a>
        &emsp;
        <a type=""button"" class=""btn btn-info"" href=""/Default/ListApp"">View my applications</a>
        &emsp;
        <a type=""button"" class=""btn btn-danger"" href=""/Default/ViewSem"">View my semesters</a>
        &emsp;
        <button class=""btn btn-warning"" onclick=""document.getElementById('id01').style.display='block'"" style=""width:auto;"">View my profile</button>
    </div>

    <div id=""id01"" class=""modal"">

        <form class=""modal-content animate""");
                BeginWriteAttribute("action", " action=\"", 4709, "\"", 4755, 1);
#nullable restore
#line 165 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
WriteAttributeValue("", 4718, Url.Action("EditStudent", "Default"), 4718, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" method=""post"">
            <div class=""imgcontainer"">
                <span onclick=""document.getElementById('id01').style.display='none'"" class=""close"" title=""Close Modal"">&times;</span>
                <img src=""https://www.w3schools.com/howto/img_avatar2.png"" alt=""Avatar"" class=""avatar"">
            </div>

            <div class=""container"">
                <label><b>Student Id</b></label>
                ");
#nullable restore
#line 173 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
           Write(Html.TextBoxFor(m => m.StudentId, new { @class = "form-control", @required = "", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br>\r\n                <div>\r\n                    <label><b>Email</b></label>\r\n                    ");
#nullable restore
#line 177 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", @required = "", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br>\r\n                </div>\r\n                <div>\r\n                    <label><b>Fullname</b></label>\r\n                    ");
#nullable restore
#line 182 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
               Write(Html.TextBoxFor(m => m.FullName, new { @class = "form-control", @required = "", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br>\r\n                </div>\r\n\r\n                <label><b>Phone Number</b></label>\r\n                ");
#nullable restore
#line 187 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
           Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control", @required = "" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br>\r\n                <label><b>Address</b></label>\r\n                ");
#nullable restore
#line 190 "E:\Hanh\fpt\2021-SUMMER\PRN(C#.NET)\final project\WebsiteFAP\WebsiteFAP\Views\Home.cshtml"
           Write(Html.TextBoxFor(m => m.Address, new { @class = "form-control", @required = "" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <br>
                <button type=""submit"">Save profile</button>

            </div>

            <div class=""container"" style=""background-color:#f1f1f1"">
                <button type=""button"" onclick=""document.getElementById('id01').style.display='none'"" class=""cancelbtn"">Cancel</button>
                
            </div>
        </form>
    </div>

    <script>
        // Get the modal
        var modal = document.getElementById('id01');

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Students> Html { get; private set; }
    }
}
#pragma warning restore 1591

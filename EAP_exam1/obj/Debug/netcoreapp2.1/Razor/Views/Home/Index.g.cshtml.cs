#pragma checksum "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc06687e9a83c1dac767349dfb4750d29b8aa784"
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
#line 1 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\_ViewImports.cshtml"
using EAP_exam1;

#line default
#line hidden
#line 2 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\_ViewImports.cshtml"
using EAP_exam1.Models;

#line default
#line hidden
#line 1 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc06687e9a83c1dac767349dfb4750d29b8aa784", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6651872ac833d505d0b2b90d1208e1be992cecd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EAP_exam1.Models.Money>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(123, 740, true);
            WriteLiteral(@"<style>
    .main {
        max-width: 500px;
        margin: auto;
        margin-top: 100px;
        background: #ccc;
        padding: 20px;
    }

    .mainItem {
        margin-bottom: 20px;
    }

        .mainItem label {
            display: inline-block;
            width: 100px;
        }

    .mainItemForm {
        width: 200px;
    }
</style>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""main"">
            <div class=""mainItem"">
                <label>Amount</label>
                <input type=""text"" class=""mainItemForm"" name=""amount""/>
            </div>
            <div class=""mainItem"">
                <label></label>
                <select class=""mainItemForm"">
");
            EndContext();
#line 38 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(936, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(960, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39388f48d1e34581bb2c607790a4f71e", async() => {
                BeginContext(986, 37, false);
#line 40 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\Home\Index.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1032, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\QuyenDo\source\repos\EAP_exam1\EAP_exam1\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1057, 251, true);
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"mainItem\">\r\n                <label></label>\r\n                <input type=\"button\" value=\"Change\" class=\"mainItemForm\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1326, 835, true);
                WriteLiteral(@"

    <script>

        $(document).ready(function () {
            $(document).on(""click"", ""input[type=button]"", function () {
                var url = window.location.origin;
                var data = {
                    ""value"": parseInt($(""input[name='amount']"").val()),
                };
                $.ajax({
                    type: ""POST"",
                    url: url + ""/api/Moneys/"" + $(""select"").val(),
                    contentType: ""application/json"",
                    data: JSON.stringify(data),
                }).done(function (resp) {
                    alert(resp);
                    //window.location.href = window.location.origin;
                }).fail(function (resp) {
                    alert(""Lõi"");
                });
            });
        });
    </script>
    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EAP_exam1.Models.Money>> Html { get; private set; }
    }
}
#pragma warning restore 1591

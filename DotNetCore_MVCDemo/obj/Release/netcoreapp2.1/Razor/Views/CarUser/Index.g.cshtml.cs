#pragma checksum "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59217ccafd2847b5bde9ec250838291ee080cf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarUser_Index), @"mvc.1.0.view", @"/Views/CarUser/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarUser/Index.cshtml", typeof(AspNetCore.Views_CarUser_Index))]
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
#line 1 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\_ViewImports.cshtml"
using DotNetCore_MVCDemo;

#line default
#line hidden
#line 2 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\_ViewImports.cshtml"
using DotNetCore_MVCDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59217ccafd2847b5bde9ec250838291ee080cf8", @"/Views/CarUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f6a44fb456aa134c8d76538902576a28b28114", @"/Views/_ViewImports.cshtml")]
    public class Views_CarUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MODELS.MessageModel<MODELS.CarUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(81, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(82, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "908f3feca3e342b0b821645e81997bb3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(156, 143, true);
            WriteLiteral("\n\n<h2>这是用户个人界面</h2>\n<a class=\"btn-link\" href=\"/test/show\">返回首页</a>\n<a class=\"btn-link\" onclick=\"alert(\'测试按钮\')\">测试返回值</a>\n<p>这是用户登录信息（通过cookie）：");
            EndContext();
            BeginContext(300, 16, false);
#line 11 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                 Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(316, 25, true);
            WriteLiteral(" </p>\n<p>登陆时间（通过redis获取）:");
            EndContext();
            BeginContext(342, 17, false);
#line 12 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
              Write(ViewBag.logintime);

#line default
#line hidden
            EndContext();
            BeginContext(359, 25, true);
            WriteLiteral("</p>\n<p>登录用户（通过Cookie）获取：");
            EndContext();
            BeginContext(385, 16, false);
#line 13 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
               Write(ViewBag.Testname);

#line default
#line hidden
            EndContext();
            BeginContext(401, 358, true);
            WriteLiteral(@"</p>
<input type=""button"" id=""deleteCookie"" value=""退出登录"" class=""btn btn-default"" />
<div>
    <table class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr>
                <td>车牌号</td>
                <td>姓名</td>
                <td>购买时间</td>
                <td>备注信息</td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 26 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
              
                if (Model.Success)
                {
                    foreach (var item in Model.Data)
                    {

#line default
#line hidden
            BeginContext(902, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(964, 10, false);
#line 32 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                           Write(item.CarId);

#line default
#line hidden
            EndContext();
            BeginContext(974, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1013, 9, false);
#line 33 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1061, 15, false);
#line 34 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                           Write(item.CarBuyTime);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1115, 9, false);
#line 35 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                           Write(Model.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 36, true);
            WriteLiteral("</td>\n                        </tr>\n");
            EndContext();
#line 37 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
            BeginContext(1239, 34, true);
            WriteLiteral("                    <p>没有找到数据</p>\n");
            EndContext();
#line 42 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1305, 171, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n<!--JS-->\n<script>\n    $(function () {\n        //调用接口删除Cookie\n        $(\"#deleteCookie\").click(function () {\n            var name = \'");
            EndContext();
            BeginContext(1477, 16, false);
#line 53 "E:\Code\DotNetCore\DotNetCore_MVCDemo\DotNetCore_MVCDemo\Views\CarUser\Index.cshtml"
                   Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1493, 654, true);
            WriteLiteral(@"';
            //alert(name);//临时
            deleteCookie(name);
        })
    })
    function deleteCookie(redisname) {
        $.ajax({
            url: ""/caruser/deletecookie"",
            data: { ""redisname"": redisname },
            dataType: 'json',
            type: 'post',
            success: function (data) {
                if (data.code == 1) {
                    alert(""退出成功"");
                } else {
                    alert(""退出失败"");

                }
                window.location.reload();
            },
            error: function (data) {
                alert(""退出失败："" + data.msg);
            }
        })
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MODELS.MessageModel<MODELS.CarUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

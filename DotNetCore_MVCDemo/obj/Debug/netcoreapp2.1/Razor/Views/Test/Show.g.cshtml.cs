#pragma checksum "E:\Code\gitcode\git_mvc\DotNetCore_MVCDemo\Views\Test\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75de5225a573716b7e4d17d53633e982e853f460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Show), @"mvc.1.0.view", @"/Views/Test/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Show.cshtml", typeof(AspNetCore.Views_Test_Show))]
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
#line 1 "E:\Code\gitcode\git_mvc\DotNetCore_MVCDemo\Views\_ViewImports.cshtml"
using DotNetCore_MVCDemo;

#line default
#line hidden
#line 2 "E:\Code\gitcode\git_mvc\DotNetCore_MVCDemo\Views\_ViewImports.cshtml"
using DotNetCore_MVCDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75de5225a573716b7e4d17d53633e982e853f460", @"/Views/Test/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f6a44fb456aa134c8d76538902576a28b28114", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Code\gitcode\git_mvc\DotNetCore_MVCDemo\Views\Test\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
            BeginContext(37, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(39, 23, false);
#line 5 "E:\Code\gitcode\git_mvc\DotNetCore_MVCDemo\Views\Test\Show.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(62, 73, true);
            WriteLiteral("\n\n<h2>数据展示</h2>\n<h3><a href=\"/home/index\">返回首页</a></h3>\n<br />\n<div>\n    ");
            EndContext();
            BeginContext(135, 691, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ee58790b7641348889b4c2e23362bd", async() => {
                BeginContext(295, 524, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""name"">姓名：</label> 
            <input type=""text"" class=""form-control"" id=""name"" name=""name"" placeholder=""姓名"" />
            <br />
            <br />
            <label for=""age"">年龄：</label>
            <input type=""text"" class=""form-control"" name=""Age"" id=""age"" placeholder=""年龄"" />
            <br /><br />
            <input type=""button"" id=""submit"" class=""btn btn-default"" onclick=""Add()"" value=""提交(AJAX)"" />   
        </div>
        <br />
        <br />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(826, 172, true);
            WriteLiteral("\n    <!--输入表格-->\n</div>\n<a href=\"/Login/index\" class=\"btn btn-success\">登录</a>\n<a href=\"/identity/index\" class=\"btn btn-default\">访问含有身份验证的页面</a>\n<hr />\n<!--搜索框-->\n<div>\n    ");
            EndContext();
            BeginContext(998, 279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eef54d2cbed40be8d9f4bb78e7bd9c8", async() => {
                BeginContext(1024, 246, true);
                WriteLiteral("\n        <div class=\"form-group\">\n            <input type=\"text\" class=\"form-control\" id=\"findname\" name=\"findname\" placeholder=\"查找的姓名\" />\n            <input type=\"button\" class=\"btn btn-success\" onclick=\"find()\" value=\"搜索\" />\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1277, 4496, true);
            WriteLiteral(@"
</div>
<br />
<!--列表-->
<div id=""data"">
    <table class=""table table-bordered table-hover table-striped"">
        <tr>
            <td>ID</td>
            <td>姓名</td>
            <td>年龄</td>
            <td>操作</td>
        </tr>
        <tbody id=""table"">

        </tbody>
    </table>
    <div id=""page"" style=""margin:auto"">
        <span id=""lastpage""><a id=""lastpage"" onclick=""Getdata(1)"">上一页</a></span>
        <span id=""nextpage""><a id=""nextpage"" onclick=""Getdata(2)"">下一页</a></span>
    </div>
</div>
<!--JS-->
<script>
    $(function () {
        Getdata(1); //初始化获取数据
    });
    //获取列表
    function Getdata(page) {
        $(""#findname"").val("""");//清空搜索框
        var trs = """";       //表格容器
        var count = 0;      //计数器
        $.ajax({
            url: ""/test/Getlist"",
            data: { ""pagesize"": page, ""pagecount"": 10 },
            type: ""post"",
            dataType: ""json"",
            success: function (data) {
                $.each(data, function (key, val) {
                    trs += ""<tr><td>");
            WriteLiteral(@""" + val.id + ""</td><td>"" + val.name + ""</td><td>"" + val.age + ""</td><td><a onclick='deletedata("" + val.id + "")'>删除</a></td></tr>"";
                    count++;//记录总数
                });
                $(""#table"").html(trs);//填充数据
                var next = page + 1;
                var last = page - 1;
                //判断页码隐藏上一页
                if (page == 1) {
                    $(""#lastpage"").hide();
                } else {
                    $(""#lastpage"").show().html('<span id=""lastpage""><a id=""lastpage"" onclick=""Getdata(' + last + ')"">上一页</a></span>');
                }
                $(""#nextpage"").html('<span id=""nextpage""><a id=""nextpage"" onclick=""Getdata(' + next + ')"">下一页</a></span>');//显示下一页
                //判断总数隐藏下一页
                if (count < 10 ){
                    $(""#nextpage"").hide();
                } else {
                    $(""#nextpage"").show().html('<span id=""nextpage""><a id=""nextpage"" onclick=""Getdata(' + next + ')"">下一页</a></span>');
                }
                $(""#las");
            WriteLiteral(@"tpage"").html('<span id=""lastpage""><a id=""lastpage"" onclick=""Getdata(' + last + ')"">上一页</a></span>');//显示上一页
                //
            }, error: function (status) {
                alert(status.statusText);
            }
        });
    }
    //添加数据
    function Add() {
        $.ajax({
            url: ""/Test/add"",
            data: { ""name"": $(""#name"").val(), ""age"": $(""#age"").val() },
            dataType: ""json"",
            type: ""post"",
            success: function (data) {
                if (data.code == 1) {
                    alert(""添加成功"");
                    Getdata(1);
                } else {
                    alert(""添加失败：请确认信息是否正确"");
                }
            },
            error: function (error) {
                alert(""添加失败"");
                alert(error);
            }
        });
    }
    //删除数据
    function deletedata(id) {
        if (confirm(""确认删除？"")) {
            $.ajax({
                url: '/test/delete',
                data: { 'id': id },
                type: 'post',");
            WriteLiteral(@"
                datatype: 'json',
                success: function (data) {
                    Getdata(1);
                    alert(data.msg);
                },
                error: function (status) {
                    alert(status.statusText);
                }
            });
        }
    }
    //查找
    function find() {
        var name = $(""#findname"").val();
        var msg = """";
        $.ajax({
            url: '/test/find',
            data: { 'name': name },
            type: 'post',
            datatype: 'json',
            success: function (data) {
                if (data.code == 1) {
                    msg += ""<tr>""
                    msg += ""<td>"" + data.data.id + ""</td> "";
                    msg += ""<td>"" + data.data.name + ""</td>"";
                    msg += ""<td>"" + data.data.age + ""</td>"";
                    msg += ""<td><a onclick='deletedata("" + data.data.id + "")'>删除</a>"";
                    msg +=""&nbsp;&nbsp;""
                    msg += ""<a onclick='Getdata(1)'>返回首页</a></");
            WriteLiteral(@"td >"";
                    msg += ""</tr >"";
                } else {
                    msg += ""<tr><td>-</td><td>未找到有关 "" + name + ""的信息</td><td>-</td><td><a onclick='Getdata(1)'>返回首页</a></td></tr>"";
                }
                $(""#table"").html(msg);
            },
            error: function (status) {
                alert(status.statusText);
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

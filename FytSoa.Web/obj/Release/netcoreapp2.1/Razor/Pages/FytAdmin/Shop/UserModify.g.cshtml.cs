#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9fc5a06c94e38af200c3ea2559f83d4a98a7e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_UserModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Shop/UserModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Shop/UserModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_UserModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Shop
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9fc5a06c94e38af200c3ea2559f83d4a98a7e9", @"/Pages/FytAdmin/Shop/UserModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Shop_UserModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
  
    ViewData["Title"] = "员工管理";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 2964, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b11d6f3d2b6f4ce09733c8f15c40da58", async() => {
                BeginContext(195, 178, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">会员姓名</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"UserName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 373, "\"", 406, 1);
#line 11 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 381, Model.userModel.UserName, 381, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(407, 307, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入会员姓名"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">手机号码</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Mobile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 714, "\"", 745, 1);
#line 17 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 722, Model.userModel.Mobile, 722, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(746, 304, true);
                WriteLiteral(@" lay-verify=""phone"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入手机号码"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">积分</label>
        <div class=""layui-input-block"">
            <input type=""number"" name=""Points""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1050, "\"", 1081, 1);
#line 23 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 1058, Model.userModel.Points, 1058, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1082, 322, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入积分"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">性别</label>
        <div class=""layui-input-block"">
            <input type=""radio"" name=""Sex"" value=""男"" title=""男"" ");
                EndContext();
                BeginContext(1406, 43, false);
#line 29 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
                                                           Write(Model.userModel.Sex == "男" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1450, 66, true);
                WriteLiteral(">\r\n            <input type=\"radio\" name=\"Sex\" value=\"女\" title=\"女\" ");
                EndContext();
                BeginContext(1518, 43, false);
#line 30 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
                                                           Write(Model.userModel.Sex == "女" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1562, 226, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">状态</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"radio\" name=\"Status\" value=\"0\" title=\"正常\" ");
                EndContext();
                BeginContext(1790, 44, false);
#line 36 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
                                                               Write(Model.userModel.Status == 0 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1835, 72, true);
                WriteLiteral(">\r\n            <input type=\"radio\" name=\"Status\" value=\"1\" title=\"账号冻结\" ");
                EndContext();
                BeginContext(1909, 44, false);
#line 37 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
                                                                 Write(Model.userModel.Status == 1 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1954, 249, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\"></label>\r\n        <div class=\"layui-input-block\">\r\n            <button type=\"button\" class=\"layui-btn layui-btn-primary layui-btn-radius\">登录次数：");
                EndContext();
                BeginContext(2204, 26, false);
#line 43 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
                                                                                       Write(Model.userModel.LoginCount);

#line default
#line hidden
                EndContext();
                BeginContext(2230, 105, true);
                WriteLiteral("</button>\r\n            <button type=\"button\" class=\"layui-btn layui-btn-primary layui-btn-radius\">上次登录时间：");
                EndContext();
                BeginContext(2336, 27, false);
#line 44 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
                                                                                         Write(Model.userModel.UpLoginDate);

#line default
#line hidden
                EndContext();
                BeginContext(2363, 374, true);
                WriteLiteral(@"</button>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2737, "\"", 2766, 1);
#line 53 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 2745, Model.userModel.Guid, 2745, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2767, 45, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ShopGuid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2812, "\"", 2845, 1);
#line 54 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 2820, Model.userModel.ShopGuid, 2820, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2846, 47, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"LoginCount\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2893, "\"", 2928, 1);
#line 55 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 2901, Model.userModel.LoginCount, 2901, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2929, 48, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"UpLoginDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2977, "\"", 3013, 1);
#line 56 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 2985, Model.userModel.UpLoginDate, 2985, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3014, 50, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"LastLoginDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3064, "\"", 3102, 1);
#line 57 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\UserModify.cshtml"
WriteAttributeValue("", 3072, Model.userModel.LastLoginDate, 3072, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3103, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(3115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3134, 1199, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/shops/adduser"";
                if ($(""#Guid"").val()) {
                    urls = ""api/shops/edituser"";
                }
                if (data.field.Status === '1') {
                    data.field.status = 1;
                } else {
                    data.field.status = 0;
                }
                os.ajax(urls, data.field, function(res) {
                    if (res.statusCode === 200) {
                        parent.layer.close(index);
                    } else {
                        os.error(res.message);
                    }   
                });
                return false;
   ");
                WriteLiteral("         });\r\n            $(\".btn-open-close\").on(\'click\', function () {\r\n                parent.layer.close(index);\r\n            });            \r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4336, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Shop.UserModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.UserModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.UserModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Shop.UserModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

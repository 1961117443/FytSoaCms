#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cbdafa3ae8506ac8d20b5ce76247a9deb8eaa88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin_Index), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Index.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Pages_FytAdmin_Index), null)]
namespace FytSoa.Web.Pages.FytAdmin
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
#line 2 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cbdafa3ae8506ac8d20b5ce76247a9deb8eaa88", @"/Pages/FytAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/echarts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/macarons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/nprogress.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
  
    ViewData["Title"] = "管理平台";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(173, 1183, true);
            WriteLiteral(@"<div class=""layui-layout layui-layout-admin"">
    <div class=""layui-header"" id=""mainapp"">
        <div class=""layui-logo"">FytErp-SaaS平台</div>
        <ul class=""layui-nav layui-layout-left layui-first-nav"" lay-filter=""topmenu"">
            <li class=""layui-nav-item layui-this"" v-for=""(it,index) in menulist"" v-cloak v-if=""it.layer===1 && index===0""><a href=""javascript:void(0)"" :data-index=""index""><i :class=""'layui-icon '+it.icon""></i>{{it.name}}</a></li>
            <li class=""layui-nav-item"" v-for=""(it,index) in menulist"" v-cloak v-if=""it.layer===1 && index!=0""><a href=""javascript:void(0)"" :data-index=""index""><i :class=""'layui-icon '+it.icon""></i>{{it.name}}</a></li>
        </ul>
        <ul class=""layui-nav layui-layout-right"">
            <li class=""layui-nav-item"">
                <a data-pjax href=""/fytadmin/default""><i class=""layui-icon""></i></a>
            </li>
            <li class=""layui-nav-item"">
                <a href=""/demo/""><i class=""layui-icon""></i><span class=""layui-badge-dot");
            WriteLiteral("\"></span></a>\r\n            </li>\r\n            <li class=\"layui-nav-item\">\r\n                <a href=\"javascript:;\">\r\n                    <span class=\"username\">");
            EndContext();
            BeginContext(1357, 78, false);
#line 24 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
                                      Write(User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Name).Value);

#line default
#line hidden
            EndContext();
            BeginContext(1435, 61, true);
            WriteLiteral(" <i class=\"layui-icon\"></i></span>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1496, "\"", 1587, 1);
#line 25 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
WriteAttributeValue("", 1502, User.Identities.First(u => u.IsAuthenticated).FindFirst(ClaimTypes.Thumbprint).Value, 1502, 85, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1588, 1270, true);
            WriteLiteral(@" class=""layui-nav-img"">
                </a>
                <dl class=""layui-nav-child"">
                    <dd><a data-pjax href=""/fytadmin/sys/admin/"">个人中心</a></dd>
                    <hr />
                    <dd><a href=""/fytadmin/logout/"">退出登录</a></dd>
                </dl>
            </li>
        </ul>
    </div>

    <div class=""layui-side layui-bg-black"" id=""rmapp"">
        <div class=""layui-side-scroll"">
            <ul class=""layui-nav layui-nav-tree fyt-nav-tree layui-hide"" v-for=""(m,mindex) in tmlist"">
                <li class=""layui-nav-item"" v-for=""(it,index) in list"" v-cloak v-if=""it.layer===2 && it.parentGuid===m.guid"">
                    <a class="""" href=""javascript:;""><i :class=""'layui-icon '+it.icon""></i>{{it.name}}</a>
                    <dl class=""layui-nav-child"">
                        <dd v-for=""row in list"" v-if=""row.layer===3 && row.parentGuid===it.guid""><a data-pjax :href=""row.urls"">{{row.name}}</a></dd>
                    </dl>
                </li>
 ");
            WriteLiteral("           </ul>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"layui-body\" id=\"container\">\r\n\r\n    </div>\r\n</div>\r\n<div class=\"load-container load8\">\r\n    <div class=\"load-wall\">\r\n        <div class=\"loader\">Loading...</div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2858, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8e197a871244a6ae042ab1b03ed377", async() => {
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
            BeginContext(2931, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2933, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d818d5488144670aebacd0a68564181", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3003, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3005, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77000481574e4b658960f806cdae672f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3076, 544, true);
            WriteLiteral(@"
<script>
    var main_vm = new Vue({
        el: '#mainapp',
        data: {
            menulist: []
        }
    });
    var rm_vm = new Vue({
        el: '#rmapp',
        data: {
            tmlist: [],
            list: []
        }
    });
    layui.config({
        base: '/themes/js/modules/'
    }).use(['element', 'layer', 'jquery', 'common', 'pjax'], function () {
        var os = layui.common
            , element = layui.element
            , $ = layui.jquery;
        os.get('api/menu/authmenu', { parm: '");
            EndContext();
            BeginContext(3621, 15, false);
#line 81 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Index.cshtml"
                                        Write(Model.adminGuid);

#line default
#line hidden
            EndContext();
            BeginContext(3636, 2123, true);
            WriteLiteral(@"' }, function (res) {
            if (res.statusCode === 200) {
                $.each(res.data, function (index, item) {
                    if (item.layer === 1) {
                        main_vm.menulist.push(item);
                    }
                });
                rm_vm.tmlist = main_vm.menulist;
                rm_vm.list = res.data;
                main_vm.$nextTick(function () {
                    element.render();
                    //定位到菜单
                    $("".layui-bg-black .fyt-nav-tree li a"").each(function () {
                        if (window.location.pathname === $(this).attr('href')) {
                            $("".layui-bg-black .fyt-nav-tree li"").removeClass('layui-nav-itemed');
                            $(this).parents('.layui-nav-item').addClass('layui-nav-itemed');
                            $(this).parent().addClass('layui-this');
                        }
                    });
                    $("".load8"").fadeOut(200);
                    elem");
            WriteLiteral(@"ent.on('nav(topmenu)', function (elem) {
                        var that = $(elem);
                        var topIndex = that.data('index');
                        $(""#rmapp .layui-side-scroll ul"").addClass('layui-hide');
                        $(""#rmapp .layui-side-scroll ul"").eq(topIndex).removeClass('layui-hide');
                    });
                    $(""#rmapp .layui-side-scroll ul"").eq(0).removeClass('layui-hide');
                });
            } else {
                os.error(res.message);
            }
        });
        $.pjax({
            url: '/fytadmin/default',
            container: '#container',
            fragment: '#container'
        });
        $(document).pjax('a', '#container',
            {
                fragment: ""#container"",
                cache: false,
                show: 'fade'
            }
        );
        $(document).on('pjax:start', function () { NProgress.start(); $("".load8"").show(); });
        $(document).on('pjax:end', function");
            WriteLiteral(" () { NProgress.done(); $(\".load8\").fadeOut(200); });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.IndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

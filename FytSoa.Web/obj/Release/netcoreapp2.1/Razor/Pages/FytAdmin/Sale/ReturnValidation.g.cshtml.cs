#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnValidation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78804cfa7f182a8c1a05212e36949fa012f67289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnValidation), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sale/ReturnValidation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sale/ReturnValidation.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sale.Pages_FytAdmin_Sale_ReturnValidation), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sale
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78804cfa7f182a8c1a05212e36949fa012f67289", @"/Pages/FytAdmin/Sale/ReturnValidation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sale_ReturnValidation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("from-app"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/js/modules/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnValidation.cshtml"
  
    ViewData["Title"] = "返货效验";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 236, true);
            WriteLiteral("<style>\r\n    .layui-btn .layui-icon {\r\n        vertical-align: middle;\r\n        top: -2px;\r\n        position: relative;\r\n    }\r\n</style>\r\n<div id=\"app\">\r\n    <div class=\"layui-form list-search\" style=\"margin:0px 12px 0 12px;\">\r\n        ");
            EndContext();
            BeginContext(393, 729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77503622cc53456d9f5ddb9bc178b8ab", async() => {
                BeginContext(442, 569, true);
                WriteLiteral(@"
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""Code"" name=""Code"" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""条形码"">
            </div>
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""Count"" name=""Count"" value=""1"" autocomplete=""off"" placeholder=""数量"">
            </div>
            <div class=""layui-inline"">
                <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
                <button type=""button"" class=""layui-btn"" ");
                EndContext();
                BeginContext(1012, 103, true);
                WriteLiteral("@click=\"validation\" style=\"margin-left:100px;\" v-html=\"btnHtml\"></button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1122, 1101, true);
            WriteLiteral(@"
    </div>
    <div class=""layui-row"">
        <div class=""layui-col-xs12 layui-col-sm12 layui-col-md6"">
            <div class=""list-wall"" style=""padding-top:0px; padding-right:6px;"">
                <table class=""layui-table fyt-table"">
                    <thead>
                        <tr>
                            <th width=""40""><span>序号</span></th>
                            <th><span>条形码</span></th>
                            <th width=""60""><span>数量</span></th>
                            <th width=""100""><span>异常状态</span></th>
                            <th width=""60""><span>操作</span></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for=""it,index in tabList"">
                            <td align=""center"">{{index+1}}</td>
                            <td>{{it.Code}}</td>
                            <td><input type=""number"" v-model=""it.Count"" class=""layui-input"" style=""height:26px;"" /></td>
                ");
            WriteLiteral("            <td v-html=\"it.status\"></td>\r\n                            <td><i ");
            EndContext();
            BeginContext(2224, 514, true);
            WriteLiteral(@"@click=""delTableRow(index)"" class=""layui-icon layui-icon-close"" style=""cursor:pointer""></i></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""layui-col-xs12 layui-col-sm12 layui-col-md6"">
            <div class=""list-wall"" style=""padding-top:0px;padding-left:6px;"">
                <table class=""layui-hide"" id=""tablist"" lay-filter=""usertool""></table>
            </div>
        </div>
    </div>
</div>


");
            EndContext();
            BeginContext(2738, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45333e686368486a8bbc886d998d57fd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2811, 726, true);
            WriteLiteral(@"
<script>
    var cusFun,vm = new Vue({
        el: '#app',
        data: {
            tabList: [
                //{ 'Code': 'abc','status':'', 'Count': '1' }
            ],
            btnHtml:'<i class=""layui-icon layui-icon-read""></i> 确定效验'
        },
        methods: {
            delTableRow: function (index) {
                this.tabList.splice(index,1);
            },
            validation: function () {
                cusFun.startValid();
            }
        }
    });
    layui.config({
        base: '/themes/js/modules/'
    }).use(['table','layer', 'jquery', 'common', 'form'], function () {
        var table = layui.table,form = layui.form, $ = layui.$, os = layui.common,order=""");
            EndContext();
            BeginContext(3538, 15, false);
#line 85 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sale\ReturnValidation.cshtml"
                                                                                    Write(Model.orderGuid);

#line default
#line hidden
            EndContext();
            BeginContext(3553, 4917, true);
            WriteLiteral(@""",resList;
        $(""#Code"").focus();
        /*$(""#Code"").keyup(function () {
            if ($(""#Code"").val().length == 16) {
                var isEx = false;
                for (var i = 0; i < vm.tabList.length; i++) {
                    if (vm.tabList[i].Code == $(""#Code"").val()) {
                        isEx = true;
                        vm.tabList[i].Count = parseInt(vm.tabList[i].Count) + parseInt($(""#Count"").val());
                    }
                }
                if (!isEx) {
                    vm.tabList.push({ 'Code': $(""#Code"").val(), 'Count': $(""#Count"").val() });
                }
                $(""#Code"").val('');
                $(""#Code"").focus();
            }
        });*/
        table.render({
            elem: '#tablist',
            url: '/api/stock/return/goods',
            cols: [
                [
                    { field: 'code', width: 180, title: '条形码', fixed: 'left' },
                    { field: 'counts', width:80, title: '返货数' },
  ");
            WriteLiteral(@"                  { field: 'summary', title: '返货原因' }
                ]
            ],
            page: false,
            limit: 1000,
            id: 'tables',
            where: {
                guid: order,
            },
            done: function (res, curr, count) { 
                resList = res.data;
            }
        });
        cusFun = {
            startValid: function () {
                vm.btnHtml = '<i class=""layui-icon layui-icon-loading-1 layui-icon layui-anim layui-anim-rotate layui-anim-loop""></i> 正在效验';
                var resArr = [];
                //定义临时存放的数组
                var tempOrderList = [];
                var noList = [];
                //先查询不存在右侧内的商品
                $.each(vm.tabList, function (i, item) {
                    var arrRes = cusFun.isExArray(resList, item.Code);
                    if (!arrRes[0]) {
                        noList.push(item);
                    }
                });
                //已入库单完成为标准开始对比新的列表
        ");
            WriteLiteral(@"        $.each(resList, function (i, item) {
                    var arrRes = cusFun.isInArray(vm.tabList, item.code);
                    //如果新的列表中存在已完成的
                    if (arrRes[0]) {
                        console.log(arrRes[1]);
                        if (parseInt(arrRes[1].Count) === item.counts) {
                            tempOrderList.push({ 'Code': item.code, 'status': '<span class=""layui-badge-dot layui-bg-green""></span>', 'Count': arrRes[1].Count });
                        } else {
                            //如果数量不同，也是差异数据状态
                            tempOrderList.push({ 'Code': item.code, 'status': '<span style=""color:red"">数量异常</span>', 'Count': arrRes[1].Count });
                        }
                    } else {
                        //如果不存在，则增加一条差异数据
                        tempOrderList.push({ 'Code': item.code, 'status': '<span style=""color:red"">缺少</span>', 'Count': 0 });
                    }
                });
                vm.tabList = tempOrderList");
            WriteLiteral(@"; console.log(noList);
                if (noList.length > 0) {
                    $.each(noList, function (i, item) {
                        vm.tabList.push({ 'Code': item.Code, 'status': '<span style=""color:red"">不存在</span>', 'Count': item.Count });
                    });
                }
                vm.btnHtml = '<i class=""layui-icon layui-icon-read""></i> 确定效验';
            },
            //判断一个值是否在数组中存在，存在返回true  并返回当前数组对象
            isInArray: function (arr, value) {
                var arrIndex = 0;
                for (var i = 0; i < arr.length; i++) {
                    if (value === arr[i].Code) {
                        return [true, arr[i]];
                    }
                }
                return [false, null];
            },
            isExArray: function (arr, value) {
                var arrIndex = 0;
                for (var i = 0; i < arr.length; i++) {
                    if (value === arr[i].code) {
                        return [true, arr[i]];
      ");
            WriteLiteral(@"              }
                }
                return [false, null];
            }
        }

        //对比提交
        form.on('submit(submit)', function (data) {
            var isEx = false;
            for (var i = 0; i < vm.tabList.length; i++) {
                if (vm.tabList[i].Code == data.field.Code) {
                    isEx = true;
                    vm.tabList[i].Count = parseInt(vm.tabList[i].Count) + parseInt($(""#Count"").val());
                }
            }
            if (!isEx) {
                vm.tabList.push({ 'Code': data.field.Code, 'status': '<span class=""layui-badge-dot layui-bg-green""></span>', 'Count': data.field.Count });
            }
            $(""#Code"").val('');
            $(""#Code"").focus();
            return false;
        });
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sale.ReturnValidationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Projetos\MyFinances\MyFinances\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fd07349d95780ef306fa5de9d313468af5834fe18ea4424470b4e755bfd3aaf2"
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
#line 1 "C:\Projetos\MyFinances\MyFinances\Views\_ViewImports.cshtml"
using MyFinances;

#line default
#line hidden
#line 2 "C:\Projetos\MyFinances\MyFinances\Views\_ViewImports.cshtml"
using MyFinances.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fd07349d95780ef306fa5de9d313468af5834fe18ea4424470b4e755bfd3aaf2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a2c66e113dd1e8063e434ffa58b3b2431eb61b98f48558626bd3241b47f931ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/btc.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("BTC"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 15px; height: auto; vertical-align: middle;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\MyFinances\MyFinances\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Despesas pessoais";


#line default
#line hidden
            BeginContext(55, 104, true);
            WriteLiteral("<h2 style=\"text-align:center\">Despesas pessoais</h2>\r\n<hr /> <br />\r\n<p style=\"text-align:center\">\r\n    ");
            EndContext();
            BeginContext(159, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd07349d95780ef306fa5de9d313468af5834fe18ea4424470b4e755bfd3aaf24639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(262, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(269, 62, false);
#line 9 "C:\Projetos\MyFinances\MyFinances\Views\Home\Index.cshtml"
Write(String.Format("Valor do bitcoin: {0:C}", ViewBag.BitcoinPrice));

#line default
#line hidden
            EndContext();
            BeginContext(331, 4667, true);
            WriteLiteral(@"
</p>
<br />
<div style=""display: flex; justify-content: space-between;"">
    <div id=""container"" style=""width: 48%; height: 400px;""></div>
    <div id=""container2"" style=""width: 48%; height: 400px;""></div>
</div>

<script src=""https://code.highcharts.com/highcharts.js""></script>
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

<script>
    $(document).ready(function () {
        var titleMessage = ""Gastos mensais: "";
        $.ajax({
            type: ""GET"",
            url: ""/Expense/GetExpensePierPeriodMonthly"",
            contentType: ""application/json"",
            dataType: ""json"",
            success: function (result) {
                var keys = Object.keys(result);
                var dateMonthly = new Array();
                var totalSpend = 0.0;
                for (var i = 0; i < keys.length; i++) {
                    var arrL = new Array();
                    arrL.push(keys[i]);
                    arrL.push(result[keys[i]]);
                   ");
            WriteLiteral(@" totalSpend += result[keys[i]];
                    dateMonthly.push(arrL);
                }
                createColumnChart(dateMonthly, titleMessage, totalSpend.toFixed(2), 'container');
            }
        });

        var titleMessage2 = ""Gastos por categoria: "";
        $.ajax({
            type: ""GET"",
            url: ""/Expense/GetExpensePierCategory"",
            contentType: ""application/json"",
            dataType: ""json"",
            success: function (result) {
                var keys = Object.keys(result);
                var dateMonthly = new Array();
                var totalSpend = 0.0;
                for (var i = 0; i < keys.length; i++) {
                    var arrL = new Array();
                    arrL.push(keys[i]);
                    arrL.push(result[keys[i]]);
                    totalSpend += result[keys[i]];
                    dateMonthly.push(arrL);
                }
                createPieChart(dateMonthly, titleMessage2, totalSpend.toFixed(2), '");
            WriteLiteral(@"container2');
            }
        });
    });

    function createColumnChart(sum, titleText, totalSpend, containerId) {
        Highcharts.chart(containerId, {
            chart: {
                type: 'column'
            },
            title: {
                text: titleText + '' + totalSpend
            },
            xAxis: {
                type: 'category',
                labels: {
                    style: {
                        fontSize: '10px',
                        fontFamily: 'Verdana, sans-serif'
                    }
                }
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Valor gasto'
                }
            },
            legend: {
                enabled: false
            },
            tooltip: {
                pointFormat: 'Total expense: <b>{point.y:.2f} </b>'
            },
            series: [{
                type: 'column',
                data: sum,
       ");
            WriteLiteral(@"     }]
        });
    }
    function createPieChart(sum, titleText, totalSpend, containerId) {
        Highcharts.chart(containerId, {
            chart: {
                type: 'pie'
            },
            title: {
                text: titleText + '' + totalSpend
            },
            tooltip: {
                valueSuffix: '%'
            },
            accessibility: {
                point: {
                    valueSuffix: '%'
                }
            },
            plotOptions: {
                series: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: [{
                        enabled: true,
                        distance: 20
                    }, {
                        enabled: true,
                        distance: -40,
                        format: '{point.percentage:.1f}%',
                        style: {
                            fontSize: '1.2em',
                     ");
            WriteLiteral(@"       textOutline: 'none',
                            opacity: 0.7
                        },
                        filter: {
                            operator: '>',
                            property: 'percentage',
                            value: 10
                        }
                    }]
                }
            },
            series: [{
                name: 'Expenses',
                colorByPoint: true,
                data: sum.map(item => ({ name: item[0], y: item[1] }))
            }]
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

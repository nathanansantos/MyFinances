#pragma checksum "C:\Projetos\MyFinances\MyFinances\Views\Expense\_expenseReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3e031a870dd94b03111ac5c786ab5b4af3a05976132ee9b40190805c5b97bc0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense__expenseReport), @"mvc.1.0.view", @"/Views/Expense/_expenseReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Expense/_expenseReport.cshtml", typeof(AspNetCore.Views_Expense__expenseReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3e031a870dd94b03111ac5c786ab5b4af3a05976132ee9b40190805c5b97bc0e", @"/Views/Expense/_expenseReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a2c66e113dd1e8063e434ffa58b3b2431eb61b98f48558626bd3241b47f931ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense__expenseReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3653, true);
            WriteLiteral(@"
<script src=""https://code.highcharts.com/highcharts.js""></script>
<button id=""btnReportMonthly"" class=""btn btn-info"">Relatório Mensal</button>
<button id=""btnReportWeekly"" class=""btn btn-warning"">Relatório Semanal</button>
<div id=""container"" style=""min-width: 400px; height: 400px; margin: 0 auto""></div>
<script>
        $(document).ready(function () {
            $(""#btnReportWeekly"").click(function () {       
            var titleMessage = ""Weekly expense : "";
                $.ajax({
                    type: ""GET"",
                    url: ""/Expense/GetExpensePierPeriodWeekly"",
                    contentType: ""application/json"",
                    dataType: ""json"",
                   
                    success: function (result) {
                        var keys = Object.keys(result);
                        var dateWeekly = new Array();
                        var totalSpend = 0.0;
                        for (var i = 0; i < keys.length; i++) {
                            var a");
            WriteLiteral(@"rrL = new Array();
                            arrL.push(keys[i]);
                            arrL.push(result[keys[i]]);
                            totalSpend += result[keys[i]];
                            dateWeekly.push(arrL);
                        }
                    createCharts(dateWeekly, titleMessage, totalSpend.toFixed(2));
                    }
                })
            })
            $(""#btnReportMonthly"").click(function () {
            var titleMessage = ""Biannual expense: "";
                $.ajax({
                    type: ""GET"",
                    url: ""/Expense/GetExpensePierPeriod"",
                    contentType: ""application/json"",
                    dataType: ""json"",
                    success: function (result) {
                        var keys = Object.keys(result);
                        var dateMonthly = new Array();
                        var totalSpend = 0.0;
                        for (var i = 0; i < keys.length; i++) {
                   ");
            WriteLiteral(@"         var arrL = new Array();
                            arrL.push(keys[i]);
                            arrL.push(result[keys[i]]);
                            totalSpend += result[keys[i]];
                            dateMonthly .push(arrL);
                        }
                    createCharts(dateMonthly, titleMessage, totalSpend.toFixed(2));
                    }
                })
            })
        })
        function createCharts(sum, titleText, totalSpend) {
            Highcharts.chart('container', {
                chart: {
                    type: 'column'
                },
                title: {
                text: titleText + '' + totalSpend
                },
                xAxis: {
                    type: 'category',
                    labels: {
                        rotation: -45,
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif'
                      ");
            WriteLiteral(@"  }
                    }
                },
                yAxis: {
                    min: 0,
                    title: {
                        text: 'Expense value'
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
                }]
            });
        }
</script>");
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

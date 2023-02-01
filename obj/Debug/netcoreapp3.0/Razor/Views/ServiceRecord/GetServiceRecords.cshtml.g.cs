#pragma checksum "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f004427db5cf6de85035bffd7ccc1982291b63f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceRecord_GetServiceRecords), @"mvc.1.0.view", @"/Views/ServiceRecord/GetServiceRecords.cshtml")]
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
#line 1 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/_ViewImports.cshtml"
using mvc_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
using mvc_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f004427db5cf6de85035bffd7ccc1982291b63f", @"/Views/ServiceRecord/GetServiceRecords.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ceb7ff6962b71b2639407d05788c3f1eaf62fec", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceRecord_GetServiceRecords : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 98%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ServiceRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewServiceRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
  
    var myRecords = ViewBag.ServiceRecords;
    var myCar = ViewBag.Car;
    decimal totalCost = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
#service-records-grid {
  font-family: Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#service-records-grid td, #service-records-grid th {
  border: 1px solid #ddd;
  padding: 8px;
}

#service-records-grid tr:nth-child(even){background-color: #f2f2f2;}

#service-records-grid tr:hover {background-color: #ddd;}

#service-records-grid th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: center;
  background-color: #04AA6D;
  color: white;
}
.small-column{
width: 12%;
text-align: center;
}
.money-small-column{
width: 16%;
text-align: right;
}


.large-column{
width: 60%;
text-align: left;
}

.large-column-total{
width: 84%;
text-align: right;
font: bold;
border: none;
}
.small-column-total-cost{
width: 16%;
text-align: right;
}
.small-column-total-cost-text{
color: red;
}


.total-row{
    background-color: #d9faeb;
}



</style>

<div style=""width: 80rem;"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f004427db5cf6de85035bffd7ccc1982291b63f5503", async() => {
                WriteLiteral(@"
        <div style = ""width: 98%;display: flex;"">
            <input style = ""width: 19%;margin: 0.5%;"" type=""date"" id=""Date"" name=""Date"" placeholder = ""Date""><br><br>
            <input style = ""width: 19%;margin: 0.5%;"" type=""number"" id=""Mileage"" name=""Mileage"" placeholder = ""Mileage""><br><br>
            <input style = ""width: 19%;margin: 0.5%;"" type=""number"" id=""EstimateCost"" name=""EstimateCost"" placeholder = ""Estimate Cost""><br><br>
            <input style = ""width: 60%;margin: 0.5%;"" type=""textarea"" id=""Description"" name=""Description"" placeholder = ""Description"">
            <input  type=""hidden"" id=""UserId"" name=""UserId""");
                BeginWriteAttribute("value", " value=\"", 1778, "\"", 1799, 1);
#nullable restore
#line 77 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
WriteAttributeValue("", 1786, myCar.UserId, 1786, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \n            <input  type=\"hidden\" id=\"VehicleId\" name=\"VehicleId\"");
                BeginWriteAttribute("value", " value=\"", 1868, "\"", 1885, 1);
#nullable restore
#line 78 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
WriteAttributeValue("", 1876, myCar.Id, 1876, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        </div>\n        <div style = \"width: 99%;\">\n            <input style = \"width: 98%;margin: 0.5%;\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2006, "\"", 2074, 8);
                WriteAttributeValue("", 2014, "Add", 2014, 3, true);
                WriteAttributeValue(" ", 2017, "a", 2018, 2, true);
                WriteAttributeValue(" ", 2019, "Service", 2020, 8, true);
                WriteAttributeValue(" ", 2027, "Record", 2028, 7, true);
                WriteAttributeValue(" ", 2034, "to", 2035, 3, true);
#nullable restore
#line 81 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
WriteAttributeValue(" ", 2037, myCar.Year, 2038, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
WriteAttributeValue(" ", 2049, myCar.Make, 2050, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
WriteAttributeValue(" ", 2061, myCar.Model, 2062, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        </div>\n    ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div style=""width: 96%;background-color:#fff3e6 ;"">

            <table id=""service-records-grid"">
                <thead>
                    <tr>
                        <th class = ""small-column"">Date</th>
                        <th class = ""small-column"">Mileage</th>
                        <th class = ""large-column"">Description</th>
                        <th class = ""money-small-column"">Estimated Cost($)</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 97 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
                     foreach(ServiceRecord record in myRecords){
                            totalCost += Convert.ToDecimal(@record.EstimateCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td class = \"small-column\">");
#nullable restore
#line 100 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
                                                      Write(record.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td class = \"small-column\">");
#nullable restore
#line 101 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
                                                      Write(record.Mileage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td class = \"large-column\">");
#nullable restore
#line 102 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
                                                      Write(record.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td class = \"money-small-column\">");
#nullable restore
#line 103 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
                                                            Write(record.EstimateCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 105 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>

             <table id=""service-records-grid"">
                <tr class = ""total-row"">
                    <td class = ""large-column-total""><span style = ""text-align: right;"">Total($)</span></td>
                    <td class = ""small-column-total-cost""><span class = ""small-column-total-cost-text"">");
#nullable restore
#line 112 "/Users/burakkocak/Development/dotnetmvc-project/mvc-project/Views/ServiceRecord/GetServiceRecords.cshtml"
                                                                                                  Write(totalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                </tr>\n            </table>\n    </div>\n\n\n\n</div>");
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

#pragma checksum "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c27874befdb03ba8ba9008f86c8e63461d3b1138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_SearchForCars), @"mvc.1.0.view", @"/Views/Car/SearchForCars.cshtml")]
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
#line 1 "C:\Grandcircus\CarDealership\CarDealership\Views\_ViewImports.cshtml"
using CarDealership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Grandcircus\CarDealership\CarDealership\Views\_ViewImports.cshtml"
using CarDealership.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27874befdb03ba8ba9008f86c8e63461d3b1138", @"/Views/Car/SearchForCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ecfa5f6b6d38913e730c0bc55bcddbaea51d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_SearchForCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarDealership.Models.Cars>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<h1 style=""text-align:center; color:crimson;"">Cars matching your search!</h1>
<br>
<br>
<style>
    table {
        border-collapse: collapse;
        width: 100%;
    }

    th, td {
        text-align: left;
        padding: 8px;
    }

    tr:nth-child(even) {
        background-color: silver;
    }
</style>
<table id=""carTable"" style=""width:100%"">
    <thead>

        <tr>
            <th onclick=""sortTable(0)"" style=""cursor:pointer"">Make</th>
            <th onclick=""sortTable(1)"" style=""cursor:pointer"">Model</th>
            <th onclick=""sortTable(2)"" style=""cursor:pointer"">Year</th>
            <th onclick=""sortTable(3)"" style=""cursor:pointer"">Color</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 34 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
         foreach (var car in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
               Write(car.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
               Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
               Write(car.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
               Write(car.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button style=\"background-color:cornflowerblue;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1086, "\"", 1143, 5);
            WriteAttributeValue("", 1096, "document.location", 1096, 17, true);
            WriteAttributeValue(" ", 1113, "=", 1114, 2, true);
            WriteAttributeValue(" ", 1115, "\'/Car/UpdateCar?id=", 1116, 20, true);
#nullable restore
#line 42 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
WriteAttributeValue("", 1135, car.Id, 1135, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1142, "\'", 1142, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Update car</button>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1234, "\"", 1266, 2);
            WriteAttributeValue("", 1241, "/Car/DeleteCar?id=", 1241, 18, true);
#nullable restore
#line 45 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
WriteAttributeValue("", 1259, car.Id, 1259, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""deleteBtn"" class=""btn bg-danger mr-1""
                       onclick=""return confirm('Are you sure you want to remove this car?');"">
                        <i class=""fas fa-trash-alt text-white""></i>Remove Car
                    </a>

                </td>

            </tr>
");
#nullable restore
#line 53 "C:\Grandcircus\CarDealership\CarDealership\Views\Car\SearchForCars.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </tbody>
</table>
<br />
<button style=""background-color:crimson;"" onclick=""document.location = '/Car/SearchIndex'"">Back to Home</button>


<script>
    function sortTable(n) {
        var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
        table = document.getElementById(""carTable"");
        switching = true;
        dir = ""asc"";
        while (switching) {
            switching = false;
            rows = table.rows;

            for (i = 1; i < (rows.length - 1); i++) {
                shouldSwitch = false;
                x = rows[i].getElementsByTagName(""TD"")[n];
                y = rows[i + 1].getElementsByTagName(""TD"")[n];
                if (dir == ""asc"") {
                    if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                        shouldSwitch = true;
                        break;
                    }
                } else if (dir == ""desc"") {
                    if (x.innerHTML.toLowerCase() < y.innerHTML.toLowe");
            WriteLiteral(@"rCase()) {
                        shouldSwitch = true;
                        break;
                    }
                }
            }
            if (shouldSwitch) {
                rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                switching = true;
                switchcount++;
            } else {
                if (switchcount == 0 && dir == ""asc"") {
                    dir = ""desc"";
                    switching = true;
                }
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarDealership.Models.Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591

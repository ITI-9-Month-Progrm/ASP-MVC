#pragma checksum "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c5da859c93f769c6e5977f38c1cadde4e2be10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Index), @"mvc.1.0.view", @"/Views/Car/Index.cshtml")]
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
#line 1 "D:\ASP-MVC\Day01Core\Lab07\Views\_ViewImports.cshtml"
using Lab07;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP-MVC\Day01Core\Lab07\Views\_ViewImports.cshtml"
using Lab07.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c5da859c93f769c6e5977f38c1cadde4e2be10", @"/Views/Car/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed6e8b1e4470205274dee0f2a589cffd9443ca5", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
  
    ViewBag.Title = "GetAllCars";
    var carList = (List<Lab07.Models.Car>)ViewBag.carsList;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>GetAllCars</h2>

<Button class=""btn btn-primary ""><a href=""/Car/CreateCar/"" class=""text-uppercase"" style=""color:white"">Create</a></Button>


<table class=""table-bordered table table-striped table-hover"">
    <thead style=""background-color:darkgray;font-weight:900;text-align:center"">
        <tr>

            <td>ID</td>
            <td>Color</td>
            <td>Model</td>
            <td>Manfacture</td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
         foreach (var car in carList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n\r\n                <td>");
#nullable restore
#line 31 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
               Write(car.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 33 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
               Write(car.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
               Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
               Write(car.Manfacture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 890, "\"", 921, 2);
            WriteAttributeValue("", 897, "/Car/CarDetails/", 897, 16, true);
#nullable restore
#line 36 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
WriteAttributeValue("", 913, car.Num, 913, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 963, "\"", 991, 2);
            WriteAttributeValue("", 970, "/Car/EditCar/", 970, 13, true);
#nullable restore
#line 37 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
WriteAttributeValue("", 983, car.Num, 983, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1060, 2);
            WriteAttributeValue("", 1037, "/Car/DeleteCar/", 1037, 15, true);
#nullable restore
#line 38 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
WriteAttributeValue("", 1052, car.Num, 1052, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "D:\ASP-MVC\Day01Core\Lab07\Views\Car\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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

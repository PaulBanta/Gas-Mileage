#pragma checksum "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e3e9dc29a26f89169d26b4cccb1168717f4650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fillup_DeleteDetailsPartial), @"mvc.1.0.view", @"/Views/Fillup/DeleteDetailsPartial.cshtml")]
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
#line 1 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\_ViewImports.cshtml"
using GasMileage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e3e9dc29a26f89169d26b4cccb1168717f4650", @"/Views/Fillup/DeleteDetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698ee4ab109b64fdf6b4b8b4c0bc62adf265559c", @"/Views/_ViewImports.cshtml")]
    public class Views_Fillup_DeleteDetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fillup>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tbody>\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Date: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 6 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Gallons: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 11 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.Gallons.ToString("N3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Total Cost: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 16 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.TotalCost.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Odometer: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 21 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.Odometer.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Trip Odometer: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 26 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.TripOdometer.ToString("N1"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Zip Code: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 31 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr> <td class=\"pl-2 pr-2\" colspan=\"2\"> <hr /> </td> </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Days Since Last Fillup: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 38 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.DaysSinceLastFillup.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Gallons Per Day: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 43 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.GallonsPerDay.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Miles Per Day: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 48 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.MilesPerDay.ToString("N1"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Miles Per Gallon: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 53 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.MilesPerGallon.ToString("N1"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Price Per Day: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 58 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.PricePerDay.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Price Per Gallon: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 63 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.PricePerGallon.ToString("C3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n\r\n   <tr>\r\n      <th class=\"pr-1 text-right\"> Price Per Mile: </th>\r\n      <td class=\"pl-1\"> ");
#nullable restore
#line 68 "C:\Users\erau\source\repos\GasMileage\Code\GasMileage\Views\Fillup\DeleteDetailsPartial.cshtml"
                   Write(Model.PricePerMile.ToString("C3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n   </tr>\r\n</tbody>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fillup> Html { get; private set; }
    }
}
#pragma warning restore 1591
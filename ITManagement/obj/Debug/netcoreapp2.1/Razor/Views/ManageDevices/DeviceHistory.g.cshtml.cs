#pragma checksum "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93c0415aee23bf1a1e0fcae6f8590c74c9022858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageDevices_DeviceHistory), @"mvc.1.0.view", @"/Views/ManageDevices/DeviceHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageDevices/DeviceHistory.cshtml", typeof(AspNetCore.Views_ManageDevices_DeviceHistory))]
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
#line 1 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\_ViewImports.cshtml"
using ITManagement;

#line default
#line hidden
#line 2 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\_ViewImports.cshtml"
using ITManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93c0415aee23bf1a1e0fcae6f8590c74c9022858", @"/Views/ManageDevices/DeviceHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0f013920f1d6b5866185b6f45c2fda83c66d51", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageDevices_DeviceHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ITManagement.Models.DeviceHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
  
    ViewData["Title"] = "Device History";

#line default
#line hidden
            BeginContext(100, 419, true);
            WriteLiteral(@"
<h2>Device History</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Device ID</th>
            <th>Device Name</th>
            <th>Category ID</th>
            <th>Category Name</th>
            <th>User ID</th>
            <th>User Name</th>
            <th>Updated By</th>
            <th>Updated At</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 24 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(568, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(607, 13, false);
#line 27 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.DeviceId);

#line default
#line hidden
            EndContext();
            BeginContext(620, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(648, 15, false);
#line 28 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.DeviceName);

#line default
#line hidden
            EndContext();
            BeginContext(663, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(691, 15, false);
#line 29 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(706, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(734, 17, false);
#line 30 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(751, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(779, 11, false);
#line 31 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(790, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(818, 13, false);
#line 32 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(831, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(859, 14, false);
#line 33 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.UpdatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(873, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(901, 14, false);
#line 34 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.UpdatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(915, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(943, 16, false);
#line 35 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(959, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\GargiSawaria\Downloads\IT_admin-main\IT_admin-main\ITManagement\Views\ManageDevices\DeviceHistory.cshtml"
        }

#line default
#line hidden
            BeginContext(996, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ITManagement.Models.DeviceHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
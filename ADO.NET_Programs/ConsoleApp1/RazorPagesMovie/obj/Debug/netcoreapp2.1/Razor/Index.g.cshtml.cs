#pragma checksum "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "024301da13a9e2a0fa9ef6294cce8a6694849faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Index), @"mvc.1.0.razor-page", @"/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Index.cshtml", typeof(AspNetCore.Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"024301da13a9e2a0fa9ef6294cce8a6694849faf", @"/Index.cshtml")]
    public class Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 156, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(242, 50, false);
#line 17 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 56, false);
#line 20 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 50, false);
#line 23 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Genre));

#line default
#line hidden
            EndContext();
            BeginContext(510, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(566, 50, false);
#line 26 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(616, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
 foreach (var item in Model.Movie) {

#line default
#line hidden
            BeginContext(740, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(789, 40, false);
#line 35 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(829, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(885, 46, false);
#line 38 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(987, 40, false);
#line 41 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1083, 40, false);
#line 44 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1198, "\"", 1221, 1);
#line 47 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
WriteAttributeValue("", 1213, item.ID, 1213, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1222, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1274, "\"", 1297, 1);
#line 48 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
WriteAttributeValue("", 1289, item.ID, 1289, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1298, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1352, "\"", 1375, 1);
#line 49 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
WriteAttributeValue("", 1367, item.ID, 1367, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1376, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "F:\ADO.NET_Programs\ConsoleApp1\RazorPagesMovie\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1426, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.IndexModel>)PageContext?.ViewData;
        public RazorPagesMovie.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

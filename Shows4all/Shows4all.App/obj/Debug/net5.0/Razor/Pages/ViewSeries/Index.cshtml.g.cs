#pragma checksum "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\ViewSeries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e97b73d06c41b27941a0416663a5f1054622d29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shows4all.App.Pages.ViewSeries.Pages_ViewSeries_Index), @"mvc.1.0.razor-page", @"/Pages/ViewSeries/Index.cshtml")]
namespace Shows4all.App.Pages.ViewSeries
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
#line 1 "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\_ViewImports.cshtml"
using Shows4all.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e97b73d06c41b27941a0416663a5f1054622d29", @"/Pages/ViewSeries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe281a62d7d559a5ff7d91a4faf0c9578d2d67b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ViewSeries_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\ViewSeries\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Series</h1>\r\n\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 13 "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\ViewSeries\Index.cshtml"
     foreach (var serie in Model.Serie)
    {

        //var photoPath = "~/images/" + ("FIVEO.jpg");
        //var photoPath = "~/images/" + ("HOW.jpg");


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card m-3\" style=\" min-width: 18rem; max-width:30.5%;\">\r\n        <div class=\"card-header\">\r\n            <h3>");
#nullable restore
#line 21 "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\ViewSeries\Index.cshtml"
           Write(serie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n\r\n");
            WriteLiteral("\r\n        <div class=\"card-footer text-center\">\r\n           <p><a href=\"/comments/index\">Comments</a></p>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\ViewSeries\Index.cshtml"

        

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shows4all.App.Pages.ViewSeries.IndexModelClient> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shows4all.App.Pages.ViewSeries.IndexModelClient> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shows4all.App.Pages.ViewSeries.IndexModelClient>)PageContext?.ViewData;
        public Shows4all.App.Pages.ViewSeries.IndexModelClient Model => ViewData.Model;
    }
}
#pragma warning restore 1591

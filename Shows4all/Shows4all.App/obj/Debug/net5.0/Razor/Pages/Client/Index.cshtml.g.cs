#pragma checksum "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0d80cca92e8f308f69edb717411ae0f31979c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shows4all.App.Pages.Client.Pages_Client_Index), @"mvc.1.0.razor-page", @"/Pages/Client/Index.cshtml")]
namespace Shows4all.App.Pages.Client
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0d80cca92e8f308f69edb717411ae0f31979c6", @"/Pages/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe281a62d7d559a5ff7d91a4faf0c9578d2d67b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Client_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\temp\repositorio\Shows4all\Shows4all\Shows4all.App\Pages\Client\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>User Menu</h2>\r\n\r\n<hr />\r\n<br />\r\n<p><a href=\"/viewseries/index\">Series</a></p>\r\n\r\n<p><a href=\"/rentals\">Rentals</a></p>\r\n\r\n<p><a href=\"/creditcards/index\">Add Credit Card</a></p>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shows4all.App.Pages.Client.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shows4all.App.Pages.Client.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shows4all.App.Pages.Client.IndexModel>)PageContext?.ViewData;
        public Shows4all.App.Pages.Client.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

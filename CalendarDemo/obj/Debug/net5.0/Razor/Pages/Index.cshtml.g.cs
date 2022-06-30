#pragma checksum "F:\Projects\UpWork\calendardemo\CalendarDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "863a032baa7753ef449a6a46a719fc03ac5b9020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CalendarDemo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace CalendarDemo.Pages
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
#line 1 "F:\Projects\UpWork\calendardemo\CalendarDemo\Pages\_ViewImports.cshtml"
using CalendarDemo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863a032baa7753ef449a6a46a719fc03ac5b9020", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23a962ba62ac98d9c22f927d6f37a289a06f0029", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Projects\UpWork\calendardemo\CalendarDemo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .template-wrap {
        width: 100%;
    }
    .template-wrap .subject {
        margin: 0 5px;
    }
    .template-wrap .time {
        margin: 0 5px;
    }
</style>

<div class=""row"">
    <div class=""col-lg-10 col-md-9 control-section"">
        <div class=""content-wrapper"">
            <div id=""Schedule""></div>
        </div>
    </div>

    <div class=""col-lg-2 col-md-3 control-section"">
        <div class=""d-grid gap-2"">
            <button id=""print-btn"" class=""btn btn-primary"" type=""button"">Print</button>
        </div>
    </div>
</div>

<script id=""apptemplate"" type=""text/x-template"">
    <div class=""template-wrap badge"" style=""background:${CategoryColor}"">
        <div class=""subject"">${Subject}</div>
        <div class=""time"">${PhysicianName}</div>
    </div>

</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"js/calendar_data.js\"></script>\r\n    <script src=\"js/calendar_demo.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

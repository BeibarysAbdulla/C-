#pragma checksum "C:\Users\м1\Desktop\C#\lab10-master\Gradebook\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3fc42f87f91462e80c822c3064fad7926b1df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3fc42f87f91462e80c822c3064fad7926b1df7", @"/Views/Main/Index.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 class=""title is-1"">Wellcome to lab 10</h1>
<form method=""POST"">
    <div class=""form-group"">
        <label for=""firstName"">Your Name</label>
        <input type=""text"" class=""form-control"" id=""firstName"" name=""name"" placeholder=""Name"">
        <input type=""text"" class=""form-control"" id=""lastName"" name=""surname"" placeholder=""Surname"">
    </div>
    <div class=""form-group"">
        <label for=""firstName"">Date of Birth</label>
        <input type=""number"" class=""form-control"" name=""month"" placeholder=""Month"">
        <input type=""number"" class=""form-control"" name=""day"" placeholder=""Day"">
        <input type=""number"" class=""form-control"" name=""year"" placeholder=""Year"">
    </div>
    <div class=""form-group"">
        <label for=""firstName"">Group Number</label>
        <input type=""number"" id=""group"" class=""form-control"" name=""group"" placeholder=""4-digit group number"">
    </div>
    <br />
    <div>
        <input type=""submit"" />
    </div>
</form>
<br/>

Generated ID: ");
#nullable restore
#line 25 "C:\Users\м1\Desktop\C#\lab10-master\Gradebook\Views\Main\Index.cshtml"
         Write(ViewData["GenId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n       \n");
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

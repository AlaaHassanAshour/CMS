#pragma checksum "C:\Users\LTC2021\Source\Repos\CMS\CMS.API\Views\PostDbEntities\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "101d408bb9a5c1a294d9337777444b4cce7715ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PostDbEntities_Create), @"mvc.1.0.view", @"/Views/PostDbEntities/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"101d408bb9a5c1a294d9337777444b4cce7715ea", @"/Views/PostDbEntities/Create.cshtml")]
    public class Views_PostDbEntities_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Data.Models.PostDbEntity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LTC2021\Source\Repos\CMS\CMS.API\Views\PostDbEntities\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>PostDbEntity</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Title"" class=""control-label""></label>
                <input asp-for=""Title"" class=""form-control"" />
                <span asp-validation-for=""Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Body"" class=""control-label""></label>
                <input asp-for=""Body"" class=""form-control"" />
                <span asp-validation-for=""Body"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryId"" class=""control-label""></label>
                <select asp-for=""CategoryId"" class =""form-control"" asp-items=""ViewBag.CategoryId""></select>
            </div>
            <div class=""for");
            WriteLiteral(@"m-group"">
                <label asp-for=""CreatedAt"" class=""control-label""></label>
                <input asp-for=""CreatedAt"" class=""form-control"" />
                <span asp-validation-for=""CreatedAt"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedAt"" class=""control-label""></label>
                <input asp-for=""UpdatedAt"" class=""form-control"" />
                <span asp-validation-for=""UpdatedAt"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""IsDelete"" /> ");
#nullable restore
#line 41 "C:\Users\LTC2021\Source\Repos\CMS\CMS.API\Views\PostDbEntities\Create.cshtml"
                                                                     Write(Html.DisplayNameFor(model => model.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\LTC2021\Source\Repos\CMS\CMS.API\Views\PostDbEntities\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Data.Models.PostDbEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
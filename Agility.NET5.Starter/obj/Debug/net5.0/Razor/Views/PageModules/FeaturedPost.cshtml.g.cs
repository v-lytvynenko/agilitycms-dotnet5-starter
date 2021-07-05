#pragma checksum "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f466d0a19d18e71c2a9529d7be5e92744bc85907"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PageModules_FeaturedPost), @"mvc.1.0.view", @"/Views/PageModules/FeaturedPost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f466d0a19d18e71c2a9529d7be5e92744bc85907", @"/Views/PageModules/FeaturedPost.cshtml")]
    public class Views_PageModules_FeaturedPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Agility.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script>
    function redirect(url) {
        console.log(url);
        window.location.href = `/blog/${url}`;
    }
</script>

<div class=""relative px-8 mb-8"">
    <div class=""flex flex-col sm:flex-row max-w-screen-xl mx-auto pt-8 group"">
        <div class=""sm:w-1/2 lg:w-2/3 sm:rounded-t-none sm:rounded-l-lg relative"">
                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 381, "\"", 414, 3);
            WriteAttributeValue("", 391, "redirect(\'", 391, 10, true);
#nullable restore
#line 13 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
WriteAttributeValue("", 401, Model.Slug, 401, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 412, "\')", 412, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"cursor-pointer\">\r\n                    <div class=\"h-64 sm:h-96 relative overflow-hidden\">\r\n                        <img");
            BeginWriteAttribute("src", " \r\n                            src=", 542, "", 593, 1);
#nullable restore
#line 16 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
WriteAttributeValue("", 577, Model.Image.Url, 577, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                            class=\"object-cover object-center rounded-t-lg sm:rounded-l-lg sm:rounded-t-none object-fill\"");
            BeginWriteAttribute("alt", "\r\n                            alt=", 717, "", 769, 1);
#nullable restore
#line 18 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
WriteAttributeValue("", 751, Model.Image.Label, 751, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                        />
                    </div>
                </a>
        </div>
        <div class=""sm:w-1/2 lg:w-1/3 bg-gray-100 p-8 border-2 border-t-0 rounded-b-lg sm:rounded-bl-none sm:rounded-r-lg sm:border-t-2 sm:border-l-0 relative"">
            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1041, "\"", 1074, 3);
            WriteAttributeValue("", 1051, "redirect(\'", 1051, 10, true);
#nullable restore
#line 24 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
WriteAttributeValue("", 1061, Model.Slug, 1061, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1072, "\')", 1072, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"cursor-pointer\">\r\n                <div class=\"font-display uppercase text-primary-500 text-xs font-bold tracking-widest leading-loose after:content\">\r\n                    ");
#nullable restore
#line 26 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
               Write(Model.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"border-b-2 border-primary-500 w-8\"></div>\r\n                <div class=\"mt-4 uppercase text-gray-600 italic font-semibold text-xs\">\r\n                    ");
#nullable restore
#line 30 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
               Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <h2 class=\"font-display text-secondary-500 mt-1 font-black text-2xl group-hover:text-primary-500 transition duration-300\">\r\n                    ");
#nullable restore
#line 33 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <p class=\"text-sm mt-3 leading-loose text-gray-600 font-medium\">\r\n                    ");
#nullable restore
#line 36 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\FeaturedPost.cshtml"
               Write(Html.Raw(Model.Content.Substring(0,250)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...        \r\n                </p>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Agility.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591

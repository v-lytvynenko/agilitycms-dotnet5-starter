#pragma checksum "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab7d7838123111c3cdcc1406e32784d4dba8406f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PageModules_TextBlockWithImage), @"mvc.1.0.view", @"/Views/PageModules/TextBlockWithImage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7d7838123111c3cdcc1406e32784d4dba8406f", @"/Views/PageModules/TextBlockWithImage.cshtml")]
    public class Views_PageModules_TextBlockWithImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Agility.Models.TextBlockWithImage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"relative px-8\">\r\n    <div class=\"flex flex-col md:flex-row justify-between max-w-screen-xl mx-auto py-20 md:py-24 items-center\">\r\n        <div class=\"md:w-6/12 flex-shrink-0 relative\">\r\n");
#nullable restore
#line 6 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
              
                if (Model.PrimaryButton != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=", 349, "", 380, 1);
#nullable restore
#line 9 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue("", 355, Model.PrimaryButton.Href, 355, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-label", " aria-label=\"", 380, "\"", 413, 3);
            WriteAttributeValue("", 393, "Go", 393, 2, true);
            WriteAttributeValue(" ", 395, "to", 396, 3, true);
#nullable restore
#line 9 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue(" ", 398, Model.Tagline, 399, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                        <img");
            BeginWriteAttribute("src", " src=", 446, "", 488, 1);
#nullable restore
#line 10 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue("", 451, Uri.EscapeUriString(Model.Image.Url), 451, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 488, "", 511, 1);
#nullable restore
#line 10 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue("", 493, Model.Image.Label, 493, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 768px; height: 420px;\" class=\"rounded-lg object-cover object-center cursor-pointer\" />\r\n                    </a>\r\n");
#nullable restore
#line 12 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=", 724, "", 766, 1);
#nullable restore
#line 15 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue("", 729, Uri.EscapeUriString(Model.Image.Url), 729, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 766, "", 789, 1);
#nullable restore
#line 15 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue("", 771, Model.Image.Label, 771, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 768px; height: 420px;\" class=\"rounded-lg object-cover object-center\" />\r\n");
#nullable restore
#line 16 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 939, "\"", 1078, 4);
            WriteAttributeValue("", 947, "md:w-6/12", 947, 9, true);
            WriteAttributeValue(" ", 956, "mt-16", 957, 6, true);
            WriteAttributeValue(" ", 962, "md:mt-0", 963, 8, true);
#nullable restore
#line 19 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue(" ", 970, Model.ImagePosition != "right" ?  "md:ml-12 lg:ml-16 md:order-last" : "md:mr-12 lg:mr-16 md:order-first", 971, 107, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"g:py-8 text-center md:text-left\">\r\n");
#nullable restore
#line 21 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                 if (!string.IsNullOrEmpty(Model.Tagline))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"font-bold text-primary-500 text-sm text-center md:text-left uppercase\">\r\n                        ");
#nullable restore
#line 24 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                   Write(Model.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n");
#nullable restore
#line 26 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2\r\n                    class=\"font-display text-4xl font-black text-secondary-500 md:text-3xl lg:text-5xl tracking-wide text-center mt-4 lg:leading-tight md:text-left\">\r\n                    ");
#nullable restore
#line 29 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <p\r\n                    class=\"mt-4 text-center md:text-left text-sm md:text-base lg:text-lg font-medium leading-relaxed text-secondary-200\">\r\n                    ");
#nullable restore
#line 33 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
               Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 35 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                 if (Model.PrimaryButton != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <a
                        class=""inline-block mt-8 md:mt-8 px-8 py-3 border border-transparent text-base leading-6 font-medium rounded-md text-white bg-primary-500 hover:bg-primary-700 focus:outline-none focus:border-primary-700 focus:shadow-outline-indigo active:bg-indigo-700 transition ease-in-out duration-150""");
            BeginWriteAttribute("href", "\r\n                        href=\"", 2292, "\"", 2349, 1);
#nullable restore
#line 39 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue("", 2324, Model.PrimaryButton.Href, 2324, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-label", "\r\n                        aria-label=\"", 2350, "\"", 2408, 3);
            WriteAttributeValue("", 2388, "Go", 2388, 2, true);
            WriteAttributeValue(" ", 2390, "to", 2391, 3, true);
#nullable restore
#line 40 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
WriteAttributeValue(" ", 2393, Model.Tagline, 2394, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                                                     Write(Model.PrimaryButton.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 42 "E:\Source\Agility.NET5.Starter\Agility.NET5.Starter\Views\PageModules\TextBlockWithImage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Agility.Models.TextBlockWithImage> Html { get; private set; }
    }
}
#pragma warning restore 1591

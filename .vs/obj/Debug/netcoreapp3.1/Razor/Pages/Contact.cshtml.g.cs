#pragma checksum "C:\Users\PeterMøllerJensen\source\repos\FinalsystemPrototype2.iteration NEWEST BACKUP\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58be8c600862cae8eb5e857416d7d1b79c5f5f62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalsystemPrototype2.iteration.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
namespace FinalsystemPrototype2.iteration.Pages
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
#line 1 "C:\Users\PeterMøllerJensen\source\repos\FinalsystemPrototype2.iteration NEWEST BACKUP\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PeterMøllerJensen\source\repos\FinalsystemPrototype2.iteration NEWEST BACKUP\Pages\_ViewImports.cshtml"
using FinalsystemPrototype2.iteration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PeterMøllerJensen\source\repos\FinalsystemPrototype2.iteration NEWEST BACKUP\Pages\_ViewImports.cshtml"
using FinalsystemPrototype2.iteration.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58be8c600862cae8eb5e857416d7d1b79c5f5f62", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91ff0b80d48cfc05a16c23e3cb666c184c6a407", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/contactmodule.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/tailwindcss/1.4.6/tailwind.min.css\" /> ");
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css\" /> ");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58be8c600862cae8eb5e857416d7d1b79c5f5f624492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section id=""statumanu-contactmodule-wrapper"">
    <div class=""contactmodule-wrapper"">
        <div class=""contact-1 py-4 md:py-12"" style="" background: whitesmoke;"">
            <div class=""container mx-auto px-4"">
                <div class=""xl:flex -mx-4"" style=""margin-top: 2rem !important;"">
                    <div class=""xl:w-10/12 xl:mx-auto px-4"">

                        <div class=""xl:w-3/4 mb-4"">
                            <h1 class=""text-3xl text-medium mb-4"">We would love to hear from you</h1>
                            <p class=""text-xl mb-2"">Please submit your information and we will get back to you.</p>
                            <p>Call us at <a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1073, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-indigo-600 border-b border-transparent hover:border-indigo-600 transition-colors duration-300"">+45 88 88 88 88</a></p>
                        </div>

                        <div class=""md:flex md:-mx-4 mt-4 md:mt-10"">

                            <div class=""md:w-2/3 md:px-4"">
                                <div class=""contact-form"">
                                    <div class=""sm:flex sm:flex-wrap -mx-3"">
                                        <div class=""sm:w-1/2 px-3 mb-6"">
                                            <input type=""text"" placeholder=""Full Name"" class=""border-2 rounded px-3 py-1 w-full focus:border-indigo-400 input"">
                                        </div>
                                        <div class=""sm:w-1/2 px-3 mb-6"">
                                            <input type=""text"" placeholder=""Company Name"" class=""border-2 rounded px-3 py-1 w-full focus:border-indigo-400 input"">
                                        </div>
                  ");
            WriteLiteral(@"                      <div class=""sm:w-1/2 px-3 mb-6"">
                                            <input type=""text"" placeholder=""E-mail address"" class=""border-2 rounded px-3 py-1 w-full focus:border-indigo-400 input"">
                                        </div>
                                        <div class=""sm:w-1/2 px-3 mb-6"">
                                            <input type=""text"" placeholder=""Phone Number"" class=""border-2 rounded px-3 py-1 w-full focus:border-indigo-400 input"">
                                        </div>
                                        <div class=""sm:w-full px-3"">
                                            <textarea name=""message"" id=""message"" cols=""30"" rows=""4"" placeholder=""Your message here"" class=""border-2 rounded px-3 py-1 w-full focus:border-indigo-400 input""></textarea>
                                        </div>
                                    </div>
                                    <div class=""text-right mt-4 md:mt-12"">
            ");
            WriteLiteral(@"                            <button class=""border-2 border-indigo-600 rounded px-6 py-2 text-indigo-600 hover:bg-indigo-600 hover:text-white transition-colors duration-300"">
                                            Send a Message
                                            <i class=""fas fa-chevron-right ml-2 text-sm""></i>
                                        </button>
                                    </div>
                                </div>
                            </div>

                            <div class=""md:w-1/3 md:px-4 mt-10 md:mt-0"">
                                <div class=""bg-indigo-100 rounded py-4 px-6"">
                                    <h5 class=""text-xl font-medium mb-3"">Help</h5>
                                    <p class=""text-gray-700 mb-4"">Need help or have any query? Don't hesitate, you can directly shoot us an <a href=""mailto:"" class=""text-indigo-600 border-b border-transparent hover:border-indigo-600 inline-block"">email</a> or call us at <a href=""tel:");
            WriteLiteral(@""" class=""text-indigo-600 border-b border-transparent hover:border-indigo-600 inline-block"">+45 88 88 88 88</a></p>
                                    <p class=""text-gray-700"">You can move to <a href=""#"" class=""text-indigo-600 border-b border-transparent hover:border-indigo-600 inline-block"">FAQs</a> or <a href=""#"" class=""text-indigo-600 border-b border-transparent hover:border-indigo-600 inline-block"">Support</a> page to get more information about our software.</p>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>

            </div>
        </div>

    </div>


</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalsystemPrototype2.iteration.Pages.ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalsystemPrototype2.iteration.Pages.ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalsystemPrototype2.iteration.Pages.ContactModel>)PageContext?.ViewData;
        public FinalsystemPrototype2.iteration.Pages.ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8a1a8e823b5e7a6410c63f20b9fa182c3f94e64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\_ViewImports.cshtml"
using WinterShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\_ViewImports.cshtml"
using WinterShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\_ViewImports.cshtml"
using WinterShop.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8a1a8e823b5e7a6410c63f20b9fa182c3f94e64", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cfa4d218de29d7f341d62525103e81d13cacfb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmHome>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_InstagramPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""banner_part"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-7"">
                <div class=""banner_slider"">
                    <div class=""single_banner_slider"">
                        <div class=""banner_text"">
                            <div class=""banner_text_iner"">
                                <h5>");
#nullable restore
#line 10 "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\Home\Index.cshtml"
                               Write(Model.HomeBanner.UpTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h1>");
#nullable restore
#line 11 "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\Home\Index.cshtml"
                               Write(Model.HomeBanner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                <a href=""#"" class=""btn_1"">shop now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""feature_part pt-4"">
    <div class=""container-fluid p-lg-0 overflow-hidden"">
        <div class=""row align-items-center justify-content-between"">
            <div class=""col-lg-4 col-sm-6"">
                <div class=""single_feature_post_text"">
                    <img src=""img/xfeature_1.png.pagespeed.ic.VRoKq_7aTU.png"" alt=""#"">
                    <div class=""hover_text"">
                        <a href=""single-product.html"" class=""btn_2"">shop for male</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6"">
                <div class=""single_feature_post_text"">
                    <img src=""img/feature_2.png"" alt=""#"">
                    <div class=""hover_text");
            WriteLiteral(@""">
                        <a href=""single-product.html"" class=""btn_2"">shop for male</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6"">
                <div class=""single_feature_post_text"">
                    <img src=""img/xfeature_3.png.pagespeed.ic.e3bb0vye4Q.png"" alt=""#"">
                    <div class=""hover_text"">
                        <a href=""single-product.html"" class=""btn_2"">shop for male</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""new_arrival section_padding"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-8"">
                <div class=""arrival_tittle"">
                    <h2>new arrival</h2>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""arrival_filter_item filters"">
                    <ul>
            ");
            WriteLiteral(@"            <li class=""active controls"" data-filter=""*"">all</li>
                        <li class=""controls"" data-toggle="".men"">men</li>
                        <li class=""controls"" data-toggle="".women"">women</li>
                        <li class=""controls"" data-toggle="".shoes"">shoes</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""new_arrival_iner filter-container"">
                    <div class=""single_arrivel_item weidth_1 mix shoes"">
                        <img src=""img/arrivel/xarrivel_5.png.pagespeed.ic.EprMDMOnsF.png"" alt=""#"">
                        <div class=""hover_text"">
                            <p>Canvas</p>
                            <a href=""single-product.html""><h3>Lorem Canvas Low-Top Sneaker</h3></a>
                            <div class=""rate_icon"">
                                <a href=""#"">");
            WriteLiteral(@" <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                            </div>
                            <h5>$150</h5>
                            <div class=""social_icon"">
                                <a href=""#""><i class=""ti-heart""></i></a>
                                <a href=""#""><i class=""ti-bag""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""single_arrivel_item weidth_2 mix women"">
                        <img src=""img/arrivel/xarrivel_2.png.pagespeed.ic.D8VRC01CKk.png"" alt=""#"">
                        <div class=""hover_text"">
                            <p>Canvas</p>
                            <a");
            WriteLiteral(@" href=""single-product.html""><h3>Lorem Canvas Low-Top Sneaker</h3></a>
                            <div class=""rate_icon"">
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                            </div>
                            <h5>$150</h5>
                            <div class=""social_icon"">
                                <a href=""#""><i class=""ti-heart""></i></a>
                                <a href=""#""><i class=""ti-bag""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""single_arrivel_item weidth_3 mix shoes women"">
                        <img src=""img/arrivel/arr");
            WriteLiteral(@"ivel_3.png"" alt=""#"">
                        <div class=""hover_text"">
                            <p>Canvas</p>
                            <a href=""single-product.html""><h3>Lorem Canvas Low-Top Sneaker</h3></a>
                            <div class=""rate_icon"">
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                            </div>
                            <h5>$150</h5>
                            <div class=""social_icon"">
                                <a href=""#""><i class=""ti-heart""></i></a>
                                <a href=""#""><i class=""ti-bag""></i></a>
                            </div>
                        </div>
            ");
            WriteLiteral(@"        </div>
                    <div class=""single_arrivel_item weidth_3 mix women men"">
                        <img src=""img/arrivel/xarrivel_4.png.pagespeed.ic.jDYlxi_DTH.png"" alt=""#"">
                        <div class=""hover_text"">
                            <p>Canvas</p>
                            <a href=""single-product.html""><h3>Lorem Canvas Low-Top Sneaker</h3></a>
                            <div class=""rate_icon"">
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                            </div>
                            <h5>$150</h5>
                            <div class=""social_icon"">
                                <a href=""#""><i class=""");
            WriteLiteral(@"ti-heart""></i></a>
                                <a href=""#""><i class=""ti-bag""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""single_arrivel_item weidth_2 mix men women"">
                        <img src=""img/arrivel/arrivel_1.png"" alt=""#"">
                        <div class=""hover_text"">
                            <p>Canvas</p>
                            <a href=""single-product.html""><h3>Lorem Canvas Low-Top Sneaker</h3></a>
                            <div class=""rate_icon"">
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                            </div>
         ");
            WriteLiteral(@"                   <h5>$150</h5>
                            <div class=""social_icon"">
                                <a href=""#""><i class=""ti-heart""></i></a>
                                <a href=""#""><i class=""ti-bag""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""single_arrivel_item weidth_1 mix shoes men"">
                        <img src=""img/arrivel/xarrivel_6.png.pagespeed.ic.-kgtbBXTHE.png"" alt=""#"">
                        <div class=""hover_text"">
                            <p>Canvas</p>
                            <a href=""single-product.html""><h3>Lorem Canvas Low-Top Sneaker</h3></a>
                            <div class=""rate_icon"">
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                               ");
            WriteLiteral(@" <a href=""#""> <i class=""fas fa-star""></i> </a>
                                <a href=""#""> <i class=""fas fa-star""></i> </a>
                            </div>
                            <h5>$150</h5>
                            <div class=""social_icon"">
                                <a href=""#""><i class=""ti-heart""></i></a>
                                <a href=""#""><i class=""ti-bag""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
#nullable restore
#line 199 "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("VcPageFree"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8a1a8e823b5e7a6410c63f20b9fa182c3f94e6415241", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 201 "C:\Users\TUF DASH\Desktop\WinterShopp\WinterShop\WinterShop\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.InstagramFilters;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmHome> Html { get; private set; }
    }
}
#pragma warning restore 1591

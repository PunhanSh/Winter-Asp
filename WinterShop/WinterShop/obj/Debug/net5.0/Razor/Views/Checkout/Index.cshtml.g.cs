#pragma checksum "C:\Users\TUF DASH\Desktop\WinterShop\WinterShop\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b4708bb466aeca078b7f3247fd107f086643563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
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
#line 1 "C:\Users\TUF DASH\Desktop\WinterShop\WinterShop\Views\_ViewImports.cshtml"
using WinterShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TUF DASH\Desktop\WinterShop\WinterShop\Views\_ViewImports.cshtml"
using WinterShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b4708bb466aeca078b7f3247fd107f086643563", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a00458f4a90ca24a7d11f03c7e80a86b42bd1ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section class=""breadcrumb breadcrumb_bg"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb_iner"">
                    <div class=""breadcrumb_iner_item"">
                        <p>Home / checkout</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""checkout_area section_padding"">
    <div class=""container"">
        <div class=""returning_customer"">
            <div class=""check_title"">
                <h2>
                    Returning Customer?
                    <a href=""#"">Click here to login</a>
                </h2>
            </div>
            <p>
                If you have shopped with us before, please enter your details in the
                boxes below. If you are a new customer, please proceed to the
                Billing & Shipping section.
            </p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f0866435636240", async() => {
                WriteLiteral(@"
                <div class=""col-md-6 form-group p_star"">
                    <input type=""text"" class=""form-control"" id=""name"" name=""name"" value="" "" />
                    <span class=""placeholder"" data-placeholder=""Username or Email""></span>
                </div>
                <div class=""col-md-6 form-group p_star"">
                    <input type=""password"" class=""form-control"" id=""password"" name=""password""");
                BeginWriteAttribute("value", " value=\"", 1500, "\"", 1508, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <span class=""placeholder"" data-placeholder=""Password""></span>
                </div>
                <div class=""col-md-12 form-group"">
                    <button type=""submit"" value=""submit"" class=""btn_3"">
                        log in
                    </button>
                    <div class=""creat_account"">
                        <input type=""checkbox"" id=""f-option"" name=""selector"" />
                        <label for=""f-option"">Remember me</label>
                    </div>
                    <a class=""lost_pass"" href=""#"">Lost your password?</a>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""cupon_area"">
            <div class=""check_title"">
                <h2>
                    Have a coupon?
                    <a href=""#"">Click here to enter your code</a>
                </h2>
            </div>
            <input type=""text"" placeholder=""Enter coupon code"" />
            <a class=""tp_btn"" href=""#"">Apply Coupon</a>
        </div>
        <div class=""billing_details"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <h3>Billing Details</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f08664356310005", async() => {
                WriteLiteral(@"
                        <div class=""col-md-6 form-group p_star"">
                            <input type=""text"" class=""form-control"" id=""first"" name=""name"" />
                            <span class=""placeholder"" data-placeholder=""First name""></span>
                        </div>
                        <div class=""col-md-6 form-group p_star"">
                            <input type=""text"" class=""form-control"" id=""last"" name=""name"" />
                            <span class=""placeholder"" data-placeholder=""Last name""></span>
                        </div>
                        <div class=""col-md-12 form-group"">
                            <input type=""text"" class=""form-control"" id=""company"" name=""company"" placeholder=""Company name"" />
                        </div>
                        <div class=""col-md-6 form-group p_star"">
                            <input type=""text"" class=""form-control"" id=""number"" name=""number"" />
                            <span class=""placeholder"" data-placeholde");
                WriteLiteral(@"r=""Phone number""></span>
                        </div>
                        <div class=""col-md-6 form-group p_star"">
                            <input type=""text"" class=""form-control"" id=""email"" name=""compemailany"" />
                            <span class=""placeholder"" data-placeholder=""Email Address""></span>
                        </div>
                        <div class=""col-md-12 form-group p_star"">
                            <select class=""country_select"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f08664356311908", async() => {
                    WriteLiteral("Country");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f08664356313165", async() => {
                    WriteLiteral("Country");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f08664356314422", async() => {
                    WriteLiteral("Country");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""col-md-12 form-group p_star"">
                            <input type=""text"" class=""form-control"" id=""add1"" name=""add1"" />
                            <span class=""placeholder"" data-placeholder=""Address line 01""></span>
                        </div>
                        <div class=""col-md-12 form-group p_star"">
                            <input type=""text"" class=""form-control"" id=""add2"" name=""add2"" />
                            <span class=""placeholder"" data-placeholder=""Address line 02""></span>
                        </div>
                        <div class=""col-md-12 form-group p_star"">
                            <input type=""text"" class=""form-control"" id=""city"" name=""city"" />
                            <span class=""placeholder"" data-placeholder=""Town/City""></span>
                        </div>
                        <div class=""col-md-12 form-group p_star"">
                 ");
                WriteLiteral("           <select class=\"country_select\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f08664356316827", async() => {
                    WriteLiteral("District");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f08664356318085", async() => {
                    WriteLiteral("District");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b4708bb466aeca078b7f3247fd107f08664356319343", async() => {
                    WriteLiteral("District");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""col-md-12 form-group"">
                            <input type=""text"" class=""form-control"" id=""zip"" name=""zip"" placeholder=""Postcode/ZIP"" />
                        </div>
                        <div class=""col-md-12 form-group"">
                            <div class=""creat_account"">
                                <input type=""checkbox"" id=""f-option2"" name=""selector"" />
                                <label for=""f-option2"">Create an account?</label>
                            </div>
                        </div>
                        <div class=""col-md-12 form-group"">
                            <div class=""creat_account"">
                                <h3>Shipping Details</h3>
                                <input type=""checkbox"" id=""f-option3"" name=""selector"" />
                                <label for=""f-option3"">Ship to a different address?</label>
                       ");
                WriteLiteral("     </div>\r\n<textarea class=\"form-control\" name=\"message\" id=\"message\" rows=\"1\" placeholder=\"Order Notes\"></textarea>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-lg-4"">
                    <div class=""order_box"">
                        <h2>Your Order</h2>
                        <ul class=""list"">
                            <li>
                                <a href=""#"">
                                    Product
                                    <span>Total</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    Fresh Blackberry
                                    <span class=""middle"">x 02</span>
                                    <span class=""last"">$720.00</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    Fresh Tomatoes
                                    <span class=""middle"">x 02</span>
                     ");
            WriteLiteral(@"               <span class=""last"">$720.00</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    Fresh Brocoli
                                    <span class=""middle"">x 02</span>
                                    <span class=""last"">$720.00</span>
                                </a>
                            </li>
                        </ul>
                        <ul class=""list list_2"">
                            <li>
                                <a href=""#"">
                                    Subtotal
                                    <span>$2160.00</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    Shipping
                                    <span>Flat rate: $50.00</span>
                       ");
            WriteLiteral(@"         </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    Total
                                    <span>$2210.00</span>
                                </a>
                            </li>
                        </ul>
                        <div class=""payment_item"">
                            <div class=""radion_btn"">
                                <input type=""radio"" id=""f-option5"" name=""selector"" />
                                <label for=""f-option5"">Check payments</label>
                                <div class=""check""></div>
                            </div>
                            <p>
                                Please send a check to Store Name, Store Street, Store Town,
                                Store State / County, Store Postcode.
                            </p>
                        </div>
                        <div class=""payment_item active"">");
            WriteLiteral(@"
                            <div class=""radion_btn"">
                                <input type=""radio"" id=""f-option6"" name=""selector"" />
                                <label for=""f-option6"">Paypal </label>
                                <img src=""img/product/single-product/card.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10344, "\"", 10350, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                <div class=""check""></div>
                            </div>
                            <p>
                                Please send a check to Store Name, Store Street, Store Town,
                                Store State / County, Store Postcode.
                            </p>
                        </div>
                        <div class=""creat_account"">
                            <input type=""checkbox"" id=""f-option4"" name=""selector"" />
                            <label for=""f-option4"">I’ve read and accept the </label>
                            <a href=""#"">terms & conditions*</a>
                        </div>
                        <a class=""btn_3"" href=""#"">Proceed to Paypal</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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

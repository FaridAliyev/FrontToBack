#pragma checksum "E:\Projects\FrontToBack\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8232dfbf343a0c126eaa1a53b35fad1516db6478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
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
#line 1 "E:\Projects\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#line 2 "E:\Projects\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8232dfbf343a0c126eaa1a53b35fad1516db6478", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef499bc641b395c15c4ec72c4f836c4ebb7b5c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active-nav-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 212, true);
            WriteLiteral("<section id=\"navbar\">\r\n    <nav>\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"logo col-4\">\r\n                    <a href=\"main.html\">\r\n                        ");
            EndContext();
            BeginContext(224, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d5c88b4c1e94a41b0f63c5d7b1b4dd2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 234, "~/img/", 234, 6, true);
#line 8 "E:\Projects\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 240, Model.Logo, 240, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 391, true);
            WriteLiteral(@"
                    </a>
                </div>
                <div class=""nav-items col-8"">
                    <ul class=""navigation"">
                        <li class=""nav-item"">
                            <a class=""active-nav-item"" href=""#"">HOME</a>
                            <ul class=""home-drop"">
                                <li>
                                    ");
            EndContext();
            BeginContext(655, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f040b71263645a0bb700ea745de518d", async() => {
                BeginContext(723, 9, true);
                WriteLiteral("Main Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(736, 2051, true);
            WriteLiteral(@"
                                </li>
                                <li>
                                    <a href="""">Grid Home</a>
                                </li>
                                <li>
                                    <a href="""">Flower Shop</a>
                                </li>
                                <li>
                                    <a href="""">Animated Slider</a>
                                </li>
                                <li>
                                    <a href="""">Metro Showcase</a>
                                </li>
                                <li>
                                    <a href="""">Carousel Showcase</a>
                                </li>
                                <li>
                                    <a href="""">Landing</a>
                                </li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                 ");
            WriteLiteral(@"           <a href=""#"">PAGES</a>
                            <ul class=""pages-drop"">
                                <li>
                                    <a href="""">About Us</a>
                                </li>
                                <li>
                                    <a href="""">FAQ Page</a>
                                </li>
                                <li>
                                    <a href="""">Contact Us</a>
                                </li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"">SHOP</a>
                            <ul class=""shop-drop"">
                                <li class=""list-item col-3"">
                                    <p>Product Types</p>
                                    <ul>
                                        <li><a href=""orange-amaryllis.html"">Standart Product</a></li>
                                        <");
            WriteLiteral("li>");
            EndContext();
            BeginContext(2787, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1184c46bca4b1582c1f2d9602a521d", async() => {
                BeginContext(2838, 12, true);
                WriteLiteral("All Products");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2854, 11911, true);
            WriteLiteral(@"</li>
                                        <li><a href="""">Variable Product</a></li>
                                        <li><a href="""">Virtual Product</a></li>
                                        <li><a href="""">External Product</a></li>
                                        <li><a href="""">Downloadable Product</a></li>
                                        <li><a href="""">On Sale Product</a></li>
                                        <li><a href="""">Out Of Stock Product</a></li>
                                        <li><a href="""">New Product</a></li>
                                    </ul>
                                </li>
                                <li class=""list-item col-3"">
                                    <p>Shop Pages</p>
                                    <ul>
                                        <li><a href="""">My Account</a></li>
                                        <li><a href="""">Cart</a></li>
                                        <li><a href="""">");
            WriteLiteral(@"Checkout</a></li>
                                        <li><a href="""">Orders</a></li>
                                        <li><a href="""">Downloads</a></li>
                                    </ul>
                                </li>
                                <li class=""list-item col-3"">
                                    <p>Shop Types</p>
                                    <ul>
                                        <li><a href="""">Product List</a></li>
                                        <li><a href="""">Without Sidebar</a></li>
                                        <li><a href="""">With Category Filter</a></li>
                                        <li><a href="""">With Ordering Filter</a></li>
                                        <li><a href="""">Shop Carousel</a></li>
                                        <li><a href="""">Product Categories</a></li>
                                        <li><a href="""">Single Category</a></li>
                                    </ul>");
            WriteLiteral(@"
                                </li>
                                <li class=""list-item col-3"">
                                    <p>Shop Layouts</p>
                                    <ul>
                                        <li><a href="""">Two Columns Grid</a></li>
                                        <li><a href="""">Three Columns Grid</a></li>
                                        <li><a href="""">Four Columns Grid</a></li>
                                        <li><a href="""">Four Columns Wide</a></li>
                                        <li><a href="""">Five Columns Wide</a></li>
                                        <li><a href="""">Six Columns Wide</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"">PORTFOLIO</a>
                            <ul class=""portfolio-drop"">
                   ");
            WriteLiteral(@"             <li>
                                    <a href="""">Standard</a>
                                </li>
                                <li>
                                    <a href="""">Gallery</a>
                                </li>
                                <li>
                                    <a href="""">Masonry</a>
                                </li>
                                <li class=""innerDropLi"">
                                    <a href="""">Portfolio Layouts</a>
                                    <i class=""fas fa-chevron-right right""></i>
                                    <ul class=""layouts-drop"">
                                        <li><a href="""">Two Columns</a></li>
                                        <li><a href="""">Three Columns</a></li>
                                        <li><a href="""">Four Columns</a></li>
                                        <li><a href="""">Four Columns Wide</a></li>
                                        <li");
            WriteLiteral(@"><a href="""">Five Columns Wide</a></li>
                                    </ul>
                                </li>
                                <li class=""innerDropLi"">
                                    <a href="""">Portfolio Single</a>
                                    <i class=""fas fa-chevron-right right""></i>
                                    <ul class=""single-drop"">
                                        <li><a href="""">Small Images</a></li>
                                        <li><a href="""">Small Slider</a></li>
                                        <li><a href="""">Big Images</a></li>
                                        <li><a href="""">Big Slider</a></li>
                                        <li><a href="""">Gallery</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"">BLOG</a>
       ");
            WriteLiteral(@"                     <ul class=""blog-drop"">
                                <li>
                                    <a href="""">Masonry</a>
                                </li>
                                <li>
                                    <a href="""">Standard</a>
                                </li>
                                <li class=""innerDropLi"">
                                    <a href="""">Post Types</a>
                                    <i class=""fas fa-chevron-right right""></i>
                                    <ul class=""post-drop"">
                                        <li><a href="""">Standard</a></li>
                                        <li><a href="""">Gallery</a></li>
                                        <li><a href="""">Link</a></li>
                                        <li><a href="""">Quote</a></li>
                                        <li><a href="""">Audio</a></li>
                                        <li><a href="""">Video</a></li>
             ");
            WriteLiteral(@"                       </ul>
                                </li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"">ELEMENTS</a>
                            <ul class=""elements-drop"">
                                <li class=""innerDropLi"">
                                    <a href="""">Classic</a>
                                    <i class=""fas fa-chevron-right right""></i>
                                    <ul class=""classic-drop"">
                                        <li><a href=""accordions.html"">Accordions</a></li>
                                        <li><a href=""tabs.html"">Tabs</a></li>
                                        <li><a href="""">Buttons</a></li>
                                        <li><a href="""">Video Button</a></li>
                                        <li><a href="""">Contact Form</a></li>
                                    </ul>
                             ");
            WriteLiteral(@"   </li>
                                <li class=""innerDropLi"">
                                    <a href="""">Infographic</a>
                                    <i class=""fas fa-chevron-right right""></i>
                                    <ul class=""infographic-drop"">
                                        <li><a href="""">Blog List</a></li>
                                        <li><a href="""">Counters</a></li>
                                        <li><a href="""">Countdown</a></li>
                                        <li><a href="""">Google Maps</a></li>
                                        <li><a href=""progress-bar.html"">Progress Bar</a></li>
                                        <li><a href="""">Pies Charts</a></li>
                                    </ul>
                                </li>
                                <li class=""innerDropLi"">
                                    <a href="""">Interactive</a>
                                    <i class=""fas fa-chevron-right r");
            WriteLiteral(@"ight""></i>
                                    <ul class=""interactive-drop"">
                                        <li><a href="""">Image Gallery</a></li>
                                        <li><a href="""">Testimonials</a></li>
                                        <li><a href="""">Team</a></li>
                                        <li><a href="""">Banner</a></li>
                                        <li><a href="""">Shop List</a></li>
                                        <li><a href="""">Portfolio List</a></li>
                                    </ul>
                                </li>
                                <li class=""innerDropLi"">
                                    <a href="""">Typography</a>
                                    <i class=""fas fa-chevron-right right""></i>
                                    <ul class=""typography-drop"">
                                        <li><a href="""">Headings</a></li>
                                        <li><a href="""">Columns</a></");
            WriteLiteral(@"li>
                                        <li><a href="""">Section Title</a></li>
                                        <li><a href="""">Blockquote</a></li>
                                        <li><a href="""">Dropcaps</a></li>
                                        <li><a href="""">Highlights</a></li>
                                        <li><a href="""">Separators</a></li>
                                        <li><a href="""">Custom Font</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <span class=""search-icon"">
                            <i class=""material-icons search"">search</i>
                        </span>
                        <div class=""search-bar"">
                            <input class=""search-field"" type=""text"" placeholder=""Search"" autocomplete=""off"">
                            <i class=""material-icons search"">search</i>
                      ");
            WriteLiteral(@"  </div>
                        <a href="""" class=""cart"">
                            <span class=""bag-icon"">
                                <i class=""fas fa-shopping-bag bag"">
                                    <sup>
                                        <p id=""item-count"">0</p>
                                    </sup>
                                </i>
                                <span>CART(<span class=""total-price"">$0</span>)</span>
                            </span>
                            <ul class=""cart-drop"">
                                <li class=""cart-items"">

                                </li>
                                <div class=""subtotal"">
                                    <span class=""total"">TOTAL:</span>
                                    <span class=""amount"">$0</span>
                                </div>
                                <div class=""buttons"">
                                    <button class=""view-cart"">VIEW CART</button>
    ");
            WriteLiteral(@"                                <button class=""checkout"">CHECKOUT</button>
                                </div>
                                <div class=""empty-cart"">
                                    <p>No products in the cart.</p>
                                </div>
                            </ul>
                        </a>
                    </ul>
                </div>
            </div>
        </div>
    </nav>
</section>

<nav class=""fixed-navbar"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""logo col-4"">
                <a href=""main.html"">
                    ");
            EndContext();
            BeginContext(14765, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4b68b01b3a1489eb05df0c3fc8b98a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 14775, "~/img/", 14775, 6, true);
#line 263 "E:\Projects\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 14781, Model.Logo, 14781, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14805, 11597, true);
            WriteLiteral(@"
                </a>
            </div>
            <div class=""nav-items col-8"">
                <ul class=""navigation"">
                    <li class=""nav-item"">
                        <a class=""active-nav-item"" href=""#"">HOME</a>
                        <ul class=""home-drop"">
                            <li>
                                <a class=""active-nav-item"" href=""main.html"">Main Home</a>
                            </li>
                            <li>
                                <a href="""">Grid Home</a>
                            </li>
                            <li>
                                <a href="""">Flower Shop</a>
                            </li>
                            <li>
                                <a href="""">Animated Slider</a>
                            </li>
                            <li>
                                <a href="""">Metro Showcase</a>
                            </li>
                            <li>
                    ");
            WriteLiteral(@"            <a href="""">Carousel Showcase</a>
                            </li>
                            <li>
                                <a href="""">Landing</a>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#"">PAGES</a>
                        <ul class=""pages-drop"">
                            <li>
                                <a href="""">About Us</a>
                            </li>
                            <li>
                                <a href="""">FAQ Page</a>
                            </li>
                            <li>
                                <a href="""">Contact Us</a>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#"">SHOP</a>
                        <ul class=""shop-drop"">
                            <li class=""list-it");
            WriteLiteral(@"em col-3"">
                                <p>Product Types</p>
                                <ul>
                                    <li><a href=""orange-amaryllis.html"">Standart Product</a></li>
                                    <li><a href="""">Grouped Product</a></li>
                                    <li><a href="""">Variable Product</a></li>
                                    <li><a href="""">Virtual Product</a></li>
                                    <li><a href="""">External Product</a></li>
                                    <li><a href="""">Downloadable Product</a></li>
                                    <li><a href="""">On Sale Product</a></li>
                                    <li><a href="""">Out Of Stock Product</a></li>
                                    <li><a href="""">New Product</a></li>
                                </ul>
                            </li>
                            <li class=""list-item col-3"">
                                <p>Shop Pages</p>
              ");
            WriteLiteral(@"                  <ul>
                                    <li><a href="""">My Account</a></li>
                                    <li><a href="""">Cart</a></li>
                                    <li><a href="""">Checkout</a></li>
                                    <li><a href="""">Orders</a></li>
                                    <li><a href="""">Downloads</a></li>
                                </ul>
                            </li>
                            <li class=""list-item col-3"">
                                <p>Shop Types</p>
                                <ul>
                                    <li><a href="""">Product List</a></li>
                                    <li><a href="""">Without Sidebar</a></li>
                                    <li><a href="""">With Category Filter</a></li>
                                    <li><a href="""">With Ordering Filter</a></li>
                                    <li><a href="""">Shop Carousel</a></li>
                                    <li><a");
            WriteLiteral(@" href="""">Product Categories</a></li>
                                    <li><a href="""">Single Category</a></li>
                                </ul>
                            </li>
                            <li class=""list-item col-3"">
                                <p>Shop Layouts</p>
                                <ul>
                                    <li><a href="""">Two Columns Grid</a></li>
                                    <li><a href="""">Three Columns Grid</a></li>
                                    <li><a href="""">Four Columns Grid</a></li>
                                    <li><a href="""">Four Columns Wide</a></li>
                                    <li><a href="""">Five Columns Wide</a></li>
                                    <li><a href="""">Six Columns Wide</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#"">PO");
            WriteLiteral(@"RTFOLIO</a>
                        <ul class=""portfolio-drop"">
                            <li>
                                <a href="""">Standard</a>
                            </li>
                            <li>
                                <a href="""">Gallery</a>
                            </li>
                            <li>
                                <a href="""">Masonry</a>
                            </li>
                            <li class=""innerDropLi"">
                                <a href="""">Portfolio Layouts</a>
                                <i class=""fas fa-chevron-right right""></i>
                                <ul class=""layouts-drop"">
                                    <li><a href="""">Two Columns</a></li>
                                    <li><a href="""">Three Columns</a></li>
                                    <li><a href="""">Four Columns</a></li>
                                    <li><a href="""">Four Columns Wide</a></li>
                          ");
            WriteLiteral(@"          <li><a href="""">Five Columns Wide</a></li>
                                </ul>
                            </li>
                            <li class=""innerDropLi"">
                                <a href="""">Portfolio Single</a>
                                <i class=""fas fa-chevron-right right""></i>
                                <ul class=""single-drop"">
                                    <li><a href="""">Small Images</a></li>
                                    <li><a href="""">Small Slider</a></li>
                                    <li><a href="""">Big Images</a></li>
                                    <li><a href="""">Big Slider</a></li>
                                    <li><a href="""">Gallery</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#"">BLOG</a>
                        <ul class=""blog-drop"">
              ");
            WriteLiteral(@"              <li>
                                <a href="""">Masonry</a>
                            </li>
                            <li>
                                <a href="""">Standard</a>
                            </li>
                            <li class=""innerDropLi"">
                                <a href="""">Post Types</a>
                                <i class=""fas fa-chevron-right right""></i>
                                <ul class=""post-drop"">
                                    <li><a href="""">Standard</a></li>
                                    <li><a href="""">Gallery</a></li>
                                    <li><a href="""">Link</a></li>
                                    <li><a href="""">Quote</a></li>
                                    <li><a href="""">Audio</a></li>
                                    <li><a href="""">Video</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
    ");
            WriteLiteral(@"                <li class=""nav-item"">
                        <a href=""#"">ELEMENTS</a>
                        <ul class=""elements-drop"">
                            <li class=""innerDropLi"">
                                <a href="""">Classic</a>
                                <i class=""fas fa-chevron-right right""></i>
                                <ul class=""classic-drop"">
                                    <li><a href=""accordions.html"">Accordions</a></li>
                                    <li><a href=""tabs.html"">Tabs</a></li>
                                    <li><a href="""">Buttons</a></li>
                                    <li><a href="""">Video Button</a></li>
                                    <li><a href="""">Contact Form</a></li>
                                </ul>
                            </li>
                            <li class=""innerDropLi"">
                                <a href="""">Infographic</a>
                                <i class=""fas fa-chevron-right right""><");
            WriteLiteral(@"/i>
                                <ul class=""infographic-drop"">
                                    <li><a href="""">Blog List</a></li>
                                    <li><a href="""">Counters</a></li>
                                    <li><a href="""">Countdown</a></li>
                                    <li><a href="""">Google Maps</a></li>
                                    <li><a href=""progress-bar.html"">Progress Bar</a></li>
                                    <li><a href="""">Pies Charts</a></li>
                                </ul>
                            </li>
                            <li class=""innerDropLi"">
                                <a href="""">Interactive</a>
                                <i class=""fas fa-chevron-right right""></i>
                                <ul class=""interactive-drop"">
                                    <li><a href="""">Image Gallery</a></li>
                                    <li><a href="""">Testimonials</a></li>
                               ");
            WriteLiteral(@"     <li><a href="""">Team</a></li>
                                    <li><a href="""">Banner</a></li>
                                    <li><a href="""">Shop List</a></li>
                                    <li><a href="""">Portfolio List</a></li>
                                </ul>
                            </li>
                            <li class=""innerDropLi"">
                                <a href="""">Typography</a>
                                <i class=""fas fa-chevron-right right""></i>
                                <ul class=""typography-drop"">
                                    <li><a href="""">Headings</a></li>
                                    <li><a href="""">Columns</a></li>
                                    <li><a href="""">Section Title</a></li>
                                    <li><a href="""">Blockquote</a></li>
                                    <li><a href="""">Dropcaps</a></li>
                                    <li><a href="""">Highlights</a></li>
                     ");
            WriteLiteral(@"               <li><a href="""">Separators</a></li>
                                    <li><a href="""">Custom Font</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</nav>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb162e5b966cd0da1663b48c99e568362746b461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\_ViewImports.cshtml"
using ImtahanLast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\_ViewImports.cshtml"
using ImtahanLast.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
using ImtahanLast.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb162e5b966cd0da1663b48c99e568362746b461", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32a6c286bd52f7fc369aab5b7864796ec82ce2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
   
    Dictionary<string, string> keys = settings.GetSettings();

 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb162e5b966cd0da1663b48c99e568362746b4616888", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,300;0,400;0,700;1,100;1,300;1,700&display=swap""
          rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb162e5b966cd0da1663b48c99e568362746b4618196", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb162e5b966cd0da1663b48c99e568362746b46110083", async() => {
                WriteLiteral(@"
    <!-- Header Start -->
    <header>
        <section id=""day"">
            <nav class=""navbar"">
                <div class=""container"">
                    <a class=""navbar-brand"">
                        <i class=""fa-solid fa-clock""></i> <span>
                            Monday - Saturday, 8AM to
                            10PM
                        </span>
                    </a>
                    <div");
                BeginWriteAttribute("class", " class=\"", 1695, "\"", 1703, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fa-solid fa-mobile-screen-button\"></i>\r\n                        <span>Call us now ");
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                                     Write(keys["number"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                    </div>
                </div>

            </nav>
            </div>
        </section>
        <section id=""navigation"">
            <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                <div class=""container"">
                    <a class=""navbar-brand"" href=""#""><img src=""./assets/img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 2195, "\"", 2201, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                            aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                        <ul class=""navbar-nav ms-auto mb-2 mb-lg-0"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">About</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Services</a>
         ");
                WriteLiteral(@"                   </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Departments</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Doctors</a>
                            </li>
                         
");
#nullable restore
#line 75 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb162e5b966cd0da1663b48c99e568362746b46113730", async() => {
#nullable restore
#line 78 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                                                                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                </li>\r\n                                <li class=\"nav-item\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb162e5b966cd0da1663b48c99e568362746b46115638", async() => {
                    WriteLiteral("LogOut");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                </li>\r\n");
#nullable restore
#line 85 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb162e5b966cd0da1663b48c99e568362746b46117599", async() => {
                    WriteLiteral("Register");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </li>\r\n                                <li class=\"nav-item\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb162e5b966cd0da1663b48c99e568362746b46119258", async() => {
                    WriteLiteral("Login");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 94 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button""
                                   data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    Dropdown
                                </a>
                                <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                    <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                    <li>
                                        <hr class=""dropdown-divider"">
                                    </li>
                                    <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                                </ul>
                            </li>
                            <li class=""nav-item"">
             ");
                WriteLiteral("                   <a class=\"nav-link\" href=\"#\">Doctors</a>\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb162e5b966cd0da1663b48c99e568362746b46122339", async() => {
                    WriteLiteral("AdminPanel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </li>
                            <li class=""nav-item"">
                                <a href=""#"" class=""btn MakeAn"">Make An Appointment</a>
                            </li>

                        </ul>
                    </div>
                </div>
            </nav>
        </section>
    </header>
    <!-- Header End -->

    ");
#nullable restore
#line 128 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- Footer -->
    <footer style=""padding:50px;"" class=""text-center text-lg-start bg-light text-muted"">
        <!-- Section: Social media -->
        <section class=""d-flex justify-content-center justify-content-lg-between p-4 border-bottom"">
            <!-- Left -->
            <div class=""me-5 d-none d-lg-block"">
                <span>Get connected with us on social networks:</span>
            </div>
            <!-- Left -->
            <!-- Right -->
            <div>
                <a");
                BeginWriteAttribute("href", " href=\"", 6857, "\"", 6864, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-facebook-f\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 6987, "\"", 6994, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-twitter\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7114, "\"", 7121, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-google\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7240, "\"", 7247, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-instagram\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7369, "\"", 7376, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n                    <i class=\"fab fa-linkedin\"></i>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7497, "\"", 7504, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""me-4 text-reset"">
                    <i class=""fab fa-github""></i>
                </a>
            </div>
            <!-- Right -->
        </section>
        <!-- Section: Social media -->
        <!-- Section: Links  -->
        <section");
                BeginWriteAttribute("class", " class=\"", 7763, "\"", 7771, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""container text-center text-md-start mt-5"">
                <!-- Grid row -->
                <div class=""row mt-3"">
                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">
                        <!-- Content -->
                        <h6 style=""font-size: 24px ;"" class=""text-uppercase fw-bold mb-4"">
                            Medicio
                        </h6>
                        <p>
                            ");
#nullable restore
#line 175 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                       Write(keys["street"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <P>");
#nullable restore
#line 177 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                      Write(keys["country"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</P>\r\n                        <p><strong>Phone:</strong>");
#nullable restore
#line 178 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                                             Write(keys["number"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p><strong>Email::</strong>");
#nullable restore
#line 179 "C:\Users\Administrator\source\repos\ImtahanLast\ImtahanLast\Views\Shared\_Layout.cshtml"
                                              Write(keys["email"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Useful Links
                        </h6>
                        <p>
                            <a href=""#!"" class=""text-reset"">
                                Home
                            </a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">About us</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">
                                Services
                            </a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">
                                Terms ");
                WriteLiteral(@"of service
                            </a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">
                                Privacy policy
                            </a>
                        </p>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Our Services

                        </h6>
                        <p>
                            <a href=""#!"" class=""text-reset"">Web Design</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Web Development</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Product Manag");
                WriteLiteral(@"ement</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">Marketing</a>
                        </p>
                        <p>
                            <a href=""#!"" class=""text-reset"">
                                Graphic Design
                            </a>
                        </p>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">
                        <!-- Links -->
                        <h6 class=""text-uppercase fw-bold mb-4"">
                            Our Newsletter
                        </h6>
                        <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>
                        <div class=""input-group mb-3"">
                            <input type=""text"" class=""form-control"">
                            <span class=""i");
                WriteLiteral(@"nput-group-text""><button class=""btn btn-primary"">Subscribe</button></span>
                        </div>
                    </div>
                    <!-- Grid column -->
                </div>
                <!-- Grid row -->
            </div>
        </section>
        <!-- Section: Links  -->
        <!-- Copyright -->
        <div class=""text-center p-4"" style=""background-color: rgba(0, 0, 0, 0.05);"">
            © Copyright Medicio. All Rights Reserved
        </div>
        <!-- Copyright -->
    </footer>
    <!-- Footer -->
    <!-- Main End -->




    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM""
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LayoutServices settings { get; private set; }
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

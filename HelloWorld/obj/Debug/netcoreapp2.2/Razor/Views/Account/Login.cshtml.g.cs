#pragma checksum "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fdd6e33235030267f703ee87bd109f4f916802d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fdd6e33235030267f703ee87bd109f4f916802d", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloWorld.Models.Authentication.Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 5 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
            BeginContext(150, 23, true);
            WriteLiteral("    <p class=\"message\">");
            EndContext();
            BeginContext(174, 19, false);
#line 7 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
                  Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(193, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 8 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
}

#line default
#line hidden
#line 9 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
 if (ViewData["message"] != null)
{

#line default
#line hidden
            BeginContext(240, 23, true);
            WriteLiteral("    <p class=\"message\">");
            EndContext();
            BeginContext(264, 19, false);
#line 11 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
                  Write(ViewData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(283, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
}

#line default
#line hidden
            BeginContext(292, 39, true);
            WriteLiteral("<h4>Authenticate your identity</h4>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(361, 113, true);
            WriteLiteral("    <table class=\"table-create\">\r\n        <tr>\r\n            <th>Username</th>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(475, 107, false);
#line 21 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(x => x.Username, null, new { @class = "form-control", placeholder = "Type your username" }));

#line default
#line hidden
            EndContext();
            BeginContext(582, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(601, 42, false);
#line 22 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(x => x.Username));

#line default
#line hidden
            EndContext();
            BeginContext(643, 115, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Password</th>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(759, 102, false);
#line 28 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(x => x.Password, new { @class = "form-control", placeholder = "Type your password" }));

#line default
#line hidden
            EndContext();
            BeginContext(861, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(880, 42, false);
#line 29 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
            EndContext();
            BeginContext(922, 189, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th><button type=\"submit\">Login</button></th>\r\n            <td>\r\n                <div class=\"form-check\">\r\n                    ");
            EndContext();
            BeginContext(1112, 98, false);
#line 36 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
               Write(Html.CheckBoxFor(x => x.RememberMe, new { @class = "form-check-input", @id = "flexCheckDefault" }));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 266, true);
            WriteLiteral(@"
                    <label class=""form-check-label"" for=""flexCheckDefault"">
                        Remember me
                    </label>
                </div>
            </td>
        </tr>
    </table>
    <br />
    <a style=""text-decoration:none;""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1476, "\"", 1516, 1);
#line 45 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
WriteAttributeValue("", 1483, Url.Action("register","account"), 1483, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1517, 27, true);
            WriteLiteral(">Create a new account</a>\r\n");
            EndContext();
#line 46 "C:\Users\Sarwan\dotnet\HelloWorld\HelloWorld\Views\Account\Login.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWorld.Models.Authentication.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
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
#line 1 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\_ViewImports.cshtml"
using PressYourLuck;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\_ViewImports.cshtml"
using PressYourLuck.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842051d68800ad210ef9b3389f15811b05c4578d", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCoins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/unknown.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bust.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/money.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reveal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <var class=\"btn-primary\">\r\n        ");
#nullable restore
#line 4 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
   Write(TempData["ZeroTile"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 5 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
   Write(TempData["ZeroTotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 6 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
   Write(TempData["NonZeroTile"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 7 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
   Write(TempData["TakeCoin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </var>\r\n    <h3>Current Bet: $");
#nullable restore
#line 9 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                 Write(ViewData["currentBet"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
     if ((double)ViewData["currentBet"] > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d8752", async() => {
                WriteLiteral("\r\n            <input type=\"button\" value=\"TAKE THE COINS!\" class=\"btn btn-success\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"

    }
    else if ((double)ViewData["TotalCoin"] > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d10382", async() => {
                WriteLiteral("\r\n            <input type=\"button\" value=\"Try again!\" class=\"btn btn-danger\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
         foreach (var tile in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-2\">\r\n                <div class=\"card\">\r\n");
#nullable restore
#line 30 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                     if (tile.Visible == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d13006", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                    }
                    else if (tile.Value == "0.00")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d14629", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d16226", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-body\">\r\n                        <div>\r\n");
#nullable restore
#line 44 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                             if (tile.Visible == false)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d5433e3b2d60bcafeedc3ef51f1862dbd0d70d18255", async() => {
                WriteLiteral("<input type=\"button\" value=\"CHOOSE\" class=\"btn btn-primary\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-index", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                                                            WriteLiteral(tile.TileIndex);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["index"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-index", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["index"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                           Write(tile.Value);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
                                           
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\Users\NA\Desktop\새 폴더\Conestoga\Level 3\2330_Microsoft Web Technologies\Assignment3\03_PressYourLuck_Base\PressYourLuck - Starting Code\PressYourLuck\PressYourLuck\Views\Game\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tile>> Html { get; private set; }
    }
}
#pragma warning restore 1591

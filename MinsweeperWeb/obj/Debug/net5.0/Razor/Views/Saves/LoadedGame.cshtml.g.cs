#pragma checksum "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2886f4462a4002469f93ad599b1a4752f204128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Saves_LoadedGame), @"mvc.1.0.view", @"/Views/Saves/LoadedGame.cshtml")]
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
#line 1 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\_ViewImports.cshtml"
using MinsweeperWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\_ViewImports.cshtml"
using MinsweeperWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2886f4462a4002469f93ad599b1a4752f204128", @"/Views/Saves/LoadedGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4895bd90db0aa3b850f1cc4b041c606218a1ec5", @"/Views/_ViewImports.cshtml")]
    public class Views_Saves_LoadedGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameBoardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/game.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("game-button-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/FlaggedCell.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/UnopenedCell.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2886f4462a4002469f93ad599b1a4752f2041285299", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2886f4462a4002469f93ad599b1a4752f2041286414", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
  
    //Store image names in an array
    int id = 0;

    //Displaying the image
    string[] imageNames = { "EmptyCell.png", "1Cell.png", "2Cell.png", "3Cell.png", "4Cell.png", "5Cell.png", "6Cell.png", "7Cell.png", "8Cell.png", "BombCell.png", "EmptyCell.png", "FlaggedCell.png" };

#line default
#line hidden
#nullable disable
            WriteLiteral("<p id=\"user\">Let\'s Play, ");
#nullable restore
#line 12 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
                    Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n<div>\r\n    <p style=\"visibility:hidden;\" id=\"seconds\"></p>\r\n</div>\r\n<div style=\"padding-top: 2em;\" class=\"board\" id=\"board\" name=\"ID\"");
            BeginWriteAttribute("value", " value=\"", 608, "\"", 619, 1);
#nullable restore
#line 16 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
WriteAttributeValue("", 616, id, 616, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"button-zone\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
             for (int x = 0; x < Model.GameBoard.size; x++)
            {
                for (int y = 0; y < Model.GameBoard.size; y++)
                {
                    id++;
                    //Start a new line every 10 elements
                    if ((id - 1) % 10 == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"line-break\"></div>\r\n");
#nullable restore
#line 28 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
                    }



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"game-button\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 1116, "\"", 1127, 1);
#nullable restore
#line 31 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
WriteAttributeValue("", 1124, id, 1124, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                            name=\"ID\">\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("                        <div class=\"button-label\">\r\n");
#nullable restore
#line 39 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
                             if (Model.GameBoard.GrabCellFromGrid(id).flagged)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2886f4462a4002469f93ad599b1a4752f20412810606", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
                            }
                            else if (Model.GameBoard.GrabCellFromGrid(id).visited && !Model.GameBoard.GrabCellFromGrid(id).live)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2886f4462a4002469f93ad599b1a4752f20412812158", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1787, "~/img/", 1787, 6, true);
#nullable restore
#line 45 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
AddHtmlAttributeValue("", 1793, imageNames[Model.GameBoard.GrabCellFromGrid(id).numOfLive], 1793, 59, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
                            }
                            else if (Model.GameBoard.GrabCellFromGrid(id).live && Model.GameBoard.GrabCellFromGrid(id).visited)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2886f4462a4002469f93ad599b1a4752f20412814225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2117, "~/img/", 2117, 6, true);
#nullable restore
#line 49 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
AddHtmlAttributeValue("", 2123, imageNames[9], 2123, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2886f4462a4002469f93ad599b1a4752f20412816152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
#line 54 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </button>\r\n");
#nullable restore
#line 57 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"

                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</div>\r\n<h3>");
#nullable restore
#line 62 "C:\Users\anasanchez\source\repos\AnaOddles\MinesweeperWeb\MinsweeperWeb\Views\Saves\LoadedGame.cshtml"
Write(Model.numOfClick);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div id=\"timer\"></div>\r\n<button class=\"save\">Save Game</button>\r\n<button class=\"load\">Load Game</button>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameBoardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

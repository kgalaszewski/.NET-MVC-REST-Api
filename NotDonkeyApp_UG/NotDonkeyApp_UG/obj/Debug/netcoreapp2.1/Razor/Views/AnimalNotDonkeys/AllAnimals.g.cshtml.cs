#pragma checksum "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "431e44f6811c994c39784b4ace59d2f00672008d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnimalNotDonkeys_AllAnimals), @"mvc.1.0.view", @"/Views/AnimalNotDonkeys/AllAnimals.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AnimalNotDonkeys/AllAnimals.cshtml", typeof(AspNetCore.Views_AnimalNotDonkeys_AllAnimals))]
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
#line 1 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\_ViewImports.cshtml"
using NotDonkeyApp_UG;

#line default
#line hidden
#line 2 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\_ViewImports.cshtml"
using NotDonkeyApp_UG.Models;

#line default
#line hidden
#line 2 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
using NotDonkeyApp_UG.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"431e44f6811c994c39784b4ace59d2f00672008d", @"/Views/AnimalNotDonkeys/AllAnimals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfe5e5f55c2c771fc3d8e08541f12397f3632b90", @"/Views/_ViewImports.cshtml")]
    public class Views_AnimalNotDonkeys_AllAnimals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AnimalNotDonkey>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AnimalNotDonkeys", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAnimalToFavourites", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:lightblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
  
    ViewData["Title"] = "AllAnimals";

#line default
#line hidden
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(115, 1445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2729c46220d4cc48b6ac82626841304", async() => {
                BeginContext(156, 403, true);
                WriteLiteral(@"
    <h1>Check out our all verified Animals ヽ(◕ヮ◕ヽ)</h1>
    <br />

    <table class=""table table-bordered"" width=""100%"" style=""background-color:lightyellow"">
        <tr>
            <th>avatar</th>
            <th>Name</th>
            <th>Breed</th>
            <th>Sex</th>
            <th>Weight</th>
            <th>Additional Description</th>
            <th></th>
        </tr>

");
                EndContext();
#line 22 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
         foreach (var animal in Model)
        {
            string avatarUrl = $"{@StaticDetails.AvatarUrl}{animal.AnimalType}.jpg";

#line default
#line hidden
                BeginContext(696, 54, true);
                WriteLiteral("            <tr>\r\n                <td width=\"10%\"><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 750, "\"", 766, 1);
#line 26 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
WriteAttributeValue("", 756, avatarUrl, 756, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(767, 137, true);
                WriteLiteral(" width=\"100%\" height=\"70px\" style=\"margin:auto; display:block; border-radius:5px; border:1px solid #bbb9b9\" /></td>\r\n                <td>");
                EndContext();
                BeginContext(905, 11, false);
#line 27 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
               Write(animal.Name);

#line default
#line hidden
                EndContext();
                BeginContext(916, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(944, 17, false);
#line 28 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
               Write(animal.AnimalType);

#line default
#line hidden
                EndContext();
                BeginContext(961, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(989, 10, false);
#line 29 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
               Write(animal.Sex);

#line default
#line hidden
                EndContext();
                BeginContext(999, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1027, 13, false);
#line 30 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
               Write(animal.Weight);

#line default
#line hidden
                EndContext();
                BeginContext(1040, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1068, 28, false);
#line 31 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
               Write(animal.AdditionalDescription);

#line default
#line hidden
                EndContext();
                BeginContext(1096, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 32 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
                 if (StaticDetails.CurrentUserId != animal.Id)
                {

#line default
#line hidden
                BeginContext(1186, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(1210, 133, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093abed8c9f94d3c9327a9306dbb14d6", async() => {
                    BeginContext(1332, 7, true);
                    WriteLiteral("Like It");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
                                                                                                                          WriteLiteral(animal.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1343, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 35 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1410, 80, true);
                WriteLiteral("                    <td><button class=\"btn btn-danger\">Its you !</button></td>\r\n");
                EndContext();
#line 39 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
                }

#line default
#line hidden
                BeginContext(1509, 19, true);
                WriteLiteral("            </tr>\r\n");
                EndContext();
#line 41 "C:\Users\Karol\Desktop\NotDonkey\UG_NotDonkeyApp\NotDonkeyApp_UG\NotDonkeyApp_UG\Views\AnimalNotDonkeys\AllAnimals.cshtml"
        }

#line default
#line hidden
                BeginContext(1539, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1560, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AnimalNotDonkey>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62c5fc58e17b91b41fd13c08d427b8672f940089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employments_Index), @"mvc.1.0.view", @"/Views/Employments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employments/Index.cshtml", typeof(AspNetCore.Views_Employments_Index))]
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
#line 1 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\_ViewImports.cshtml"
using SZZP2._2;

#line default
#line hidden
#line 2 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\_ViewImports.cshtml"
using SZZP2._2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c5fc58e17b91b41fd13c08d427b8672f940089", @"/Views/Employments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"922c3105936468de90a9c975d69473d3e9288a87", @"/Views/_ViewImports.cshtml")]
    public class Views_Employments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SZZP2._2.Models.SZZPViewModels.EmploymentIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 60, true);
            WriteLiteral("\r\n<h2>Lista nowo zatrudnionych pracowników</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(162, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c5fc58e17b91b41fd13c08d427b8672f9400895657", async() => {
                BeginContext(209, 23, true);
                WriteLiteral("Dodaj nowego pracownika");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 459, true);
            WriteLiteral(@"
</p>
<table class=""table table-striped table-responsive"">
    <thead>
        <tr class=""small text-left"">
            <th>Imię</th>
            <th>Nazwisko</th>
            <th>NrSap</th>
            <th>Data Zatrudnienia</th>
            <th>Koniec umowy</th>
            <th>Biuro</th>
            <th>Wydział</th>
            <th>Stanowisko</th>
            <th>Status</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
 foreach (var item in Model.Employments) {

#line default
#line hidden
            BeginContext(739, 62, true);
            WriteLiteral("        <tr class=\"small\">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(802, 39, false);
#line 31 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(841, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(897, 42, false);
#line 34 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(939, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(995, 40, false);
#line 37 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NrSap));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1091, 49, false);
#line 40 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateEmployment));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1196, 46, false);
#line 43 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndContract));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1298, 53, false);
#line 46 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Offices.NameOffice));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 117, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               <!-- -->\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1469, 57, false);
#line 52 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Positions.NamePosition));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1582, 54, false);
#line 55 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Statuses.NameStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1693, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c5fc58e17b91b41fd13c08d427b8672f94008911668", async() => {
                BeginContext(1772, 6, true);
                WriteLiteral("Edycja");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
                                                               WriteLiteral(item.IDEmployment);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1782, 83, true);
            WriteLiteral(" |\r\n                <!--<a asp-action=\"Details\" class=\"btn btn-info\" asp-route-id=\"");
            EndContext();
            BeginContext(1866, 17, false);
#line 60 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
                                                                          Write(item.IDEmployment);

#line default
#line hidden
            EndContext();
            BeginContext(1883, 38, true);
            WriteLiteral("\">Szczegóły</a> |-->\r\n                ");
            EndContext();
            BeginContext(1921, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c5fc58e17b91b41fd13c08d427b8672f94008914700", async() => {
                BeginContext(2001, 4, true);
                WriteLiteral("Usuń");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
                                                                WriteLiteral(item.IDEmployment);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2009, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\andrzej.gajewski\source\repos\SZZP2.2 — kopia przed logowaniem\SZZP2.2\Views\Employments\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2048, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SZZP2._2.Models.SZZPViewModels.EmploymentIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591

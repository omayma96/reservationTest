#pragma checksum "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ae931887519a55b44925ab6cae1021fef4fb50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRoleManagement_DisplayRoles), @"mvc.1.0.view", @"/Views/UserRoleManagement/DisplayRoles.cshtml")]
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
#line 1 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\_ViewImports.cshtml"
using reservation_system;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\_ViewImports.cshtml"
using reservation_system.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ae931887519a55b44925ab6cae1021fef4fb50", @"/Views/UserRoleManagement/DisplayRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080b9feecacf7935cb5f32435ea5c3f4bf6191a4", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRoleManagement_DisplayRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to remove this role\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
   ViewData["Title"] = "All Roles"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3 class=\"text-center\">Role Management</h3>\n<hr />\n\n");
#nullable restore
#line 8 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
Write(await Html.PartialAsync("_TopMenuPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"row\">\n\n\n\n    <div class=\"col-12\" style=\"border-left:1px solid black;\">\n        <h3 class=\"text-center\">All Roles</h3>\n");
#nullable restore
#line 17 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
         if (Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>No roles found!</p> ");
#nullable restore
#line 19 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
                       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n    <thead class=\"bg-dark text-white\">\n        <tr>\n            <th>Role Name</th>\n            <th>Actions</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 30 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
         foreach (var r in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 33 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
   Write(r.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ae931887519a55b44925ab6cae1021fef4fb506379", async() => {
                WriteLiteral("Remove Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-role", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
               WriteLiteral(r.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["role"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-role", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["role"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 40 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
#nullable restore
#line 42 "C:\Users\Youcode\Documents\GitHub\reservationTest\reservations-main\Views\UserRoleManagement\DisplayRoles.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6363c3c3faaf52a1d0c5b7e2dea781bade8785c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Mail), @"mvc.1.0.view", @"/Views/Home/Mail.cshtml")]
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
#line 1 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\_ViewImports.cshtml"
using EMailApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\_ViewImports.cshtml"
using EMailApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6363c3c3faaf52a1d0c5b7e2dea781bade8785c", @"/Views/Home/Mail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8cb2b7bf95bbc63721f98105f5c67f4ee3e1ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Mail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EMailApp.Common.ViewModel.MailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
  
    ViewData["Title"] = "Mail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""toolbar"">
    <div class=""btn-group"">
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-envelope""></span>
        </button>
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-star""></span>
        </button>
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-star-o""></span>
        </button>
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-bookmark-o""></span>
        </button>
    </div>
    <div class=""btn-group"">
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-mail-reply""></span>
        </button>
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-mail-reply-all""></span>
        </button>
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-mail-forward""></span>
        </button>
    </div>
    <button type=""button"" class=""btn btn-light"">");
            WriteLiteral(@"
        <span class=""fa fa-trash-o""></span>
    </button>
    <div class=""btn-group"">
        <button type=""button"" class=""btn btn-light dropdown-toggle"" data-toggle=""dropdown"">
            <span class=""fa fa-tags""></span>
            <span class=""caret""></span>
        </button>
        <div class=""dropdown-menu"">
            <a class=""dropdown-item"" href=""#"">
                add label <span class=""badge badge-danger"">
                    Home
                </span>
            </a>
            <a class=""dropdown-item"" href=""#"">add label <span class=""badge badge-info""> Job</span></a>
            <a class=""dropdown-item"" href=""#"">
                add label <span class=""badge badge-success"">
                    Clients
                </span>
            </a>
            <a class=""dropdown-item"" href=""#"">
                add label <span class=""badge badge-warning"">
                    News
                </span>
            </a>
        </div>
    </div>
    <div class=""btn-group ");
            WriteLiteral(@"float-right"">
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-chevron-left""></span>
        </button>
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-chevron-right""></span>
        </button>
    </div>
</div>
<div>
    <hr />
    <dl class=""row"">
        <dt class = ""col-sm-2"">
            ");
#nullable restore
#line 73 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayNameFor(model => model.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayFor(model => model.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayNameFor(model => model.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayFor(model => model.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 85 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 88 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 91 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 105 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Mail.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6363c3c3faaf52a1d0c5b7e2dea781bade8785c9507", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EMailApp.Common.ViewModel.MailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77f4b7ee359aa006c8df6656d6e0c37c3bb3ef38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77f4b7ee359aa006c8df6656d6e0c37c3bb3ef38", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8cb2b7bf95bbc63721f98105f5c67f4ee3e1ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EMailApp.Repository.Entity.Mail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inbox";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 5 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
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
    <button type=""button"" class=""btn btn-li");
            WriteLiteral(@"ght"">
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
    <div class=""btn-g");
            WriteLiteral(@"roup float-right"">
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-chevron-left""></span>
        </button>
        <button type=""button"" class=""btn btn-light"">
            <span class=""fa fa-chevron-right""></span>
        </button>
    </div>
</div>

<ul class=""messages"">
");
#nullable restore
#line 70 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"message unread\">\r\n            <a");
            BeginWriteAttribute("href", " href=", 2576, "", 2629, 1);
#nullable restore
#line 73 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2582, Url.Action("Mail","Home",new { id = item.Id }), 2582, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""actions"">
                    <span class=""action""><i class=""fa fa-square-o""></i></span>
                    <span class=""action""><i class=""fa fa-star-o""></i></span>
                </div>
                <div class=""header"">
                    <span class=""from"">");
#nullable restore
#line 79 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
                                  Write(item.Sender.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"date\">\r\n                        <span class=\"fa fa-paper-clip\"></span> ");
#nullable restore
#line 81 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
                                                          Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div class=\"title\">\r\n                    ");
#nullable restore
#line 85 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"description\">\r\n                    ");
#nullable restore
#line 88 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 92 "C:\Prakhyath\Projects\EmailApp\EMailApp.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EMailApp.Repository.Entity.Mail>> Html { get; private set; }
    }
}
#pragma warning restore 1591

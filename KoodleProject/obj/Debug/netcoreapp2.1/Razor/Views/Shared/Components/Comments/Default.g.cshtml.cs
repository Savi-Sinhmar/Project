#pragma checksum "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36180034ceb0b141e80358cd7c4a0e2fc10aa586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Comments_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Comments/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Comments/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Comments_Default))]
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
#line 1 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Posts;

#line default
#line hidden
#line 2 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Notifications;

#line default
#line hidden
#line 3 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Users;

#line default
#line hidden
#line 4 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Follows;

#line default
#line hidden
#line 5 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Posts;

#line default
#line hidden
#line 6 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Follows;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36180034ceb0b141e80358cd7c4a0e2fc10aa586", @"/Views/Shared/Components/Comments/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d0d685ff31f1eb6c0abbfb793838606aa9c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Comments_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewModels.Comments.CommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Templates/_Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 27, true);
            WriteLiteral("<div class=\"post__comments\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 110, "\"", 145, 2);
            WriteAttributeValue("", 115, "post__comments-", 115, 15, true);
#line 3 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
WriteAttributeValue("", 130, Model.PostId, 130, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(146, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 4 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
         if (Model.LoadMore)
        {

#line default
#line hidden
            BeginContext(190, 85, true);
            WriteLiteral("            <div class=\"text-center p-2\">\r\n                <a href=\"#\" data-post-id=\"");
            EndContext();
            BeginContext(276, 12, false);
#line 7 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
                                     Write(Model.PostId);

#line default
#line hidden
            EndContext();
            BeginContext(288, 157, true);
            WriteLiteral("\" class=\"load-previous-comments-btn\">\r\n                    <span class=\"d-none\">2</span> View previous comments\r\n                </a>\r\n\r\n            </div>\r\n");
            EndContext();
#line 12 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(456, 10, true);
            WriteLiteral("\r\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 466, "\"", 514, 2);
            WriteAttributeValue("", 474, "post__comments-container-", 474, 25, true);
#line 14 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
WriteAttributeValue("", 499, Model.PostId, 499, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(515, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 15 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
         if (Model.Comments.Any())
        {

#line default
#line hidden
            BeginContext(565, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(577, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abb656f009a94e5d9a7331d61760f54c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 17 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(627, 34, true);
            WriteLiteral("\r\n            <span class=\"d-none\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 661, "\"", 696, 2);
            WriteAttributeValue("", 666, "comment-loadMore-", 666, 17, true);
#line 18 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
WriteAttributeValue("", 683, Model.PostId, 683, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(697, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(699, 14, false);
#line 18 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
                                                                Write(Model.LoadMore);

#line default
#line hidden
            EndContext();
            BeginContext(713, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 19 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(733, 57, true);
            WriteLiteral("    </div>\r\n\r\n    <div class=\"post__commenter\">\r\n        ");
            EndContext();
            BeginContext(790, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f9ced22bed04b23bab6959f7bdcfe5d", async() => {
                BeginContext(899, 32, true);
                WriteLiteral("\r\n            \r\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 931, "\"", 984, 1);
#line 25 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
WriteAttributeValue("", 937, await UserService.GetUserProfilePictureAsync(), 937, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(985, 46, true);
                WriteLiteral(" class=\"post__photo\"/>\r\n            \r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
                                                                 WriteLiteral(UserService.GetCurrentUserNameAsync());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1035, 120, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"post__comment-box\">\r\n        <input type=\"text\" class=\"post__comment-input\" data-post-id=\"");
            EndContext();
            BeginContext(1156, 12, false);
#line 30 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
                                                                Write(Model.PostId);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1169, "\"", 1197, 2);
            WriteAttributeValue("", 1174, "comment-", 1174, 8, true);
#line 30 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\Comments\Default.cshtml"
WriteAttributeValue("", 1182, Model.PostId, 1182, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1198, 58, true);
            WriteLiteral(" placeholder=\"write on this post...\"/>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewModels.Comments.CommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
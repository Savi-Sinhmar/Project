#pragma checksum "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e65864652ec2afb3efd17e5b39aa20adec233f8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProfileCover_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProfileCover/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ProfileCover/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ProfileCover_Default))]
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
#line 1 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
using Core.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e65864652ec2afb3efd17e5b39aa20adec233f8c", @"/Views/Shared/Components/ProfileCover/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d0d685ff31f1eb6c0abbfb793838606aa9c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProfileCover_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewModels.Profile.ProfileCoverViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(143, 40, true);
            WriteLiteral("\r\n<div class=\"profile__cover\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 183, "\"", 215, 1);
#line 7 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
WriteAttributeValue("", 189, Model.ProfileCoverPicture, 189, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(216, 75, true);
            WriteLiteral(" class=\"profile__bg-img\"/>\r\n\r\n    <div class=\"profile__info\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 291, "\"", 318, 1);
#line 10 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
WriteAttributeValue("", 297, Model.ProfilePicture, 297, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(319, 84, true);
            WriteLiteral(" class=\"profile__photo\" alt=\"Profile-Picture\"/>\r\n        <h2 class=\"profile__title\">");
            EndContext();
            BeginContext(404, 14, false);
#line 11 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                              Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(418, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 12 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
         if (!string.IsNullOrEmpty(Model.Description))
        {

#line default
#line hidden
            BeginContext(492, 62, true);
            WriteLiteral("            <p class=\"profile__description\">\r\n                ");
            EndContext();
            BeginContext(555, 17, false);
#line 15 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(572, 20, true);
            WriteLiteral("\r\n            </p>\r\n");
            EndContext();
#line 17 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(603, 14, true);
            WriteLiteral("    </div>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
     if (!await UserService.IsProfilePageForCurrentUserAsync(CommonHelper.GetUserNameFromUrl()))
    {
        if (Model.IsFollowingUser)
        {

#line default
#line hidden
            BeginContext(769, 144, true);
            WriteLiteral("            <div class=\"profile__follow\">\r\n                <a class=\"profile__follow-btn profile__follow--is-following\" data-followee-username=\"");
            EndContext();
            BeginContext(914, 33, false);
#line 25 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                                                                                                Write(CommonHelper.GetUserNameFromUrl());

#line default
#line hidden
            EndContext();
            BeginContext(947, 92, true);
            WriteLiteral("\">\r\n                    <span>Following</span>\r\n\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 30 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1075, 114, true);
            WriteLiteral("            <div class=\"profile__follow\">\r\n                <a class=\"profile__follow-btn\" data-followee-username=\"");
            EndContext();
            BeginContext(1190, 33, false);
#line 34 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
                                                                  Write(CommonHelper.GetUserNameFromUrl());

#line default
#line hidden
            EndContext();
            BeginContext(1223, 145, true);
            WriteLiteral("\">\r\n                    <i class=\"fa fa-user-plus\"></i>\r\n                    <span>Follow me</span>\r\n\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 40 "C:\Users\savi1\Documents\GitHub\grpkoodleproj\KoodleProject\KoodleProject\Views\Shared\Components\ProfileCover\Default.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1386, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CommonHelper CommonHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewModels.Profile.ProfileCoverViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\mac\Desktop\Pronia\Pronia BackEnd\Pronia\Pronia\Areas\AdminPanel\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d44c87d2818007ffecf979802a18c75fe0d78049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44c87d2818007ffecf979802a18c75fe0d78049", @"/Areas/AdminPanel/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <!-- partial:partials/_navbar.html -->
<nav class=""navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
    <div class=""navbar-brand-wrapper d-flex justify-content-center"">
        <div class=""navbar-brand-inner-wrapper d-flex justify-content-between align-items-center w-100"">
            <a class=""navbar-brand brand-logo"" href=""index.html""><img src=""images/logo.svg"" alt=""logo"" /></a>
            <a class=""navbar-brand brand-logo-mini"" href=""index.html""><img src=""images/logo-mini.svg"" alt=""logo"" /></a>
            <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                <span class=""mdi mdi-sort-variant""></span>
            </button>
        </div>
    </div>
    <div class=""navbar-menu-wrapper d-flex align-items-center justify-content-end"">
        <ul class=""navbar-nav mr-lg-4 w-100"">
            <li class=""nav-item nav-search d-none d-lg-block w-100"">
                <div class=""input-group"">
                    <div class=""in");
            WriteLiteral(@"put-group-prepend"">
                        <span class=""input-group-text"" id=""search"">
                            <i class=""mdi mdi-magnify""></i>
                        </span>
                    </div>
                    <input type=""text"" class=""form-control"" placeholder=""Search now"" aria-label=""search"" aria-describedby=""search"">
                </div>
            </li>
        </ul>
        <ul class=""navbar-nav navbar-nav-right"">
            <li class=""nav-item dropdown me-1"">
                <a class=""nav-link count-indicator dropdown-toggle d-flex justify-content-center align-items-center"" id=""messageDropdown"" href=""#"" data-bs-toggle=""dropdown"">
                    <i class=""mdi mdi-message-text mx-0""></i>
                    <span class=""count""></span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""messageDropdown"">
                    <p class=""mb-0 font-weight-normal float-left dropdown-header"">Messages</p>
  ");
            WriteLiteral(@"                  <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <img src=""images/faces/face4.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""item-content flex-grow"">
                            <h6 class=""ellipsis font-weight-normal"">
                                David Grey
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                The meeting is cancelled
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <img src=""images/faces/face2.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""item-content flex-grow"">
                            <h6 class=""ellipsis font-weight");
            WriteLiteral(@"-normal"">
                                Tim Cook
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                New product launch
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <img src=""images/faces/face3.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""item-content flex-grow"">
                            <h6 class=""ellipsis font-weight-normal"">
                                Johnson
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                Upcoming board meeting
                            </p>
                        </div>
                    </a>
                </div>
           ");
            WriteLiteral(@" </li>
            <li class=""nav-item dropdown me-4"">
                <a class=""nav-link count-indicator dropdown-toggle d-flex align-items-center justify-content-center notification-dropdown"" id=""notificationDropdown"" href=""#"" data-bs-toggle=""dropdown"">
                    <i class=""mdi mdi-bell mx-0""></i>
                    <span class=""count""></span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""notificationDropdown"">
                    <p class=""mb-0 font-weight-normal float-left dropdown-header"">Notifications</p>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <div class=""item-icon bg-success"">
                                <i class=""mdi mdi-information mx-0""></i>
                            </div>
                        </div>
                        <div class=""item-content"">
                            <h6 class=""font-weight-normal"">");
            WriteLiteral(@"Application Error</h6>
                            <p class=""font-weight-light small-text mb-0 text-muted"">
                                Just now
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <div class=""item-icon bg-warning"">
                                <i class=""mdi mdi-settings mx-0""></i>
                            </div>
                        </div>
                        <div class=""item-content"">
                            <h6 class=""font-weight-normal"">Settings</h6>
                            <p class=""font-weight-light small-text mb-0 text-muted"">
                                Private message
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                      ");
            WriteLiteral(@"      <div class=""item-icon bg-info"">
                                <i class=""mdi mdi-account-box mx-0""></i>
                            </div>
                        </div>
                        <div class=""item-content"">
                            <h6 class=""font-weight-normal"">New user registration</h6>
                            <p class=""font-weight-light small-text mb-0 text-muted"">
                                2 days ago
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li class=""nav-item nav-profile dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" data-bs-toggle=""dropdown"" id=""profileDropdown"">
                    <img src=""images/faces/face5.jpg"" alt=""profile"" />
                    <span class=""nav-profile-name"">Louis Barnett</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""profileDro");
            WriteLiteral(@"pdown"">
                    <a class=""dropdown-item"">
                        <i class=""mdi mdi-settings text-primary""></i>
                        Settings
                    </a>
                    <a class=""dropdown-item"">
                        <i class=""mdi mdi-logout text-primary""></i>
                        Logout
                    </a>
                </div>
            </li>
        </ul>
        <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
            <span class=""mdi mdi-menu""></span>
        </button>
    </div>
</nav>
<!-- partial -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

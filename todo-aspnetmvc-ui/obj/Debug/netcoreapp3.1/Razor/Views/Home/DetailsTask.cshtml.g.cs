#pragma checksum "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fff3b822aea535ea41c94900282136f4512e0033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailsTask), @"mvc.1.0.view", @"/Views/Home/DetailsTask.cshtml")]
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
#line 1 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_aspnetmvc_ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_aspnetmvc_ui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_aspnetmvc_ui.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_domain_entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\_ViewImports.cshtml"
using todo_domain_entities.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff3b822aea535ea41c94900282136f4512e0033", @"/Views/Home/DetailsTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678ce27e6bfe70bf4ed82ed40783c3773693d740", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_DetailsTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoTask>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
  
    ViewData["Title"] = "Task Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>\r\n    ");
#nullable restore
#line 8 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
Write(Model.TaskTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
     if (Model.TaskTag != null && Model.TaskTag != string.Empty)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"float:right\">\r\n            <span class=\"badge badge-primary\">");
#nullable restore
#line 12 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
                                         Write(Model.TaskTag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </span>\r\n");
#nullable restore
#line 14 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
       Write(Html.DisplayFor(model => model.TaskStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 26 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
         if (Model.TaskDescription != null && Model.TaskDescription != string.Empty)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 29 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 32 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayFor(model => model.TaskDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 34 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskCreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
       Write(Html.DisplayFor(model => model.TaskCreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 42 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
         if (Model.TaskDueDate != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 45 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 48 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayFor(model => model.TaskDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 50 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
         if (Model.TaskNotes != null && Model.TaskNotes != string.Empty)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 55 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 58 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayFor(model => model.TaskNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 60 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
         if (Model.TaskTag != null && Model.TaskTag != string.Empty)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 65 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskTag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 68 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
           Write(Html.DisplayFor(model => model.TaskTag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 70 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\'", 2150, "\'", 2215, 1);
#nullable restore
#line 75 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\DetailsTask.cshtml"
WriteAttributeValue("", 2157, Url.Action("EditTask", "Home", new { id = Model.TaskId }), 2157, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Edit</a>\r\n    <a href=\"javascript:history.go(-1)\" class=\"btn btn-outline-dark btn-sm\">Back</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoTask> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1322bca9e449f3f363e86d42c456c86345b9dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1322bca9e449f3f363e86d42c456c86345b9dc", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678ce27e6bfe70bf4ed82ed40783c3773693d740", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListTaskViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-pressed", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "List Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
 if (!Model.Tasks.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 9 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
   Write(Model.TDList.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h5 class=\"text-center\">\r\n        Ups! Your is list is empty.\r\n    </h5>\r\n    <div class=\"text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1322bca9e449f3f363e86d42c456c86345b9dc7860", async() => {
                WriteLiteral("Create new task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1322bca9e449f3f363e86d42c456c86345b9dc9545", async() => {
                WriteLiteral("Create new list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1322bca9e449f3f363e86d42c456c86345b9dc10966", async() => {
                WriteLiteral("Create new task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1322bca9e449f3f363e86d42c456c86345b9dc12388", async() => {
                WriteLiteral("<i class=\"fa-solid fa-gear\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n    <h1>");
#nullable restore
#line 24 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
   Write(Model.TDList.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 26 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
     foreach (var item in Model.Tasks)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=\"", 895, "\"", 917, 2);
            WriteAttributeValue("", 900, "item-", 900, 5, true);
#nullable restore
#line 29 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 905, item.TaskId, 905, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card task\" data-completed=");
#nullable restore
#line 29 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                                                                Write(item.TaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" data-duedate=");
#nullable restore
#line 29 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                                                                                              Write(item.TaskDueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            <!-- Card with task -->\r\n            <div class=\"card-body\">\r\n                <div class=\"form-check-inline\">\r\n                    <label class=\"form-check-label taskCheckbox\">\r\n");
#nullable restore
#line 34 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                         if (item.TaskStatus == Status.NotStarted){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\" class=\"custom-checkbox\" title=\"Task: Not Started\" disabled>\r\n");
#nullable restore
#line 36 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                        }
                        else if (item.TaskStatus == Status.InProgress)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\" class=\"custom-checkbox indeterminate\"");
            BeginWriteAttribute("id", " id=\"", 1587, "\"", 1617, 2);
            WriteAttributeValue("", 1592, "taskCheckbox-", 1592, 13, true);
#nullable restore
#line 39 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 1605, item.TaskId, 1605, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Task: In Progress\" disabled>\r\n");
#nullable restore
#line 40 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"checkbox\" class=\"custom-checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1814, "\"", 1844, 2);
            WriteAttributeValue("", 1819, "taskCheckbox-", 1819, 13, true);
#nullable restore
#line 43 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 1832, item.TaskId, 1832, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"2\" title=\"Task: Completed\" checked disabled>\r\n");
#nullable restore
#line 44 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </label>\r\n                </div>\r\n                <div class=\"form-check-inline col-3\">\r\n                    <h5>");
#nullable restore
#line 48 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                   Write(item.TaskTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"form-check-inline task-date\">\r\n");
#nullable restore
#line 51 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                     if (item.TaskDueDate != null)
                    {
                        Model.TaskDueDate = (DateTime)item.TaskDueDate;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n                            Due Date:\r\n                            ");
#nullable restore
#line 56 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                       Write(Html.DisplayFor(model => model.TaskDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 58 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

                <!-- Settings button -->
                <div class=""d-inline text-right"">
                    <span style=""float:right"">
                        <div class=""dropdown"">
                            <button class=""btn btn-outline-dark btn-borderless dropdown-toggle""
                                type=""button""
                                id=""dropdownMenuButton"" 
                                data-toggle=""dropdown"" 
                                aria-haspopup=""true""
                                aria-expanded=""false"">
                                <i class=""fa-solid fa-ellipsis-vertical""></i>
                            </button>  

                            <div class=""dropdown-menu dropdown-menu-right text-center task-dropdown-menu"" 
                                aria-labelledby=""dropdownMenuButton"">
                                <ul class=""nav justify-content-center"">
                                    <li class=""nav-item"">
       ");
            WriteLiteral("                                 <a");
            BeginWriteAttribute("href", " href=\'", 3566, "\'", 3634, 1);
#nullable restore
#line 78 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 3573, Url.Action("UpdateStatus", "Home", new { id = item.TaskId }), 3573, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link text-dark\">Update Status</a>\r\n                                    </li>\r\n                                    <li class=\"nav-item\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\'", 3826, "\'", 3890, 1);
#nullable restore
#line 81 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 3833, Url.Action("EditTask", "Home", new { id = item.TaskId }), 3833, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link text-dark\">Edit</a>\r\n                                    </li>\r\n                                    <li class=\"nav-item\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\'", 4073, "\'", 4135, 1);
#nullable restore
#line 84 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 4080, Url.Action("Remind", "Home", new { id = item.TaskId }), 4080, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link text-dark\">Remind</a>\r\n                                    </li>\r\n                                    <li class=\"nav-item\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\'", 4320, "\'", 4386, 1);
#nullable restore
#line 87 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 4327, Url.Action("DeleteTask", "Home", new { id = item.TaskId }), 4327, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link text-dark"">Delete</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </span>
                </div>

                <a");
            BeginWriteAttribute("href", " href=\'", 4650, "\'", 4717, 1);
#nullable restore
#line 95 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
WriteAttributeValue("", 4657, Url.Action("DetailsTask", "Home", new { id = item.TaskId }), 4657, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"stretched-link\"></a>\r\n            </div>\r\n      </div>\r\n");
#nullable restore
#line 98 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\klaku\source\repos\aspnet-core-final-project\todo-application\todo-aspnetmvc-ui\Views\Home\Details.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1322bca9e449f3f363e86d42c456c86345b9dc24721", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListTaskViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

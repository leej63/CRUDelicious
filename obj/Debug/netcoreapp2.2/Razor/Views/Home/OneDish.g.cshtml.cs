#pragma checksum "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0787c79bf20e1522f6b7b4b1695a6160d93a3d24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneDish), @"mvc.1.0.view", @"/Views/Home/OneDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OneDish.cshtml", typeof(AspNetCore.Views_Home_OneDish))]
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
#line 1 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0787c79bf20e1522f6b7b4b1695a6160d93a3d24", @"/Views/Home/OneDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRUDelicious.Models.Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 41, true);
            WriteLiteral("<div>\r\n    <a href=\"/\">Home</a>\r\n    <h1>");
            EndContext();
            BeginContext(75, 10, false);
#line 4 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(85, 15, true);
            WriteLiteral("</h1>\r\n    <h2>");
            EndContext();
            BeginContext(101, 10, false);
#line 5 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml"
   Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(111, 14, true);
            WriteLiteral("</h2>\r\n    <p>");
            EndContext();
            BeginContext(126, 17, false);
#line 6 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(143, 23, true);
            WriteLiteral("</p>\r\n    <p>Calories: ");
            EndContext();
            BeginContext(167, 14, false);
#line 7 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml"
            Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(181, 24, true);
            WriteLiteral("</p>\r\n    <p>Tastiness: ");
            EndContext();
            BeginContext(206, 15, false);
#line 8 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml"
             Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(221, 12, true);
            WriteLiteral("</p>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 233, "\"", 261, 2);
            WriteAttributeValue("", 240, "/delete/", 240, 8, true);
#line 9 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml"
WriteAttributeValue("", 248, Model.DishId, 248, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(262, 66, true);
            WriteLiteral(">\r\n        <button type=\"submit\">Delete</button>\r\n    </a>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 328, "\"", 354, 2);
            WriteAttributeValue("", 335, "/edit/", 335, 6, true);
#line 12 "C:\Coding Dojo\C#_stack\ORMs\Entity Framework\CRUDelicious\Views\Home\OneDish.cshtml"
WriteAttributeValue("", 341, Model.DishId, 341, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 64, true);
            WriteLiteral(">\r\n        <button type=\"submit\">Edit</button>\r\n    </a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUDelicious.Models.Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c776b63d8207804c829db600f6229d6f4a3967"
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
#line 1 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
using NurlanProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
using NurlanProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c776b63d8207804c829db600f6229d6f4a3967", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Group>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<ul>\n\n");
#nullable restore
#line 8 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
     foreach (Student student in Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 10 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
       Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>");
#nullable restore
#line 11 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
       Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>");
#nullable restore
#line 12 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
       Write(student.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li>");
#nullable restore
#line 13 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
       Write(student.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 14 "/Users/nurlanmammadli/Projects/NurlanProject/NurlanProject/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Group> Html { get; private set; }
    }
}
#pragma warning restore 1591

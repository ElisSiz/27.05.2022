#pragma checksum "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9208319be0a27174919fe71c2b71c1f88efef30a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Vievs_Shared_MetatagPartial), @"mvc.1.0.view", @"/Vievs/Shared/MetatagPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9208319be0a27174919fe71c2b71c1f88efef30a", @"/Vievs/Shared/MetatagPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd3bbcd1d9d63ae1ea083e5c29db300b81bd681", @"/Vievs/_ViewImports.cshtml")]
    public class Vievs_Shared_MetatagPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 3 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 5 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 6 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>?????? ????????????????</title>\r\n");
#nullable restore
#line 10 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 299, "\"", 329, 1);
#nullable restore
#line 14 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
WriteAttributeValue("", 309, ViewBag.Description, 309, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 400, "\"", 427, 1);
#nullable restore
#line 19 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
WriteAttributeValue("", 410, ViewBag.Keywords, 410, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 20 "C:\Users\jerry\source\repos\WebApplication4\WebApplication4\Vievs\Shared\MetatagPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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

#pragma checksum "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15631877d4350b9d4e3424f8af6e705ee93b2525"
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
#line 1 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\_ViewImports.cshtml"
using SuperHeroCreatorBuildTwo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\_ViewImports.cshtml"
using SuperHeroCreatorBuildTwo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15631877d4350b9d4e3424f8af6e705ee93b2525", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79b375b1b3ba8dd179461fae68650c8e5d6598a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SuperHero>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {   
    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <h1 class=\"red-class\">");
#nullable restore
#line 11 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml"
                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml"
                                        Write(item.AlterEgo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml"
                                                       Write(item.PrimaryAbility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 246, "\"", 267, 1);
#nullable restore
#line 12 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml"
WriteAttributeValue("", 252, item.HeroImage, 252, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <hr />\r\n");
#nullable restore
#line 14 "C:\Users\Nicholas\Desktop\DevCode\Thulium\SuperHeroCreatorBuildTwo\SuperHeroCreatorBuildTwo\Views\Home\Index.cshtml"

    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SuperHero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
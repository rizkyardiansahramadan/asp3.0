#pragma checksum "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0267db3d34b39c0ec33d02d194583754128b003d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Twice.Pages.Pages_Twice), @"mvc.1.0.razor-page", @"/Pages/Twice.cshtml")]
namespace Twice.Pages
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
#line 1 "C:\Users\lenov\source\repos\Twice\Twice\Pages\_ViewImports.cshtml"
using Twice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0267db3d34b39c0ec33d02d194583754128b003d", @"/Pages/Twice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aaaf12671f06701740383731478fb51c8a71f75", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Twice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
  
    ViewData["Title"] = "Home daftar album twice";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h4>LIST DAFTAR ALBUM TWICE</h4>
<hr />
<button class=""btn btn-lg btn-primary btn-block text-uppercase col-md-3"" type=""button""
        onclick=""location.href='TwiceAdd'"">
    SAVE ALBUM
</button>
<div class=""row"">
    <div class=""col-md-6"">
        <table class=""table table-striped border"">
            <tr class=""table-secondary"">
                <th>ID</th>
                <th>NAMA_ALBUM</th>
                <th>TAHUN</th>
                <th>PRODUSER</th>
                <th>Action</th>
            </tr>
");
#nullable restore
#line 22 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
             foreach (var item in Model.DataTwice)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
                   Write(Html.DisplayFor(m => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
                   Write(Html.DisplayFor(m => item.nama_album));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
                   Write(Html.DisplayFor(m => item.tahun));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
                   Write(Html.DisplayFor(m => item.produser));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1027, "\"", 1066, 2);
            WriteAttributeValue("", 1034, "TwiceAdd?action=edit&id=", 1034, 24, true);
#nullable restore
#line 30 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
WriteAttributeValue("", 1058, item.id, 1058, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">edit</a>\r\n                        |\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1155, "\"", 1196, 2);
            WriteAttributeValue("", 1162, "TwiceAdd?action=delete&id=", 1162, 26, true);
#nullable restore
#line 32 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
WriteAttributeValue("", 1188, item.id, 1188, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\lenov\source\repos\Twice\Twice\Pages\Twice.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Twice.Pages.TwiceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Twice.Pages.TwiceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Twice.Pages.TwiceModel>)PageContext?.ViewData;
        public Twice.Pages.TwiceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5940790e6139c9beed9d2d8f34126821b46e20b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Shared__sidebar), @"mvc.1.0.view", @"/Views/_Shared/_sidebar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5940790e6139c9beed9d2d8f34126821b46e20b2", @"/Views/_Shared/_sidebar.cshtml")]
    #nullable restore
    public class Views__Shared__sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- ========== Left Sidebar Start ========== -->
<div class=""vertical-menu"">

    <div data-simplebar class=""h-100"">

        <!--- Sidemenu -->
        <div id=""sidebar-menu"">
            <!-- Left Menu Start -->
            <ul class=""metismenu list-unstyled"" id=""side-menu"">
                <li class=""menu-title"">Menu</li>

                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""ri-store-2-line""></i>
                        <span>Productos</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a");
            BeginWriteAttribute("href", " href=", 672, "", 711, 1);
#nullable restore
#line 18 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 678, Url.Action("Index", "Productos"), 678, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tabla Productos</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=", 768, "", 816, 1);
#nullable restore
#line 19 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 774, Url.Action("Index", "RegistrarProductos"), 774, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Agregar productos</a></li>
                        
                    </ul>
                </li>

              

                <li class=""menu-title"">Administrador</li>

                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""ri-account-circle-line""></i>
                        <span>Autenticacion</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a");
            BeginWriteAttribute("href", " href=", 1345, "", 1383, 1);
#nullable restore
#line 34 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 1351, Url.Action("Index", "Usuarios"), 1351, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tabla Usaurios</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=", 1439, "", 1481, 1);
#nullable restore
#line 35 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 1445, Url.Action("Index", "AuthRegister"), 1445, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Registro</a></li>
                      
                    </ul>
                </li>

                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""ri-profile-line""></i>
                        <span>Roles</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a");
            BeginWriteAttribute("href", " href=", 1905, "", 1940, 1);
#nullable restore
#line 46 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 1911, Url.Action("Index", "Roles"), 1911, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tabla roles</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=", 1993, "", 2039, 1);
#nullable restore
#line 47 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 1999, Url.Action("Index", "PagesMaintenance"), 1999, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Registrar roles</a></li>
                        
                    </ul>
                </li>
                
                <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""ri-profile-line""></i>
                        <span>Marcas</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a");
            BeginWriteAttribute("href", " href=", 2489, "", 2524, 1);
#nullable restore
#line 58 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 2495, Url.Action("Index", "Marca"), 2495, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tabla Marcas</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=", 2578, "", 2624, 1);
#nullable restore
#line 59 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 2584, Url.Action("Index", "PagesMaintenance"), 2584, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Registrar Marcas</a></li>
                        
                    </ul>
                </li>
                 <li>
                    <a href=""javascript: void(0);"" class=""has-arrow waves-effect"">
                        <i class=""ri-profile-line""></i>
                        <span>Provedores</span>
                    </a>
                    <ul class=""sub-menu"" aria-expanded=""false"">
                        <li><a");
            BeginWriteAttribute("href", " href=", 3062, "", 3102, 1);
#nullable restore
#line 69 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 3068, Url.Action("Index", "Provedores"), 3068, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tabla Provedores</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=", 3160, "", 3206, 1);
#nullable restore
#line 70 "C:\Users\dougl\OneDrive\Escritorio\Nazox_Asp.net_v1.0.0 - copia\Nazox Asp.net Core\Nazox\Views\_Shared\_sidebar.cshtml"
WriteAttributeValue("", 3166, Url.Action("Index", "PagesMaintenance"), 3166, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Registrar Provedores</a></li>\r\n                        \r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <!-- Sidebar -->\r\n    </div>\r\n</div>\r\n<!-- Left Sidebar End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
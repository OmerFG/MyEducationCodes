#pragma checksum "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\Pages\Student.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1aee51b36f92dfc9ab6a918c9adaa58e178974"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorIntro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/student")]
    public partial class Student : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Projects\myEducationCodes\WebDev\Blazor\BlazorIntro\BlazorIntro\Pages\Student.razor"
       
    public string StudentList { get; set; }
    private string saveMessage;
    protected override async Task OnInitializedAsync()
    {
        StudentList = "Omer Faruk Gunes";
    }
    private void Save(MouseEventArgs e)
    {
        saveMessage = "Saved";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

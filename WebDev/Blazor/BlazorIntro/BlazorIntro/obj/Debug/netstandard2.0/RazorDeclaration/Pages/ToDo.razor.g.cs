#pragma checksum "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "008e2206ecc26d0c945fdd5d3094d4508d6e3b2d"
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
#line 1 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#line 7 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro;

#line default
#line hidden
#line 9 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/ToDo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 36 "C:\Users\OmerFG\source\repos\BlazorIntro\BlazorIntro\Pages\ToDo.razor"
       

    todoItem[] todoItems;
    protected override async Task OnInitializedAsync()
    {
        todoItems = await Http.GetFromJsonAsync<todoItem[]>(requestUri: "http://jsonplaceholder.typicode.com/todos");
    }
    public class todoItem
    {
        public int UserID { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

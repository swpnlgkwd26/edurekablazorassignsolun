#pragma checksum "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\TableHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc1a96d41bbf033022b4136112e4abace39fc74"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_app.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using blazor_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using blazor_app.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\_Imports.razor"
using blazor_app.Data;

#line default
#line hidden
#nullable disable
    public partial class TableHeader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "thead");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "tr");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "th");
            __builder.AddContent(5, 
#nullable restore
#line 3 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\TableHeader.razor"
             AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "th");
            __builder.AddContent(8, 
#nullable restore
#line 4 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\TableHeader.razor"
             AccountHolderName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "th");
            __builder.AddContent(11, 
#nullable restore
#line 5 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\TableHeader.razor"
             Balance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "th");
            __builder.AddContent(14, 
#nullable restore
#line 6 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\TableHeader.razor"
             TypeOfAccount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\TableHeader.razor"
       
    [Parameter]
    public string AccountNumber { get; set; }
    [Parameter]
    public string AccountHolderName { get; set; }
    [Parameter]
    public string Balance { get; set; }
    [Parameter]
    public string TypeOfAccount { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class TableRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\TableRow.razor"
       
    [Parameter]
    public int AccountNumber { get; set; }
    [Parameter]
    public string AccountHolderName { get; set; }
    [Parameter]
    public double Balance { get; set; }
    [Parameter]
    public string TypeOfAccount { get; set; }

    public void onDeleteClicked()
    {
       
        NavigationManager.NavigateTo("/confirmdelete/"+AccountNumber);
         
    }

    public void onEditClicked()
    {
        NavigationManager.NavigateTo("/update/" + AccountNumber);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStoreRepository _repository { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41d945690a309f44af78505b78897d553ac7f07"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/update/{AccountNumber}")]
    public partial class UpdateAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Modify Account</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                 AccountDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                                SaveAccount

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<label>AccountNumber</label>\r\n        ");
                __builder2.OpenElement(12, "label");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.OpenElement(14, "span");
                __builder2.AddContent(15, 
#nullable restore
#line 11 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                           AccountDetails.AccountNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "    \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.AddMarkupContent(21, "<label>CustomerId</label>\r\n        ");
                __builder2.OpenElement(22, "label");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.OpenElement(24, "span");
                __builder2.AddContent(25, 
#nullable restore
#line 15 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                           AccountDetails.CustomerId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.AddMarkupContent(31, "<label>AccountHolderName</label>\r\n        ");
                __Blazor.blazor_app.Pages.UpdateAccount.TypeInference.CreateValidationMessage_0(__builder2, 32, 33, 
#nullable restore
#line 19 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                  ()=>AccountDetails.AccountHolderName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "label");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.OpenElement(37, "span");
                __builder2.AddContent(38, 
#nullable restore
#line 20 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                           AccountDetails.AccountHolderName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<label>Balance</label>\r\n        ");
                __Blazor.blazor_app.Pages.UpdateAccount.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 24 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                  ()=>AccountDetails.Balance

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n        ");
                __Blazor.blazor_app.Pages.UpdateAccount.TypeInference.CreateInputNumber_2(__builder2, 48, 49, "form-control", 50, 
#nullable restore
#line 25 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                                       AccountDetails.Balance

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountDetails.Balance = __value, AccountDetails.Balance)), 52, () => AccountDetails.Balance);
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.AddMarkupContent(58, "<label>Address</label>\r\n        ");
                __Blazor.blazor_app.Pages.UpdateAccount.TypeInference.CreateValidationMessage_3(__builder2, 59, 60, 
#nullable restore
#line 29 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                  ()=>AccountDetails.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                                     AccountDetails.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountDetails.Address = __value, AccountDetails.Address))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AccountDetails.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.AddMarkupContent(72, "<label>MobileNumber</label>\r\n        ");
                __Blazor.blazor_app.Pages.UpdateAccount.TypeInference.CreateValidationMessage_4(__builder2, 73, 74, 
#nullable restore
#line 34 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                  ()=>AccountDetails.MobileNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                                     AccountDetails.MobileNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountDetails.MobileNumber = __value, AccountDetails.MobileNumber))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AccountDetails.MobileNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.AddMarkupContent(86, "<label>TypeOfAccount</label>       \r\n        ");
                __builder2.OpenElement(87, "label");
                __builder2.AddAttribute(88, "class", "form-control");
                __builder2.OpenElement(89, "span");
                __builder2.AddContent(90, 
#nullable restore
#line 39 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
                                           AccountDetails.TypeOfAccount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.AddMarkupContent(93, "<button class=\"btn btn-primary\" type=\"submit\">Save</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\FreeLancerAssignments\PPT Edureka\SolutionFolder\Week4AssignmentSolution\edurekablazorassignsolun\blazor-app\Pages\UpdateAccount.razor"
       
    [Parameter]
    public string AccountNumber { get; set; }

    public Account AccountDetails { get; set; }

   
    protected async override Task OnInitializedAsync()
    {
        AccountDetails = await _repository.GetAccountByNumber(Convert.ToInt32(AccountNumber));
    }


    public async Task SaveAccount()
    {
        await _repository.UpdateAccount(AccountDetails);
        NavigationManager.NavigateTo("/accounts");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStoreRepository _repository { get; set; }
    }
}
namespace __Blazor.blazor_app.Pages.UpdateAccount
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FamilyData.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using FamilyData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\_Imports.razor"
using FamilyData.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\Pages\AdultView.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\Pages\AdultView.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultView")]
    public partial class AdultView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\tymon\RiderProjects\Assignment1\FamilyData\Pages\AdultView.razor"
       
    List<Adult> Adults;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591

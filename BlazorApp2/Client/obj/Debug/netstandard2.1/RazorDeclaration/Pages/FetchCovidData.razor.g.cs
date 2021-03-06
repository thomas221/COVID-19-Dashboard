// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using BlazorApp2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using BlazorApp2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchCovidData.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchcoviddata")]
    public partial class FetchCovidData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\thoma\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchCovidData.razor"
       
    private string coviddatatotaldeaths;
    private string coviddatatotalinfected;
    private string percentagebesmet;
    private string percentagegestorven;
    private string dateOfToday;
    private int totalebevolking = 11521238;
    private string totaalgevaccineerd;




    protected override async Task OnInitializedAsync()
    {
        coviddatatotaldeaths = await Http.GetStringAsync("CovidDataTotalDeaths");
        coviddatatotalinfected = await Http.GetStringAsync("CovidDataTotalInfected");
        percentagebesmet = String.Format("{0:0.00}%", Double.Parse(coviddatatotalinfected) * 100 / totalebevolking);
        percentagegestorven = String.Format("{0:0.00}%", Double.Parse(coviddatatotaldeaths) * 100 / totalebevolking);
        dateOfToday = DateTime.Now.ToString("dd/MM/yyyy");
        totaalgevaccineerd = await Http.GetStringAsync("CovidDataTotalVaccinated");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/Pages/Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fc272b120273ab6d4efd4d0eaa5a3ad2f0b1655"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Showcase.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Showcase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/_Imports.razor"
using Showcase.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "/Users/christiannelson/Documents/dev/dotnet/Showcase/Showcase/Pages/Calculator.razor"
       
    static string defaultDisplay = "DISPLAY";
    string display = defaultDisplay;
    float num;
    char op = ' ';


    public void ConcatDisplay(string value)
    {
        if (display == defaultDisplay ||
            display == "+" ||
            display == "-" ||
            display == "×" ||
            display == "÷")
        {
            display = "";
        }
        if (display.EndsWith(".") && value == ".")
        {
        }
        else
        {
            display += value;
        }

    }

    public void Negate()
    {
        if(display[0] == '-')
        {
            display = display.Substring(1);
        }
        else if(display == defaultDisplay)
        {
            display = "-";
        }
        else
        {
            display = "-" + display;
        }
    }

    public void Clear()
    {
        display = defaultDisplay;
        op = ' ';
    }

    public void ParseDisplay()
    {
        num = float.Parse(display);
    }

    public void EqualCall()
    {
        if(display != defaultDisplay && op != ' ')
        {
            if(op == '+')
            {
                display = (num + float.Parse(display)).ToString();
            }
            else if(op == '-')
            {
                display = (num - float.Parse(display)).ToString();
            }
            else if(op == '×')
            {
                display = (num * float.Parse(display)).ToString();
            }
            else if(op == '÷')
            {
                display = (num / float.Parse(display)).ToString();
            }
        }

        op = ' ';

    }

    public void SetOp(char op)
    {
        this.op = op;
        ParseDisplay();
        display = op.ToString();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
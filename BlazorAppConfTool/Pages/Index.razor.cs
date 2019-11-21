using BlazorAppConfTool.Models;
using BlazorAppConfTool.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppConfTool.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public ConferencesService ConferencesService { get; set; }

        public List<Conference> Conferences = new List<Conference>();

        protected override async Task OnInitializedAsync()
        {
            var result = await ConferencesService.GetConferences();
            Conferences = result.Conferences;
        }
    }
}

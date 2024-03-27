using BlazorWasm.HospitalManagementSystem.Models;
using BlazorWasm.HospitalManagementSystem.Pages.Disease;
using BlazorWasm.HospitalManagementSystem.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorWasm.HospitalManagementSystem.Pages.Room;

public partial class PageRoom : ComponentBase
{
    private IQueryable<RoomModel>? Data;
    private RoomModel Item = new();

    protected override async Task OnInitializedAsync()
    {
        await List();
    }

    private async Task List()
    {
        Loading.EnableLoading();
        var lst = await ApiService.Execute<List<RoomModel>>(ApiUrl.Rooms, Method.Get);
        Data = lst.OrderByDescending(x => x.id).AsQueryable();
        Loading.DisableLoading();
    }

    private async Task Create()
    {
        var dialog = await DialogService.ShowDialogAsync<PageRoomDialog>(Item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute(ApiUrl.Rooms, Method.Post, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Edit(RoomModel disease)
    {
        var dialog = await DialogService.ShowDialogAsync<PageRoomDialog>(disease, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute($"{ApiUrl.Rooms}/{disease.id}", Method.Put, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Delete(RoomModel disease)
    {
        var dialog = await DialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
        var result = await dialog.Result;
        var canceled = result.Cancelled;
        if (canceled) return;

        Loading.EnableLoading();
        await ApiService.Execute($"{ApiUrl.Rooms}/{disease.id}", Method.Delete);
        Item = new();
        await List();
    }
}

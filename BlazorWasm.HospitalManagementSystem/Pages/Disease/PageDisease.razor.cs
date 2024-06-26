﻿namespace BlazorWasm.HospitalManagementSystem.Pages.Disease;

public partial class PageDisease : ComponentBase
{
    private IQueryable<DiseaseModel>? Data;
    private DiseaseModel Item = new();

    protected override async Task OnInitializedAsync()
    {
        await List();
    }

    private async Task List()
    {
        Loading.EnableLoading();
        var lst = await ApiService.Execute<List<DiseaseModel>>(ApiUrl.Diseases, Method.Get);
        Data = lst.OrderByDescending(x => x.id).AsQueryable();
        Loading.DisableLoading();
    }

    private async Task Create()
    {
        var dialog = await DialogService.ShowDialogAsync<PageDiseaseDialog>(Item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute(ApiUrl.Diseases, Method.Post, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Edit(DiseaseModel item)
    {
        var dialog = await DialogService.ShowDialogAsync<PageDiseaseDialog>(item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute($"{ApiUrl.Diseases}/{item.id}", Method.Put, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Delete(DiseaseModel item)
    {
        var dialog = await DialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
        var result = await dialog.Result;
        var canceled = result.Cancelled;
        if (canceled) return;

        Loading.EnableLoading();
        await ApiService.Execute($"{ApiUrl.Diseases}/{item.id}", Method.Delete);
        Item = new();
        await List();
    }
}

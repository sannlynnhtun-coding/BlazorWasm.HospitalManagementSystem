using BlazorWasm.HospitalManagementSystem.Pages.Patient;

namespace BlazorWasm.HospitalManagementSystem.Pages.Doctor;

public partial class PageDoctor : ComponentBase
{
    private IQueryable<DoctorModel>? Data;
    private DoctorCreateModel Item = new();

    protected override async Task OnInitializedAsync()
    {
        await List();
    }

    private async Task List()
    {
        Loading.EnableLoading();
        var lst = await ApiService.Execute<List<DoctorModel>>(ApiUrl.Doctor, Method.Get);
        Data = lst.OrderByDescending(x => x.Id).AsQueryable();
        Loading.DisableLoading();
    }

    private async Task Create()
    {

        var dialog = await DialogService.ShowDialogAsync<PageDoctorDialog>(Item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute(ApiUrl.Doctor, Method.Post, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Edit(DoctorModel item)
    {
        var dialog = await DialogService.ShowDialogAsync<PageDoctorDialog>(item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute($"{ApiUrl.Doctor}/{item.Id}", Method.Put, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Delete(DoctorModel item)
    {
        var dialog = await DialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
        var result = await dialog.Result;
        var canceled = result.Cancelled;
        if (canceled) return;

        Loading.EnableLoading();
        await ApiService.Execute($"{ApiUrl.Doctor}/{item.Id}", Method.Delete);
        Item = new();
        await List();
    }
}

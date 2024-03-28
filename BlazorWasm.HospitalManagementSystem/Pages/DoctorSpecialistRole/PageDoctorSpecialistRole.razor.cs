namespace BlazorWasm.HospitalManagementSystem.Pages.DoctorSpecialistRole;

public partial class PageDoctorSpecialistRole
{
    private IQueryable<DoctorSpecialistRoleModel>? Data;
    private DoctorSpecialistRoleModel Item = new();

    protected override async Task OnInitializedAsync()
    {
        await List();
    }

    private async Task List()
    {
        Loading.EnableLoading();
        var lst = await ApiService.Execute<List<DoctorSpecialistRoleModel>>(ApiUrl.DoctorSpecialistRole, Method.Get);
        Data = lst.OrderByDescending(x => x.Id).AsQueryable();
        Loading.DisableLoading();
    }

    private async Task Create()
    {
        var dialog = await DialogService.ShowDialogAsync<PageDoctorSpecialistRoleDialog>(Item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute(ApiUrl.DoctorSpecialistRoleCreate, Method.Post, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Edit(DoctorSpecialistRoleModel item)
    {
        var dialog = await DialogService.ShowDialogAsync<PageDoctorSpecialistRoleDialog>(item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute($"{ApiUrl.DoctorSpecialistRoleEdit}/{item.Id}", Method.Put, result.Data);
            Item = new();
            await List();
        }
    }

    private async Task Delete(DoctorSpecialistRoleModel item)
    {
        var dialog = await DialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
        var result = await dialog.Result;
        var canceled = result.Cancelled;
        if (canceled) return;

        Loading.EnableLoading();
        await ApiService.Execute($"{ApiUrl.DoctorSpecialistRoleDelete}/{item.Id}", Method.Delete);
        Item = new();
        await List();
    }
}
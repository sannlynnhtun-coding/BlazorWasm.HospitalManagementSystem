
using BlazorWasm.HospitalManagementSystem.Pages.Disease;
using Newtonsoft.Json;

namespace BlazorWasm.HospitalManagementSystem.Pages.Patient
{
    public partial class PagePatient : ComponentBase
    {
        private IQueryable<PatientModel>? Data;
        private PatientModel Item = new();

        protected override async Task OnInitializedAsync()
        {
            await List();
        }

        private async Task List()
        {
            Loading.EnableLoading();
            var lst = await ApiService.Execute<List<PatientModel>>(ApiUrl.Patient, Method.Get);
            Data = lst.OrderByDescending(x => x.id).AsQueryable();
            Loading.DisableLoading();
        }

        private async Task Create()
        {
            
            var dialog = await DialogService.ShowDialogAsync<PagePatientDialog>(Item, new DialogParameters()
            {
                PreventDismissOnOverlayClick = true,
                PreventScroll = true,
            });

            var result = await dialog.Result;
            if (!result.Cancelled && result.Data != null)
            {
                Loading.EnableLoading();
                await ApiService.Execute(ApiUrl.Patient, Method.Post, result.Data);
                Item = new();
                await List();
            }
        }

        private async Task Edit(PatientModel item)
        {
            var dialog = await DialogService.ShowDialogAsync<PagePatientDialog>(item, new DialogParameters()
            {
                PreventDismissOnOverlayClick = true,
                PreventScroll = true,
            });

            var result = await dialog.Result;
            if (!result.Cancelled && result.Data != null)
            {
                Loading.EnableLoading();
                await ApiService.Execute($"{ApiUrl.Patient}/{item.id}", Method.Put, result.Data);
                Item = new();
                await List();
            }
        }

        private async Task Delete(PatientModel item)
        {
            var dialog = await DialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
            var result = await dialog.Result;
            var canceled = result.Cancelled;
            if (canceled) return;

            Loading.EnableLoading();
            await ApiService.Execute($"{ApiUrl.Patient}/{item.id}", Method.Delete);
            Item = new();
            await List();
        }
    }
}

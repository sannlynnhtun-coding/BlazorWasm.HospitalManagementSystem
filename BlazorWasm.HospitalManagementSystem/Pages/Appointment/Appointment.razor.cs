using BlazorWasm.HospitalManagementSystem.Pages.Disease;
using Newtonsoft.Json;

namespace BlazorWasm.HospitalManagementSystem.Pages.Appointment
{
    public partial class Appointment : ComponentBase
    {
        private IQueryable<AppointmentModel>? Data;
        private AppointmentCreateModel Item = new();

        protected override async Task OnInitializedAsync()
        {
            await List();
        }

        private async Task List()
        {
            Loading.EnableLoading();
            var lst = await ApiService.Execute<List<AppointmentModel>>(ApiUrl.Appointment, Method.Get);
            Data = lst.OrderByDescending(x => x.Id).AsQueryable();
            Loading.DisableLoading();
        }

        private async Task Create()
        {
            var dialog = await DialogService.ShowDialogAsync<AppointmentDialog>(Item, new DialogParameters()
            {
                PreventDismissOnOverlayClick = true,
                PreventScroll = true,
            });

            var result = await dialog.Result;
            if (!result.Cancelled && result.Data != null)
            {
                Loading.EnableLoading();
                await ApiService.Execute(ApiUrl.Appointment, Method.Post, result.Data);
                Item = new();
                await List();
            }
        }

        private async Task Edit(AppointmentModel item)
        {
            var edit = new AppointmentCreateModel
            {
                AppointmentDate = item.AppointmentDate,
                DoctorId = item.Doctor.Id,
                PatientId = item.Patient.Id,
                RoomId = item.Room.Id,
                Status = item.Status,
                IsCancel = item.IsCancel,
            };
            var json = JsonConvert.SerializeObject(edit);
            var dialog = await DialogService.ShowDialogAsync<AppointmentDialog>(edit, new DialogParameters()
            {
                PreventDismissOnOverlayClick = true,
                PreventScroll = true,
            });

            var result = await dialog.Result;
            if (!result.Cancelled && result.Data != null)
            {
                Loading.EnableLoading();
                await ApiService.Execute($"{ApiUrl.Appointment}/{item.Id}", Method.Put, result.Data);
                Item = new();
                await List();
            }
        }

        private async Task Delete(AppointmentModel item)
        {
            var dialog = await DialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
            var result = await dialog.Result;
            var canceled = result.Cancelled;
            if (canceled) return;

            Loading.EnableLoading();
            await ApiService.Execute($"{ApiUrl.Appointment}/{item.Id}", Method.Delete);
            Item = new();
            await List();
        }
    }
}

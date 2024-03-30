using Newtonsoft.Json;

namespace BlazorWasm.HospitalManagementSystem.Pages.MedicalRecord;

public partial class PageMedicalRecord : ComponentBase
{
    private IQueryable<MedicalRecordViewModel>? Data;
    private MedicalRecordViewModel Item = new();
    private List<PatientModel> Patients = new List<PatientModel>();

    protected override async Task OnInitializedAsync()
    {
        await List();
    }

    private async Task List()
    {
        Loading.EnableLoading();
        var lst = await ApiService.Execute<List<MedicalRecordModel>>(ApiUrl.MedicalRecord, Method.Get);
        Patients = await ApiService.Execute<List<PatientModel>>(ApiUrl.Patient, Method.Get);
        Data = JsonConvert
            .DeserializeObject<List<MedicalRecordViewModel>>
            (
                JsonConvert.SerializeObject(lst)
            )
            !.OrderByDescending(x => x.Id).AsQueryable();
        Loading.DisableLoading();
    }

    private async Task Create()
    {
        var dialog = await DialogService.ShowDialogAsync<PageMedicalRecordDialog>(Item, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute(ApiUrl.MedicalRecord, Method.Post, Change(result.Data));
            Item = new();
            await List();
        }
    }

    private MedicalRecordModel Change(object obj)
    {
        var result = JsonConvert.DeserializeObject<MedicalRecordModel>(JsonConvert.SerializeObject(obj))!;
        Console.WriteLine("create => " + JsonConvert.SerializeObject(result));
        return result;
    }

    private async Task Edit(MedicalRecordViewModel medicalRecord)
    {
        var dialog = await DialogService.ShowDialogAsync<PageMedicalRecordDialog>(medicalRecord, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        if (!result.Cancelled && result.Data != null)
        {
            Loading.EnableLoading();
            await ApiService.Execute($"{ApiUrl.MedicalRecord}/{medicalRecord.Id}", Method.Put, Change(result.Data));
            Item = new();
            await List();
        }
    }

    private async Task Delete(MedicalRecordViewModel medicalRecord)
    {
        var dialog = await DialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
        var result = await dialog.Result;
        var canceled = result.Cancelled;
        if (canceled) return;

        Loading.EnableLoading();
        await ApiService.Execute($"{ApiUrl.MedicalRecord}/{medicalRecord.Id}", Method.Delete);
        Item = new();
        await List();
    }
}

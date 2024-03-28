namespace BlazorWasm.HospitalManagementSystem.Services;

public class InjectService
{
    private readonly DialogService _dialogService;

    public InjectService(DialogService dialogService)
    {
        _dialogService = dialogService;
    }

    public async Task<DialogResult> ShowDialogAsync<Dialog>(object item) where Dialog : IDialogContentComponent
    {
        var dialog = await _dialogService.ShowDialogAsync<Dialog>(item!, new DialogParameters()
        {
            PreventDismissOnOverlayClick = true,
            PreventScroll = true,
        });

        var result = await dialog.Result;
        return result!;
    }

    public async Task<DialogResult> ConfirmAsync()
    {
        var dialog = await _dialogService.ShowConfirmationAsync("Are you sure want to delete?", "Yes", "No", "Confirm");
        var result = await dialog.Result;
        return result!;
    }
}
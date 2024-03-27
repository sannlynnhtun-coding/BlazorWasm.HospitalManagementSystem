namespace BlazorWasm.HospitalManagementSystem.Services;

public class Loading
{
    private bool isEnable;

    public bool IsEnable
    {
        get => isEnable;
        set
        {
            isEnable = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();

    public void EnableLoading()
    {
        IsEnable = true;
    }
    public void DisableLoading()
    {
        IsEnable = false;
    }
}
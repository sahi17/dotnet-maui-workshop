namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {

    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsnotBusy))]
    public bool isBusy;

    [ObservableProperty]
    public string title;

    public bool IsnotBusy => !IsBusy;
}

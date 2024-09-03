using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SampleMauiApp.Default;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(BtnText))]
    int countClick;

    [RelayCommand]
    void BtnCountClick()
    {
        CountClick++;
    }

    public string BtnText
    {
        get
        {

            string result = CountClick == 0 ? "Click me" 
                : (CountClick == 1 ? $"Clicked {CountClick} time" : $"Clicked {CountClick} times");
            return result;
        }
    }
}

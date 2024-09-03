namespace SampleMauiApp.Default;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}

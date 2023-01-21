using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PrismApp1.ViewModels;

public partial class MainPageViewModel : ObservableObject, INavigatedAware
{
    private int _count;

    public MainPageViewModel()
    {
    }

    [ObservableProperty]
    string title = "Main Page";

    [ObservableProperty]
    string text = "Click me";



    [RelayCommand]
    private void Count()
    {
        _count++;
        if (_count == 1)
            Text = "Clicked 1 time";
        else if (_count > 1)
            Text = $"Clicked {_count} times";
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }
}

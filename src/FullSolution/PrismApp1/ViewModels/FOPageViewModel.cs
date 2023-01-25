using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PrismApp1.Helpers;
using PrismApp1.Models;
using System.Collections.ObjectModel;

namespace PrismApp1.ViewModels;

public partial class FOPageViewModel : ObservableObject, INavigatedAware
{
    [ObservableProperty]
    ObservableCollection<MenuData> menuDatas= new ObservableCollection<MenuData>();
    private readonly INavigationService navigationService;

    public FOPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        BuildMenuList();
    }

    [RelayCommand]
    async Task MenuTap(string command)
    {
        if(command == MagicValue.MenuHomeName)
        {
            await navigationService.NavigateAsync($"/FOPage/NaviPage/MainPage");
        }
    }

    void BuildMenuList()
    {
        menuDatas.Clear();
        menuDatas.Add(new MenuData
        {
            Title = MagicValue.MenuHomeName,
            Icon = IconFont.Home,
        });
        menuDatas.Add(new MenuData
        {
            Title = MagicValue.MenuHomeName,
            Icon = IconFont.Account,
        });
        menuDatas.Add(new MenuData
        {
            Title = MagicValue.MenuHomeName,
            Icon = IconFont.ExitToApp,
        });
    }
}

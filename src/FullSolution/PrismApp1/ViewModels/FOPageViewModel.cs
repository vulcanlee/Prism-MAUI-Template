using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PrismApp1.Helpers;
using PrismApp1.Models;
using System.Collections.ObjectModel;

namespace PrismApp1.ViewModels;

public partial class FOPageViewModel : ObservableObject, INavigatedAware
{
    #region 欄位
    private readonly INavigationService navigationService;
    [ObservableProperty]
    ObservableCollection<MenuData> menuDatas = new ObservableCollection<MenuData>();
    #endregion

    #region 屬性
    #endregion

    #region 建構式
    public FOPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;
    }
    #endregion

    #region 命令方法
    [RelayCommand]
    async Task MenuTap(string command)
    {
        if (command == MagicValue.MenuHomeName)
        {
            await navigationService.NavigateAsync($"/FOPage/NaviPage/MainPage");
        }
    }
    #endregion

    #region 導航事件
    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        if (parameters.GetNavigationMode() == Prism.Navigation.NavigationMode.New)
        {
            BuildMenuList();
        }
    }
    #endregion

    #region 方法
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
    #endregion
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PrismApp1.ViewModels;

public partial class NaviPageViewModel : ObservableObject, INavigatedAware
{
    #region 欄位
    private readonly INavigationService navigationService;
    #endregion

    #region 屬性
    #endregion

    #region 建構式
    public NaviPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;
    }
    #endregion

    #region 命令方法
    #endregion

    #region 導航事件
    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }
    #endregion

    #region 方法
    #endregion
}

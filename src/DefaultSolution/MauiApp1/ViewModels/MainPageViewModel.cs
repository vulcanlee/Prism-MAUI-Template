using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiApp1.Events;

namespace MauiApp1.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    #region Field Member
    #endregion

    #region Property Member

    [ObservableProperty]
    string title = "首頁範例";

    [ObservableProperty]
    string buttonTitle = "Click Me";

    [ObservableProperty]
    string messagerText = string.Empty;

    [ObservableProperty]
    int count = 0;

    #endregion

    #region Constructor Member
    public MainPageViewModel()
    {
        WeakReferenceMessenger.Default
            .Register<MyValueChangedMessage>(this, (r, m) =>
        {

            MessagerText = $"訊息內容 : {m.Value.Counter.ToString()}";
        });

    }
    #endregion

    #region Method Member
    #region Command Method

    [RelayCommand]
    public void CounterClicked()
    {
        Count++;

        if (Count == 1)
            ButtonTitle = $"Clicked {Count} time";
        else
            ButtonTitle = $"Clicked {Count} times";

        WeakReferenceMessenger.Default
            .Send(new MyValueChangedMessage(new Models.MyMessage()
            {
                Counter = Count
            }));
    }
    #endregion

    #region Navigation Event
    #endregion

    #region Other Method
    #endregion
    #endregion
}

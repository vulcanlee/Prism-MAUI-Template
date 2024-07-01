using CommunityToolkit.Maui;
using MauiApp1.Helpers;
using MauiApp1.Services;
using MauiApp1.ViewModels;
using MauiApp1.Views;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("materialdesignicons-webfont.ttf", MagicValueHelper.FontName);
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransientWithShellRoute<MainPage, MainPageViewModel>(MagicValueHelper.MainPage);
        builder.Services.AddTransient<CounterService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Logging.AddConsole();

        return builder.Build();
    }
}

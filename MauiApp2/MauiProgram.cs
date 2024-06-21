using MauiApp2.View_Models;
using Microsoft.Extensions.Logging;

namespace MauiApp2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddSingleton<Calendar>();
            builder.Services.AddSingleton<CalendarViewModel>();

            builder.Services.AddSingleton<Feed>();
            builder.Services.AddSingleton<FeedViewModel>();

            builder.Services.AddSingleton<FriendsPage>();
            builder.Services.AddSingleton<FriendsPageViewModel>();

            return builder.Build();
        }
    }
}


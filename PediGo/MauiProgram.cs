using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PediGo.Data;
using PediGo.Data.Actions;
using PediGo.Pages;
using PediGo.ViewModels.StorePage;

namespace PediGo
{
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
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services
                .AddSingleton<SqliteServer>()
                .AddSingleton<CategoryAction>()
                .AddSingleton<CategoriesViewModel>()
                .AddSingleton<StorePage>();

            return builder.Build();
        }
    }
}

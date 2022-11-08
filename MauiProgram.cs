using Microsoft.Extensions.DependencyInjection;
using PokedexMaui.Services;
using PokedexMaui.ViewModels;
using PokedexMaui.Views;

namespace PokedexMaui;

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

        builder.Services
            .AddSingleton<HomeView>()
            .AddSingleton<HomeViewModel>()
            .AddTransient<IPokeApiService, PokeApiService>();

        return builder.Build();
    }
}

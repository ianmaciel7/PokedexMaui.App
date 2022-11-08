using PokedexMaui.Views;

namespace PokedexMaui;

public partial class App : Application
{
    public App(HomeView homeView)
    {
        InitializeComponent();

        MainPage = homeView;
    }
}

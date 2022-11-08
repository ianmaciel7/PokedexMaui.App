using PokedexMaui.Models;
using PokedexMaui.Services;
using PokedexMaui.ViewModels;

namespace PokedexMaui.Views;

public partial class HomeView : ContentPage
{
    public HomeView(HomeViewModel homeViewModel)
    {      
        BindingContext = homeViewModel;
        InitializeComponent();
    }
}


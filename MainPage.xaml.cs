using PokedexMaui.Services;

namespace PokedexMaui;

public partial class MainPage : ContentPage
{
    private readonly IPokeApiService _pokeApiService;

    public MainPage(IPokeApiService pokeApiService)
    {
        InitializeComponent();
        _pokeApiService = pokeApiService;
    }


    private async void OnCounterClickedAsync(object sender, EventArgs e)
    {
        string str = await _pokeApiService.GetPokemons();
    }
}


using PokedexMaui.Models;
using PokedexMaui.Services;

namespace PokedexMaui;

public partial class MainPage : ContentPage
{

    public static Pagination<Pokemon> PaginationPokemons { get; private set; }
    private IPokeApiService _pokeApiService { get; }

    public MainPage(IPokeApiService pokeApiService)
    {
        _pokeApiService = pokeApiService;
        _ = InitializeComponentWithService();
    }

    private async Task InitializeComponentWithService()
    {
        string str = await _pokeApiService.GetPokemons();
        var pagination = new Pagination<Pokemon>(str);
        PaginationPokemons = pagination;
        InitializeComponent();
    }
}


using PokedexMaui.Models;
using PokedexMaui.Services;

namespace PokedexMaui.Views;

public partial class HomeView : ContentPage
{

    public static Pagination<Pokemon> PaginationPokemons { get; private set; }
    private IPokeApiService _pokeApiService { get; }

    public HomeView(IPokeApiService pokeApiService)
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


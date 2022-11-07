using PokedexMaui.Models;
using PokedexMaui.Services;

namespace PokedexMaui;

public partial class MainPage : ContentPage
{
    public static Pagination<Pokemon> MockPaginationPokemons { get; private set; }

    static MainPage()
    {
        MockPaginationPokemons = new Pagination<Pokemon>()
        {
            Next = null,
            Previus = null,
            Results = new List<Pokemon>() {
                    new Pokemon { Name = "test1", Url = "testurl1" },
                    new Pokemon { Name = "test2", Url = "testurl2" },
                }
        };
    }

    public MainPage(IPokeApiService pokeApiService)
    {
        InitializeComponent();     
    }
}


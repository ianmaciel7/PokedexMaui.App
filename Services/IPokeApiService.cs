namespace PokedexMaui.Services
{
    public interface IPokeApiService
    {
        Task<string> GetPokemons();
    }
}
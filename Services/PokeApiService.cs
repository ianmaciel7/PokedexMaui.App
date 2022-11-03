using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMaui.Services
{
    internal class PokeApiService : IPokeApiService
    {
        public static readonly string BaseAddress;
        public static readonly string Version;
        public static readonly string Url;

        private readonly HttpClient HttpClient;

        static PokeApiService()
        {
            BaseAddress = "https://pokeapi.co";
            Version = "/api/v2";
            Url = BaseAddress + Version;

        }

        public PokeApiService()
        {
            HttpClient = new HttpClient();
        }

        public async Task<string> GetPokemons()
        {
            string path = "pokemon";

            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                Debug.WriteLine("não tem conexão");

            return await HttpClient.GetStringAsync(Uri(path));
        }

        private string Uri(string path)
        {
            return Url + "/" + path;
        }
    }
}

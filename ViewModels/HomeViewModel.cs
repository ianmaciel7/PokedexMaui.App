using PokedexMaui.Models;
using PokedexMaui.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMaui.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Pagination<Pokemon> _paginationPokemons;
        public Pagination<Pokemon> PaginationPokemons
        {
            get => _paginationPokemons;
            set
            {
                _paginationPokemons = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel(IPokeApiService service)
        {
            PaginationPokemons = new Pagination<Pokemon>();
            _ = loadPokemons(service);
        }

        private async Task loadPokemons(IPokeApiService service)
        {
            string str = await service.GetPokemons();
            var pagination = new Pagination<Pokemon>(str);
            PaginationPokemons = pagination;
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    }
}

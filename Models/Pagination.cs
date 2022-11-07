using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokedexMaui.Models
{
    public class Pagination<T>
    {
        public string? Next { get; set; }
        public string? Previus { get; set; }
        public ICollection<T> Results { get; set; }
        public int Count { get { return Results.Count; } }

        public Pagination(string str)
        {
            var requestResult = deserialize(str);
            this.Next = requestResult.Next;
            this.Previus = requestResult.Previus;
            this.Results = requestResult.Results;
        }

        public Pagination()
        {
            Next = null;
            Previus = null;
            Results = new List<T>();
        }

        private static Pagination<T> deserialize(string str)
        {

            var value = JsonSerializer.Deserialize<Pagination<T>>(
                str,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
            return value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}


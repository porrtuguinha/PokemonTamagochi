using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pokemonAgoraVai.models
{
    internal class ChamaPokemon
    {
        Pokemon2 pokemon1;

        public async void chamaPokemon(string pokemon)
        {

            string link = $"https://pokeapi.co/api/v2/pokemon/{pokemon}";
            var rest = new RestClient(link);
            var resposta = new RestRequest(link, Method.Get);
            var request = rest.ExecuteGetAsync(resposta);
            pokemon1 = JsonSerializer.Deserialize<Pokemon2>(request.Result.Content);
        }

        internal void chamaPokemon(object pokemonEscolhido)
        {
            throw new NotImplementedException();
        }
    }
}


using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemonAgoraVai.models
{
    public static class ChamaPokemon
    {
        public static Pokemon2 pokemon1;

        public static Pokemon2  chamaPokemon(string pokemon)
        {
            try
            {
                string link = $"https://pokeapi.co/api/v2/pokemon/{pokemon}";
                var rest = new RestClient(link);
                var resposta = new RestRequest(link, Method.Get);
                var request = rest.ExecuteGetAsync(resposta);
                pokemon1 = JsonSerializer.Deserialize<Pokemon2>(request.Result.Content);
            } catch (Exception ex)
            {
                return null;
            }
                return pokemon1;  
        }

            

    }
}


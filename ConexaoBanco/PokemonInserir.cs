using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonAgoraVai.ConexaoBanco
{
    public class PokemonInserir

    {
        public Conecta conecta = new Conecta();
        public SqlCommand cmd = new SqlCommand();
        public void inserir(string pokemon)
        {
            cmd.CommandText = "insert into Pokemon(Nome) values('" + pokemon + "') ";


            try
            {
            cmd.Connection = conecta.conectar();
                cmd.ExecuteNonQuery();
                conecta.Desconectar();
            } catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

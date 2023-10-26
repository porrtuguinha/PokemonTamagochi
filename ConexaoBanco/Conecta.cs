using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonAgoraVai.ConexaoBanco
{
    public class Conecta {
       public SqlConnection con = new SqlConnection();
        public Conecta()
        {
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Usuario\\Desktop\\Pokemon.mdf;Integrated Security=True;Connect Timeout=30";


        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)

            {
                con.Open();

            }
            return con;
        }
        public SqlConnection Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)

            {
                con.Close();

            }
            return con;
        }





    }

}

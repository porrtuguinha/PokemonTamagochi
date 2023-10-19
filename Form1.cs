using pokemonAgoraVai.ConexaoBanco;
using pokemonAgoraVai.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;
using Type = pokemonAgoraVai.models.Type;

namespace pokemonAgoraVai
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        PokemonInserir inserir = new PokemonInserir();
        Pokemon2 pokemon = new Pokemon2();
           



public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int aleatorio = random.Next(4000);
                int aleatorio2 = random.Next(4000);
                PokemonInserir inserir = new PokemonInserir();
                inserir.inserir(textoEscolha.Text);
                pokemon = ChamaPokemon.chamaPokemon(textoEscolha.Text);
                label1.Visible = false;
                pictureBox1.WaitOnLoad = false;
                if (aleatorio == aleatorio2)
                {
                    pictureBox1.LoadAsync(pokemon.sprites.front_shiny);
                }
                else
                {
                    pictureBox1.LoadAsync(pokemon.sprites.front_default);
                }
                nomeD.Visible = true;
                nome.Text = pokemon.name;
                foreach (Type tipo1 in pokemon.types)
                {
                    tipos.Items.Add(tipo1.type.name);
                }
                tipoD.Visible = true;
                tipos.Visible = true;
                peso.Text = pokemon.weight.ToString() + " Gramas";
                pesoD.Visible = true;
                peso.Visible = true;
                altura.Text = pokemon.height.ToString();
                altura.Visible = true;
                alturaD.Visible = true;
                energia.Text = pokemon.energia.ToString();
                energiaD.Visible = true;
                energia.Visible = true;
                Alimentacao.Text = pokemon.alimentação.ToString();
                Alimentacao.Visible = true;
                alimentacaoD.Visible = true;
                humor.Text = pokemon.Humor.ToString();
                HumorD.Visible = true;
                humor.Visible = true;
                bemVindo.Visible = false;
                textoEscolha.Visible = false;
                button1.Visible = false;
                foreach (Move golpe in pokemon.moves)
                {
                    golpes.Items.Add(golpe.move.name);
                }
                golpes.Visible = true;
                button4.Visible = true;
                dormir.Visible = true;
                comer.Visible = true;

            }
            catch (Exception erro)
            {
                label1.Visible = true;
            }
}





        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            brincar();
            
        }
        public void brincar()
        {
            if(pokemon.energia < 20)
            {
                log.Text = $"{pokemon.name} não consegue brincar pois está com sono";
                log.Visible = true ;
                return;
            }
            else if(pokemon.alimentação < 20)
            {
                log.Text = $"{pokemon.name} não consegue brincar pois está com fome";
                log.Visible = true;
                return;

            }
            {
                if(pokemon.energia > 0)
                {
                    pokemon.energia -= 20;
                }
                if(pokemon.alimentação > 0)
                {
                    pokemon.alimentação -= 10;
                }
                if (pokemon.Humor < 100)

                {
                    if(pokemon.Humor > 100)
                    {
                        pokemon.Humor = 100;
                    }
                    pokemon.Humor += 50;
                }
                energia.Text = pokemon.energia.ToString();
                humor.Text = pokemon.Humor.ToString();
                Alimentacao.Text = pokemon.alimentação.ToString();
                log.Visible = true ;
                log.Text = $"{pokemon.name} brincou";
            }


        }
        public void alimentar()
        {
           
            
                if (pokemon.energia > 0)
                {
                    pokemon.energia -= 10;
                }
               
                
                    if (pokemon.alimentação < 100)
                    {
                        pokemon.alimentação += 40;
                    }
                    else if (pokemon.alimentação > 100)
                {
                    pokemon.alimentação = 100;

                }
              
                if (pokemon.Humor < 100)
                {
                    pokemon.Humor += 5;
                }
                energia.Text = pokemon.energia.ToString();
                humor.Text = pokemon.Humor.ToString();
                Alimentacao.Text = pokemon.alimentação.ToString();
                log.Visible = true;
                log.Text = $"{pokemon.name} se alimentou";
            


        }
        public void descansar()
        {
            
                pokemon.energia = 100;
            
            energia.Text = pokemon.energia.ToString();
            humor.Text = pokemon.Humor.ToString();
            Alimentacao.Text = pokemon.alimentação.ToString();
            log.Visible = true;
            log.Text = $"{pokemon.name} dormiu";

        }

        private void comer_Click(object sender, EventArgs e)
        {
            alimentar();
        }

        private void dormir_Click(object sender, EventArgs e)
        {
            descansar();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

}


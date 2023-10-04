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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int aleatorio = random.Next(4000);
            try
            {
                ChamaPokemon.chamaPokemon(textoEscolha.Text);
                Pokemon2 pokemon = ChamaPokemon.pokemon1;
                if (pokemon == null)
                {
                    label1.Visible = true;
                }
                else
                {
                    label1.Visible = false;
                    pictureBox1.WaitOnLoad = false;
                    if (aleatorio == 3876)
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
                    foreach(Move golpe in pokemon.moves)
                    {
                        golpes.Items.Add(golpe.move.name);
                    }
                    golpes.Visible = true;

                }
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
    }

}


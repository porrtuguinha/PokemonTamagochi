namespace pokemonAgoraVai
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textoEscolha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomeD = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.tipoD = new System.Windows.Forms.Label();
            this.tipos = new System.Windows.Forms.ListBox();
            this.pesoD = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.alturaD = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.energiaD = new System.Windows.Forms.Label();
            this.alimentacaoD = new System.Windows.Forms.Label();
            this.HumorD = new System.Windows.Forms.Label();
            this.energia = new System.Windows.Forms.Label();
            this.Alimentacao = new System.Windows.Forms.Label();
            this.humor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bemVindo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adotar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoEscolha
            // 
            this.textoEscolha.Location = new System.Drawing.Point(227, 22);
            this.textoEscolha.Margin = new System.Windows.Forms.Padding(2);
            this.textoEscolha.Name = "textoEscolha";
            this.textoEscolha.Size = new System.Drawing.Size(176, 20);
            this.textoEscolha.TabIndex = 1;
            this.textoEscolha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(213, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 104);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nomeD
            // 
            this.nomeD.AutoSize = true;
            this.nomeD.Location = new System.Drawing.Point(427, 79);
            this.nomeD.Name = "nomeD";
            this.nomeD.Size = new System.Drawing.Size(39, 13);
            this.nomeD.TabIndex = 3;
            this.nomeD.Text = "nome :";
            this.nomeD.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(507, 79);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(0, 13);
            this.nome.TabIndex = 4;
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // tipoD
            // 
            this.tipoD.AutoSize = true;
            this.tipoD.Location = new System.Drawing.Point(427, 105);
            this.tipoD.Name = "tipoD";
            this.tipoD.Size = new System.Drawing.Size(30, 13);
            this.tipoD.TabIndex = 5;
            this.tipoD.Text = "tipo :";
            this.tipoD.Visible = false;
            // 
            // tipos
            // 
            this.tipos.FormattingEnabled = true;
            this.tipos.Location = new System.Drawing.Point(472, 105);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(93, 30);
            this.tipos.TabIndex = 6;
            this.tipos.Visible = false;
            // 
            // pesoD
            // 
            this.pesoD.AutoSize = true;
            this.pesoD.Location = new System.Drawing.Point(424, 143);
            this.pesoD.Name = "pesoD";
            this.pesoD.Size = new System.Drawing.Size(36, 13);
            this.pesoD.TabIndex = 7;
            this.pesoD.Text = "peso :";
            this.pesoD.Visible = false;
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(487, 143);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(35, 13);
            this.peso.TabIndex = 8;
            this.peso.Text = "label1";
            this.peso.Visible = false;
            // 
            // alturaD
            // 
            this.alturaD.AutoSize = true;
            this.alturaD.Location = new System.Drawing.Point(421, 182);
            this.alturaD.Name = "alturaD";
            this.alturaD.Size = new System.Drawing.Size(39, 13);
            this.alturaD.TabIndex = 9;
            this.alturaD.Text = "altura :";
            this.alturaD.Visible = false;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(487, 182);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(35, 13);
            this.altura.TabIndex = 10;
            this.altura.Text = "label1";
            this.altura.Visible = false;
            // 
            // energiaD
            // 
            this.energiaD.AutoSize = true;
            this.energiaD.Location = new System.Drawing.Point(22, 89);
            this.energiaD.Name = "energiaD";
            this.energiaD.Size = new System.Drawing.Size(49, 13);
            this.energiaD.TabIndex = 11;
            this.energiaD.Text = "Energia :";
            this.energiaD.Visible = false;
            // 
            // alimentacaoD
            // 
            this.alimentacaoD.AutoSize = true;
            this.alimentacaoD.Location = new System.Drawing.Point(12, 122);
            this.alimentacaoD.Name = "alimentacaoD";
            this.alimentacaoD.Size = new System.Drawing.Size(71, 13);
            this.alimentacaoD.TabIndex = 12;
            this.alimentacaoD.Text = "Alimentação :";
            this.alimentacaoD.Visible = false;
            // 
            // HumorD
            // 
            this.HumorD.AutoSize = true;
            this.HumorD.Location = new System.Drawing.Point(22, 161);
            this.HumorD.Name = "HumorD";
            this.HumorD.Size = new System.Drawing.Size(44, 13);
            this.HumorD.TabIndex = 13;
            this.HumorD.Text = "Humor :";
            this.HumorD.Visible = false;
            // 
            // energia
            // 
            this.energia.AutoSize = true;
            this.energia.Location = new System.Drawing.Point(95, 89);
            this.energia.Name = "energia";
            this.energia.Size = new System.Drawing.Size(35, 13);
            this.energia.TabIndex = 14;
            this.energia.Text = "label4";
            this.energia.Visible = false;
            // 
            // Alimentacao
            // 
            this.Alimentacao.AutoSize = true;
            this.Alimentacao.Location = new System.Drawing.Point(95, 122);
            this.Alimentacao.Name = "Alimentacao";
            this.Alimentacao.Size = new System.Drawing.Size(35, 13);
            this.Alimentacao.TabIndex = 15;
            this.Alimentacao.Text = "label5";
            this.Alimentacao.Visible = false;
            this.Alimentacao.Click += new System.EventHandler(this.label5_Click);
            // 
            // humor
            // 
            this.humor.AutoSize = true;
            this.humor.Location = new System.Drawing.Point(95, 161);
            this.humor.Name = "humor";
            this.humor.Size = new System.Drawing.Size(35, 13);
            this.humor.TabIndex = 16;
            this.humor.Text = "label6";
            this.humor.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bemVindo
            // 
            this.bemVindo.AutoSize = true;
            this.bemVindo.Location = new System.Drawing.Point(9, 25);
            this.bemVindo.Name = "bemVindo";
            this.bemVindo.Size = new System.Drawing.Size(212, 13);
            this.bemVindo.TabIndex = 18;
            this.bemVindo.Text = "insira o nome do pokemon que quer adotar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "POKEMON iNVÁLIDO";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bemVindo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.humor);
            this.Controls.Add(this.Alimentacao);
            this.Controls.Add(this.energia);
            this.Controls.Add(this.HumorD);
            this.Controls.Add(this.alimentacaoD);
            this.Controls.Add(this.energiaD);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.alturaD);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.pesoD);
            this.Controls.Add(this.tipos);
            this.Controls.Add(this.tipoD);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.nomeD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textoEscolha);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoEscolha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomeD;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label tipoD;
        private System.Windows.Forms.ListBox tipos;
        private System.Windows.Forms.Label pesoD;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label alturaD;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label energiaD;
        private System.Windows.Forms.Label alimentacaoD;
        private System.Windows.Forms.Label HumorD;
        private System.Windows.Forms.Label energia;
        private System.Windows.Forms.Label Alimentacao;
        private System.Windows.Forms.Label humor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bemVindo;
        public System.Windows.Forms.Label label1;
    }
}


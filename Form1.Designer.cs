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
            this.golpes = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comer = new System.Windows.Forms.Button();
            this.dormir = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adotar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoEscolha
            // 
            this.textoEscolha.Location = new System.Drawing.Point(303, 27);
            this.textoEscolha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoEscolha.Name = "textoEscolha";
            this.textoEscolha.Size = new System.Drawing.Size(233, 22);
            this.textoEscolha.TabIndex = 1;
            this.textoEscolha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(284, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nomeD
            // 
            this.nomeD.AutoSize = true;
            this.nomeD.Location = new System.Drawing.Point(569, 97);
            this.nomeD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeD.Name = "nomeD";
            this.nomeD.Size = new System.Drawing.Size(47, 16);
            this.nomeD.TabIndex = 3;
            this.nomeD.Text = "nome :";
            this.nomeD.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(676, 97);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(0, 16);
            this.nome.TabIndex = 4;
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // tipoD
            // 
            this.tipoD.AutoSize = true;
            this.tipoD.Location = new System.Drawing.Point(569, 129);
            this.tipoD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoD.Name = "tipoD";
            this.tipoD.Size = new System.Drawing.Size(35, 16);
            this.tipoD.TabIndex = 5;
            this.tipoD.Text = "tipo :";
            this.tipoD.Visible = false;
            // 
            // tipos
            // 
            this.tipos.FormattingEnabled = true;
            this.tipos.ItemHeight = 16;
            this.tipos.Location = new System.Drawing.Point(629, 129);
            this.tipos.Margin = new System.Windows.Forms.Padding(4);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(123, 36);
            this.tipos.TabIndex = 6;
            this.tipos.Visible = false;
            // 
            // pesoD
            // 
            this.pesoD.AutoSize = true;
            this.pesoD.Location = new System.Drawing.Point(584, 273);
            this.pesoD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pesoD.Name = "pesoD";
            this.pesoD.Size = new System.Drawing.Size(44, 16);
            this.pesoD.TabIndex = 7;
            this.pesoD.Text = "peso :";
            this.pesoD.Visible = false;
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(676, 273);
            this.peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(44, 16);
            this.peso.TabIndex = 8;
            this.peso.Text = "label1";
            this.peso.Visible = false;
            // 
            // alturaD
            // 
            this.alturaD.AutoSize = true;
            this.alturaD.Location = new System.Drawing.Point(582, 322);
            this.alturaD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alturaD.Name = "alturaD";
            this.alturaD.Size = new System.Drawing.Size(46, 16);
            this.alturaD.TabIndex = 9;
            this.alturaD.Text = "altura :";
            this.alturaD.Visible = false;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(676, 322);
            this.altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(44, 16);
            this.altura.TabIndex = 10;
            this.altura.Text = "label1";
            this.altura.Visible = false;
            // 
            // energiaD
            // 
            this.energiaD.AutoSize = true;
            this.energiaD.Location = new System.Drawing.Point(29, 110);
            this.energiaD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.energiaD.Name = "energiaD";
            this.energiaD.Size = new System.Drawing.Size(60, 16);
            this.energiaD.TabIndex = 11;
            this.energiaD.Text = "Energia :";
            this.energiaD.Visible = false;
            // 
            // alimentacaoD
            // 
            this.alimentacaoD.AutoSize = true;
            this.alimentacaoD.Location = new System.Drawing.Point(16, 150);
            this.alimentacaoD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alimentacaoD.Name = "alimentacaoD";
            this.alimentacaoD.Size = new System.Drawing.Size(88, 16);
            this.alimentacaoD.TabIndex = 12;
            this.alimentacaoD.Text = "Alimentação :";
            this.alimentacaoD.Visible = false;
            // 
            // HumorD
            // 
            this.HumorD.AutoSize = true;
            this.HumorD.Location = new System.Drawing.Point(29, 198);
            this.HumorD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumorD.Name = "HumorD";
            this.HumorD.Size = new System.Drawing.Size(53, 16);
            this.HumorD.TabIndex = 13;
            this.HumorD.Text = "Humor :";
            this.HumorD.Visible = false;
            // 
            // energia
            // 
            this.energia.AutoSize = true;
            this.energia.Location = new System.Drawing.Point(127, 110);
            this.energia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.energia.Name = "energia";
            this.energia.Size = new System.Drawing.Size(44, 16);
            this.energia.TabIndex = 14;
            this.energia.Text = "label4";
            this.energia.Visible = false;
            // 
            // Alimentacao
            // 
            this.Alimentacao.AutoSize = true;
            this.Alimentacao.Location = new System.Drawing.Point(127, 150);
            this.Alimentacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alimentacao.Name = "Alimentacao";
            this.Alimentacao.Size = new System.Drawing.Size(44, 16);
            this.Alimentacao.TabIndex = 15;
            this.Alimentacao.Text = "label5";
            this.Alimentacao.Visible = false;
            this.Alimentacao.Click += new System.EventHandler(this.label5_Click);
            // 
            // humor
            // 
            this.humor.AutoSize = true;
            this.humor.Location = new System.Drawing.Point(127, 198);
            this.humor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humor.Name = "humor";
            this.humor.Size = new System.Drawing.Size(44, 16);
            this.humor.TabIndex = 16;
            this.humor.Text = "label6";
            this.humor.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 396);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bemVindo
            // 
            this.bemVindo.AutoSize = true;
            this.bemVindo.Location = new System.Drawing.Point(12, 31);
            this.bemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bemVindo.Name = "bemVindo";
            this.bemVindo.Size = new System.Drawing.Size(267, 16);
            this.bemVindo.TabIndex = 18;
            this.bemVindo.Text = "insira o nome do pokemon que quer adotar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "POKEMON iNVÁLIDO";
            this.label1.Visible = false;
            // 
            // golpes
            // 
            this.golpes.FormattingEnabled = true;
            this.golpes.ItemHeight = 16;
            this.golpes.Location = new System.Drawing.Point(628, 189);
            this.golpes.Margin = new System.Windows.Forms.Padding(4);
            this.golpes.Name = "golpes";
            this.golpes.Size = new System.Drawing.Size(123, 36);
            this.golpes.TabIndex = 21;
            this.golpes.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 37);
            this.button4.TabIndex = 22;
            this.button4.Text = "Brincar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comer
            // 
            this.comer.Location = new System.Drawing.Point(303, 301);
            this.comer.Name = "comer";
            this.comer.Size = new System.Drawing.Size(123, 37);
            this.comer.TabIndex = 23;
            this.comer.Text = "Comer";
            this.comer.UseVisualStyleBackColor = true;
            this.comer.Visible = false;
            this.comer.Click += new System.EventHandler(this.comer_Click);
            // 
            // dormir
            // 
            this.dormir.Location = new System.Drawing.Point(432, 301);
            this.dormir.Name = "dormir";
            this.dormir.Size = new System.Drawing.Size(123, 37);
            this.dormir.TabIndex = 24;
            this.dormir.Text = "Dormir";
            this.dormir.UseVisualStyleBackColor = true;
            this.dormir.Visible = false;
            this.dormir.Click += new System.EventHandler(this.dormir_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(127, 253);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(44, 16);
            this.log.TabIndex = 25;
            this.log.Text = "label2";
            this.log.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.dormir);
            this.Controls.Add(this.comer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.golpes);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListBox golpes;
        private System.Windows.Forms.Button comer;
        private System.Windows.Forms.Button dormir;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button button4;
    }
}


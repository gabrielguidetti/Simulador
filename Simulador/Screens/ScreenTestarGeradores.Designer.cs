namespace Simulador
{
    partial class ScreenTestarGeradores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBGerador = new System.Windows.Forms.ComboBox();
            this.LblSelecioneGerador = new System.Windows.Forms.Label();
            this.BtnResetar = new System.Windows.Forms.Button();
            this.GBParametros = new System.Windows.Forms.GroupBox();
            this.BtnQuestionModulo = new System.Windows.Forms.Button();
            this.NumModulo = new System.Windows.Forms.NumericUpDown();
            this.lblModulo = new System.Windows.Forms.Label();
            this.BtnQuestionNumero = new System.Windows.Forms.Button();
            this.BtnQuestionIncremento = new System.Windows.Forms.Button();
            this.BtnQuestionMultiplicador = new System.Windows.Forms.Button();
            this.BtnQuestionSemente = new System.Windows.Forms.Button();
            this.BtnQuestionMaximo = new System.Windows.Forms.Button();
            this.BtnQuestionMinimo = new System.Windows.Forms.Button();
            this.NumQtd = new System.Windows.Forms.NumericUpDown();
            this.LblQtd = new System.Windows.Forms.Label();
            this.NumIncremento = new System.Windows.Forms.NumericUpDown();
            this.LblIncremento = new System.Windows.Forms.Label();
            this.NumSemente = new System.Windows.Forms.NumericUpDown();
            this.LblSementeInicial = new System.Windows.Forms.Label();
            this.NumMultiplicador = new System.Windows.Forms.NumericUpDown();
            this.LblMultiplicador = new System.Windows.Forms.Label();
            this.NumMaximo = new System.Windows.Forms.NumericUpDown();
            this.NumMinimo = new System.Windows.Forms.NumericUpDown();
            this.LblMaximo = new System.Windows.Forms.Label();
            this.LblMinimo = new System.Windows.Forms.Label();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.TxtBoxResultado = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.GBParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIncremento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSemente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMultiplicador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // CBGerador
            // 
            this.CBGerador.BackColor = System.Drawing.Color.White;
            this.CBGerador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGerador.FormattingEnabled = true;
            this.CBGerador.Items.AddRange(new object[] {
            "Linear Congruential Generator",
            "Mersenne Twister",
            "Random Number Generator (TRNG)"});
            this.CBGerador.Location = new System.Drawing.Point(365, 12);
            this.CBGerador.Name = "CBGerador";
            this.CBGerador.Size = new System.Drawing.Size(216, 21);
            this.CBGerador.TabIndex = 0;
            this.CBGerador.SelectedIndexChanged += new System.EventHandler(this.CBGerador_SelectedIndexChanged);
            // 
            // LblSelecioneGerador
            // 
            this.LblSelecioneGerador.AutoSize = true;
            this.LblSelecioneGerador.BackColor = System.Drawing.Color.White;
            this.LblSelecioneGerador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelecioneGerador.Location = new System.Drawing.Point(168, 11);
            this.LblSelecioneGerador.Name = "LblSelecioneGerador";
            this.LblSelecioneGerador.Size = new System.Drawing.Size(191, 22);
            this.LblSelecioneGerador.TabIndex = 1;
            this.LblSelecioneGerador.Text = "Selecione o Gerador:";
            // 
            // BtnResetar
            // 
            this.BtnResetar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetar.Location = new System.Drawing.Point(587, 9);
            this.BtnResetar.Name = "BtnResetar";
            this.BtnResetar.Size = new System.Drawing.Size(83, 29);
            this.BtnResetar.TabIndex = 2;
            this.BtnResetar.Text = "Resetar";
            this.BtnResetar.UseVisualStyleBackColor = true;
            this.BtnResetar.Click += new System.EventHandler(this.BtnResetar_Click);
            // 
            // GBParametros
            // 
            this.GBParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GBParametros.Controls.Add(this.BtnQuestionModulo);
            this.GBParametros.Controls.Add(this.NumModulo);
            this.GBParametros.Controls.Add(this.lblModulo);
            this.GBParametros.Controls.Add(this.BtnQuestionNumero);
            this.GBParametros.Controls.Add(this.BtnQuestionIncremento);
            this.GBParametros.Controls.Add(this.BtnQuestionMultiplicador);
            this.GBParametros.Controls.Add(this.BtnQuestionSemente);
            this.GBParametros.Controls.Add(this.BtnQuestionMaximo);
            this.GBParametros.Controls.Add(this.BtnQuestionMinimo);
            this.GBParametros.Controls.Add(this.NumQtd);
            this.GBParametros.Controls.Add(this.LblQtd);
            this.GBParametros.Controls.Add(this.NumIncremento);
            this.GBParametros.Controls.Add(this.LblIncremento);
            this.GBParametros.Controls.Add(this.NumSemente);
            this.GBParametros.Controls.Add(this.LblSementeInicial);
            this.GBParametros.Controls.Add(this.NumMultiplicador);
            this.GBParametros.Controls.Add(this.LblMultiplicador);
            this.GBParametros.Controls.Add(this.NumMaximo);
            this.GBParametros.Controls.Add(this.NumMinimo);
            this.GBParametros.Controls.Add(this.LblMaximo);
            this.GBParametros.Controls.Add(this.LblMinimo);
            this.GBParametros.Location = new System.Drawing.Point(12, 44);
            this.GBParametros.Name = "GBParametros";
            this.GBParametros.Size = new System.Drawing.Size(856, 94);
            this.GBParametros.TabIndex = 3;
            this.GBParametros.TabStop = false;
            this.GBParametros.Text = "Parâmetros";
            // 
            // BtnQuestionModulo
            // 
            this.BtnQuestionModulo.BackColor = System.Drawing.Color.White;
            this.BtnQuestionModulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestionModulo.Location = new System.Drawing.Point(677, 23);
            this.BtnQuestionModulo.Name = "BtnQuestionModulo";
            this.BtnQuestionModulo.Size = new System.Drawing.Size(25, 25);
            this.BtnQuestionModulo.TabIndex = 23;
            this.BtnQuestionModulo.Text = "?";
            this.BtnQuestionModulo.UseVisualStyleBackColor = false;
            this.BtnQuestionModulo.Click += new System.EventHandler(this.BtnQuestionModulo_Click);
            // 
            // NumModulo
            // 
            this.NumModulo.Location = new System.Drawing.Point(620, 51);
            this.NumModulo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumModulo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumModulo.Name = "NumModulo";
            this.NumModulo.Size = new System.Drawing.Size(90, 20);
            this.NumModulo.TabIndex = 22;
            this.NumModulo.Value = new decimal(new int[] {
            0,
            1,
            0,
            0});
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblModulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.ForeColor = System.Drawing.Color.Black;
            this.lblModulo.Location = new System.Drawing.Point(617, 30);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(59, 18);
            this.lblModulo.TabIndex = 21;
            this.lblModulo.Text = "Módulo";
            // 
            // BtnQuestionNumero
            // 
            this.BtnQuestionNumero.BackColor = System.Drawing.Color.White;
            this.BtnQuestionNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestionNumero.Location = new System.Drawing.Point(820, 23);
            this.BtnQuestionNumero.Name = "BtnQuestionNumero";
            this.BtnQuestionNumero.Size = new System.Drawing.Size(25, 25);
            this.BtnQuestionNumero.TabIndex = 20;
            this.BtnQuestionNumero.Text = "?";
            this.BtnQuestionNumero.UseVisualStyleBackColor = false;
            this.BtnQuestionNumero.Click += new System.EventHandler(this.BtnQuestionNumero_Click);
            // 
            // BtnQuestionIncremento
            // 
            this.BtnQuestionIncremento.BackColor = System.Drawing.Color.White;
            this.BtnQuestionIncremento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestionIncremento.Location = new System.Drawing.Point(591, 23);
            this.BtnQuestionIncremento.Name = "BtnQuestionIncremento";
            this.BtnQuestionIncremento.Size = new System.Drawing.Size(25, 25);
            this.BtnQuestionIncremento.TabIndex = 19;
            this.BtnQuestionIncremento.Text = "?";
            this.BtnQuestionIncremento.UseVisualStyleBackColor = false;
            this.BtnQuestionIncremento.Click += new System.EventHandler(this.BtnQuestionIncremento_Click);
            // 
            // BtnQuestionMultiplicador
            // 
            this.BtnQuestionMultiplicador.BackColor = System.Drawing.Color.White;
            this.BtnQuestionMultiplicador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestionMultiplicador.Location = new System.Drawing.Point(467, 23);
            this.BtnQuestionMultiplicador.Name = "BtnQuestionMultiplicador";
            this.BtnQuestionMultiplicador.Size = new System.Drawing.Size(25, 25);
            this.BtnQuestionMultiplicador.TabIndex = 18;
            this.BtnQuestionMultiplicador.Text = "?";
            this.BtnQuestionMultiplicador.UseVisualStyleBackColor = false;
            this.BtnQuestionMultiplicador.Click += new System.EventHandler(this.BtnQuestionMultiplicador_Click);
            // 
            // BtnQuestionSemente
            // 
            this.BtnQuestionSemente.BackColor = System.Drawing.Color.White;
            this.BtnQuestionSemente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestionSemente.Location = new System.Drawing.Point(335, 23);
            this.BtnQuestionSemente.Name = "BtnQuestionSemente";
            this.BtnQuestionSemente.Size = new System.Drawing.Size(25, 25);
            this.BtnQuestionSemente.TabIndex = 17;
            this.BtnQuestionSemente.Text = "?";
            this.BtnQuestionSemente.UseVisualStyleBackColor = false;
            this.BtnQuestionSemente.Click += new System.EventHandler(this.BtnQuestionSemente_Click);
            // 
            // BtnQuestionMaximo
            // 
            this.BtnQuestionMaximo.BackColor = System.Drawing.Color.White;
            this.BtnQuestionMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestionMaximo.Location = new System.Drawing.Point(180, 23);
            this.BtnQuestionMaximo.Name = "BtnQuestionMaximo";
            this.BtnQuestionMaximo.Size = new System.Drawing.Size(25, 25);
            this.BtnQuestionMaximo.TabIndex = 16;
            this.BtnQuestionMaximo.Text = "?";
            this.BtnQuestionMaximo.UseVisualStyleBackColor = false;
            this.BtnQuestionMaximo.Click += new System.EventHandler(this.BtnQuestionMaximo_Click);
            // 
            // BtnQuestionMinimo
            // 
            this.BtnQuestionMinimo.BackColor = System.Drawing.Color.White;
            this.BtnQuestionMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestionMinimo.Location = new System.Drawing.Point(74, 23);
            this.BtnQuestionMinimo.Name = "BtnQuestionMinimo";
            this.BtnQuestionMinimo.Size = new System.Drawing.Size(25, 25);
            this.BtnQuestionMinimo.TabIndex = 15;
            this.BtnQuestionMinimo.Text = "?";
            this.BtnQuestionMinimo.UseVisualStyleBackColor = false;
            this.BtnQuestionMinimo.Click += new System.EventHandler(this.BtnQuestionMinimo_Click);
            // 
            // NumQtd
            // 
            this.NumQtd.Location = new System.Drawing.Point(720, 51);
            this.NumQtd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumQtd.Name = "NumQtd";
            this.NumQtd.Size = new System.Drawing.Size(90, 20);
            this.NumQtd.TabIndex = 13;
            this.NumQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblQtd
            // 
            this.LblQtd.AutoSize = true;
            this.LblQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblQtd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtd.ForeColor = System.Drawing.Color.Black;
            this.LblQtd.Location = new System.Drawing.Point(717, 30);
            this.LblQtd.Name = "LblQtd";
            this.LblQtd.Size = new System.Drawing.Size(104, 18);
            this.LblQtd.TabIndex = 12;
            this.LblQtd.Text = "Qtd. Números";
            // 
            // NumIncremento
            // 
            this.NumIncremento.Location = new System.Drawing.Point(508, 51);
            this.NumIncremento.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NumIncremento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumIncremento.Name = "NumIncremento";
            this.NumIncremento.Size = new System.Drawing.Size(90, 20);
            this.NumIncremento.TabIndex = 11;
            this.NumIncremento.Value = new decimal(new int[] {
            1013904223,
            0,
            0,
            0});
            // 
            // LblIncremento
            // 
            this.LblIncremento.AutoSize = true;
            this.LblIncremento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblIncremento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIncremento.ForeColor = System.Drawing.Color.Black;
            this.LblIncremento.Location = new System.Drawing.Point(505, 30);
            this.LblIncremento.Name = "LblIncremento";
            this.LblIncremento.Size = new System.Drawing.Size(84, 18);
            this.LblIncremento.TabIndex = 10;
            this.LblIncremento.Text = "Incremento";
            // 
            // NumSemente
            // 
            this.NumSemente.Location = new System.Drawing.Point(222, 51);
            this.NumSemente.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NumSemente.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSemente.Name = "NumSemente";
            this.NumSemente.Size = new System.Drawing.Size(90, 20);
            this.NumSemente.TabIndex = 9;
            this.NumSemente.Value = new decimal(new int[] {
            -1831433054,
            0,
            0,
            0});
            // 
            // LblSementeInicial
            // 
            this.LblSementeInicial.AutoSize = true;
            this.LblSementeInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblSementeInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSementeInicial.ForeColor = System.Drawing.Color.Black;
            this.LblSementeInicial.Location = new System.Drawing.Point(219, 30);
            this.LblSementeInicial.Name = "LblSementeInicial";
            this.LblSementeInicial.Size = new System.Drawing.Size(114, 18);
            this.LblSementeInicial.TabIndex = 8;
            this.LblSementeInicial.Text = "Semente Inicial";
            // 
            // NumMultiplicador
            // 
            this.NumMultiplicador.Location = new System.Drawing.Point(373, 51);
            this.NumMultiplicador.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NumMultiplicador.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMultiplicador.Name = "NumMultiplicador";
            this.NumMultiplicador.Size = new System.Drawing.Size(90, 20);
            this.NumMultiplicador.TabIndex = 7;
            this.NumMultiplicador.Value = new decimal(new int[] {
            1664525,
            0,
            0,
            0});
            // 
            // LblMultiplicador
            // 
            this.LblMultiplicador.AutoSize = true;
            this.LblMultiplicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblMultiplicador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMultiplicador.ForeColor = System.Drawing.Color.Black;
            this.LblMultiplicador.Location = new System.Drawing.Point(370, 30);
            this.LblMultiplicador.Name = "LblMultiplicador";
            this.LblMultiplicador.Size = new System.Drawing.Size(96, 18);
            this.LblMultiplicador.TabIndex = 6;
            this.LblMultiplicador.Text = "Multiplicador";
            // 
            // NumMaximo
            // 
            this.NumMaximo.Location = new System.Drawing.Point(115, 51);
            this.NumMaximo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumMaximo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMaximo.Name = "NumMaximo";
            this.NumMaximo.Size = new System.Drawing.Size(90, 20);
            this.NumMaximo.TabIndex = 5;
            this.NumMaximo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumMinimo
            // 
            this.NumMinimo.Location = new System.Drawing.Point(9, 51);
            this.NumMinimo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumMinimo.Name = "NumMinimo";
            this.NumMinimo.Size = new System.Drawing.Size(90, 20);
            this.NumMinimo.TabIndex = 4;
            // 
            // LblMaximo
            // 
            this.LblMaximo.AutoSize = true;
            this.LblMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaximo.ForeColor = System.Drawing.Color.Black;
            this.LblMaximo.Location = new System.Drawing.Point(112, 30);
            this.LblMaximo.Name = "LblMaximo";
            this.LblMaximo.Size = new System.Drawing.Size(63, 18);
            this.LblMaximo.TabIndex = 2;
            this.LblMaximo.Text = "Máximo";
            // 
            // LblMinimo
            // 
            this.LblMinimo.AutoSize = true;
            this.LblMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimo.ForeColor = System.Drawing.Color.Black;
            this.LblMinimo.Location = new System.Drawing.Point(6, 30);
            this.LblMinimo.Name = "LblMinimo";
            this.LblMinimo.Size = new System.Drawing.Size(58, 18);
            this.LblMinimo.TabIndex = 0;
            this.LblMinimo.Text = "Mínimo";
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.Color.White;
            this.BtnGerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.Location = new System.Drawing.Point(775, 144);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(93, 30);
            this.BtnGerar.TabIndex = 14;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // TxtBoxResultado
            // 
            this.TxtBoxResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtBoxResultado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxResultado.Location = new System.Drawing.Point(12, 177);
            this.TxtBoxResultado.Multiline = true;
            this.TxtBoxResultado.Name = "TxtBoxResultado";
            this.TxtBoxResultado.ReadOnly = true;
            this.TxtBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxResultado.Size = new System.Drawing.Size(856, 262);
            this.TxtBoxResultado.TabIndex = 4;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.BackColor = System.Drawing.Color.White;
            this.LblResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(12, 150);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(104, 24);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "Resultado";
            // 
            // ScreenTestarGeradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtBoxResultado);
            this.Controls.Add(this.GBParametros);
            this.Controls.Add(this.BtnResetar);
            this.Controls.Add(this.LblSelecioneGerador);
            this.Controls.Add(this.CBGerador);
            this.Controls.Add(this.BtnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScreenTestarGeradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testar Geradores";
            this.GBParametros.ResumeLayout(false);
            this.GBParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIncremento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSemente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMultiplicador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBGerador;
        private System.Windows.Forms.Label LblSelecioneGerador;
        private System.Windows.Forms.Button BtnResetar;
        private System.Windows.Forms.GroupBox GBParametros;
        private System.Windows.Forms.TextBox TxtBoxResultado;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblMinimo;
        private System.Windows.Forms.Label LblMaximo;
        private System.Windows.Forms.NumericUpDown NumMaximo;
        private System.Windows.Forms.NumericUpDown NumMinimo;
        private System.Windows.Forms.NumericUpDown NumSemente;
        private System.Windows.Forms.Label LblSementeInicial;
        private System.Windows.Forms.NumericUpDown NumMultiplicador;
        private System.Windows.Forms.Label LblMultiplicador;
        private System.Windows.Forms.NumericUpDown NumIncremento;
        private System.Windows.Forms.Label LblIncremento;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.NumericUpDown NumQtd;
        private System.Windows.Forms.Label LblQtd;
        private System.Windows.Forms.Button BtnQuestionMinimo;
        private System.Windows.Forms.Button BtnQuestionSemente;
        private System.Windows.Forms.Button BtnQuestionMaximo;
        private System.Windows.Forms.Button BtnQuestionMultiplicador;
        private System.Windows.Forms.Button BtnQuestionIncremento;
        private System.Windows.Forms.Button BtnQuestionNumero;
        private System.Windows.Forms.Button BtnQuestionModulo;
        private System.Windows.Forms.NumericUpDown NumModulo;
        private System.Windows.Forms.Label lblModulo;
    }
}
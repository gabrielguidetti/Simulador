namespace Simulador
{
    partial class ScreenMenu
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
            this.BtnTestarGeradores = new System.Windows.Forms.Button();
            this.BtnSimulador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTestarGeradores
            // 
            this.BtnTestarGeradores.BackColor = System.Drawing.Color.White;
            this.BtnTestarGeradores.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTestarGeradores.Location = new System.Drawing.Point(86, 87);
            this.BtnTestarGeradores.Name = "BtnTestarGeradores";
            this.BtnTestarGeradores.Size = new System.Drawing.Size(215, 50);
            this.BtnTestarGeradores.TabIndex = 0;
            this.BtnTestarGeradores.Text = "Testar Geradores";
            this.BtnTestarGeradores.UseVisualStyleBackColor = false;
            this.BtnTestarGeradores.Click += new System.EventHandler(this.BtnTestarGeradores_Click);
            // 
            // BtnSimulador
            // 
            this.BtnSimulador.BackColor = System.Drawing.Color.White;
            this.BtnSimulador.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimulador.Location = new System.Drawing.Point(86, 194);
            this.BtnSimulador.Name = "BtnSimulador";
            this.BtnSimulador.Size = new System.Drawing.Size(215, 50);
            this.BtnSimulador.TabIndex = 1;
            this.BtnSimulador.Text = "Simulador";
            this.BtnSimulador.UseVisualStyleBackColor = false;
            this.BtnSimulador.Click += new System.EventHandler(this.BtnSimulador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criado por: Gabriel Guidetti Gonzalez";
            // 
            // ScreenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSimulador);
            this.Controls.Add(this.BtnTestarGeradores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScreenMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTestarGeradores;
        private System.Windows.Forms.Button BtnSimulador;
        private System.Windows.Forms.Label label1;
    }
}


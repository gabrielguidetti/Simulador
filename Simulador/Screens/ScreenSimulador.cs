using Simulador.Models;
using Simulador.Models.Enums;
using Simulador.Models.Interfaces;
using Simulador.Services;
using Simulador.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simulador
{
    public partial class ScreenSimulador : Form
    {
        public ScreenSimulador()
        {
            InitializeComponent();
            ResetarCampos();
        }

        private void BtnQuestionMinimo_Click(object sender, EventArgs e)
        {
            MessageHelper.InfoMessageBox("Informe o número mínimo que será sorteado", "Mínimo");
        }

        private void BtnQuestionMaximo_Click(object sender, EventArgs e)
        {
            MessageHelper.InfoMessageBox("Informe o número máximo que será sorteado", "Máximo");
        }

        private void BtnQuestionSemente_Click(object sender, EventArgs e)
        {
            MessageHelper.InfoMessageBox("Informe a semente inicial do gerador (Dica: evite valores múltiplos de 10)", "Semento inicial");
        }

        private void BtnQuestionMultiplicador_Click(object sender, EventArgs e)
        {
            MessageHelper.InfoMessageBox("Informe o multipliador do gerador (Ex: 1664525)", "Multiplicador");
        }

        private void BtnQuestionIncremento_Click(object sender, EventArgs e)
        {
            MessageHelper.InfoMessageBox("Informe o incremento (Ex: 1013904223)", "Incremento");
        }

        private void BtnQuestionNumero_Click(object sender, EventArgs e)
        {
            MessageHelper.InfoMessageBox("Informe a quantidade de números que serão gerados", "Quantidade de números");
        }

        private void BtnQuestionModulo_Click(object sender, EventArgs e)
        {
            MessageHelper.InfoMessageBox("Informe o módulo que será utilizado", "Módulo");
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            var config = GerarConfig();

            if (!ValidarGeracao(config))
                return;

            SimuladorService.Simular(config);
        }

        private bool ValidarGeracao(RandomConfig config)
        {
            if(config.Quantidade < 1)
            {
                MessageHelper.ErrorMessageBox("Escolha uma quantidade maior que 0", "ERRO");
                return false;
            }

            if (string.IsNullOrEmpty(config.FolderPath))
            {
                MessageHelper.ErrorMessageBox("Escolha uma pasta para salvar o relatório!", "ERRO");
                return false;
            }

            if (config.Modulo < 1)
            {
                MessageHelper.ErrorMessageBox("Escolha um valor de módulo maior que 0", "ERRO");
                return false;
            }

            if (config.Gerador == EGeradores.NONE)
            {
                MessageHelper.ErrorMessageBox("Escolha um gerador", "ERRO");
                return false;
            }

            if(config.Maximo <= config.Minimo)
            {
                MessageHelper.ErrorMessageBox("Número máximo deve ser maior que o mínimo", "ERRO");
                return false;
            }

            return true;
        }

        private void MostrarCampos(bool mostrar)
        {
            LblSementeInicial.Visible = mostrar;
            NumSemente.Visible = mostrar;
            BtnQuestionSemente.Visible = mostrar;

            LblMultiplicador.Visible = mostrar;
            NumMultiplicador.Visible = mostrar;
            BtnQuestionMultiplicador.Visible = mostrar;

            LblIncremento.Visible = mostrar;
            NumIncremento.Visible = mostrar;
            BtnQuestionIncremento.Visible = mostrar;

            lblModulo.Visible = mostrar;
            NumModulo.Visible = mostrar;
            BtnQuestionModulo.Visible = mostrar;
        }

        private void ResetarCampos()
        {
            NumMinimo.Value = 0;
            NumMaximo.Value = 10;
            NumSemente.Value = 2463534242;
            NumMultiplicador.Value = 1664525;
            NumIncremento.Value = 1013904223;
            NumQtd.Value = 1000;
            NumModulo.Value = 4294967296;
            CBGerador.SelectedIndex = -1;
            MostrarCampos(false);
        }

        private void CBGerador_SelectedIndexChanged(object sender, EventArgs e)
        {
            var geradorEscolhido = CBGerador.SelectedIndex;

            if(geradorEscolhido == 0)
            {
                MostrarCampos(true);
                NumSemente.Value = 2463534242;
            } 
            else if (geradorEscolhido == 1)
            {
                MostrarCampos(false);
                LblSementeInicial.Visible = true;
                NumSemente.Visible = true;
                BtnQuestionSemente.Visible = true;
                NumSemente.Value = 4237;
            } 
            else if (geradorEscolhido == 2)
            {
                MostrarCampos(false);
            }
        }

        private void BtnResetar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
            MessageHelper.InfoMessageBox("Campos resetados!", "Resetar");
        }

        private RandomConfig GerarConfig()
        {
            return new RandomConfig() 
            { 
                Gerador = (EGeradores)CBGerador.SelectedIndex,
                Minimo = (long)NumMinimo.Value,
                Maximo = (long)NumMaximo.Value,
                SementeInicial = (long)NumSemente.Value,
                Multiplicador = (long) NumMultiplicador.Value,
                Incremento = (long)NumIncremento.Value,
                Quantidade = (long)NumQtd.Value,
                Modulo = (long)NumModulo.Value,
                FolderPath = TxtBoxFolder.Text
            };
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            FBD.ShowDialog();
            TxtBoxFolder.Text = FBD.SelectedPath;
        }
    }
}

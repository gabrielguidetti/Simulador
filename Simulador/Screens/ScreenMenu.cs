using System;
using System.Windows.Forms;

namespace Simulador
{
    public partial class ScreenMenu : Form
    {
        public ScreenMenu()
        {
            InitializeComponent();
        }

        private void BtnTestarGeradores_Click(object sender, EventArgs e)
        {
            ScreenTestarGeradores screenTestarGeradores = new ScreenTestarGeradores();
            screenTestarGeradores.ShowDialog();
        }

        private void BtnSimulador_Click(object sender, EventArgs e)
        {
            ScreenSimulador screenSimulador = new ScreenSimulador();
            screenSimulador.ShowDialog();
        }
    }
}

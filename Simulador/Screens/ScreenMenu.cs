using Simulador.Models;
using Simulador.Screens;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Simulador
{
    public partial class ScreenMenu : Form
    {
        public ScreenMenu()
        {
            InitializeComponent();
            byte[] randomBytes = new byte[16]; // 16 bytes for a GUID, for example
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            //LCG teste = new LCG(1, 1664525, 1013904223, 100);

            for (int i = 0; i < 100; i++)
            {
                //Console.WriteLine(MT.Instance.Generate(1, 100).ToString());
            }
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

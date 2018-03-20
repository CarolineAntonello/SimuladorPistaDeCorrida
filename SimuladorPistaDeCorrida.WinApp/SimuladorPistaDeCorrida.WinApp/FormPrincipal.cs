using SimuladorPistaDeCorrida.Domain;
using System;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.WinApp
{
    public partial class FormPrincipal : Form
    {
        Apostador apostador = new Apostador();
        Aposta apostas = new Aposta();

        Apostador[] apostadores = new Apostador[3];
        


        public FormPrincipal()
        {
            InitializeComponent();

            apostadores[0] = new Apostador();
            apostadores[0].Nome = "João";
            apostadores[0].Dinheiro = 50;
            apostadores[0].Meuradiobutton = rbtJoao;
            apostadores[0].Minhalabel = lblJoao;
            apostadores[0].UpdateLabels();

            apostadores[1] = new Apostador();
            apostadores[1].Nome = "Beto";
            apostadores[1].Dinheiro = 75;
            apostadores[1].Meuradiobutton = rbtBeto;
            apostadores[1].Minhalabel = lblBeto;
            apostadores[1].UpdateLabels();

            apostadores[0] = new Apostador();
            apostadores[0].Nome = "Alfredo";
            apostadores[0].Dinheiro = 45;
            apostadores[0].Meuradiobutton = rbtAlfredo;
            apostadores[0].Minhalabel = lblAlfredo;
            apostadores[0].UpdateLabels();

        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            var teste = apostador.Nome + "Apostou ";
            txtJoão.Text = teste;
        }
    }
}

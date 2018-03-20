using SimuladorPistaDeCorrida.Domain;
using System;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.WinApp
{
    public partial class FormPrincipal : Form
    {
        Apostador apostador = new Apostador();
        Apostador[] apostadores = new Apostador[3];
        Apostador recebeApostador;
        
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

            apostadores[2] = new Apostador();
            apostadores[2].Nome = "Alfredo";
            apostadores[2].Dinheiro = 45;
            apostadores[2].Meuradiobutton = rbtAlfredo;
            apostadores[2].Minhalabel = lblAlfredo;
            apostadores[2].UpdateLabels();

        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            //VerificandoRadioButton();
            //VerificaTextField();
            apostador = VerificandoRadioButton(recebeApostador);
            apostador.NovaAposta(Convert.ToInt32(numericValor.Value), Convert.ToInt32(numericCao.Value));
            VerificaTextField(apostador);

        } 

        
        public Apostador VerificandoRadioButton(Apostador recebeApostador)
        {
            if (rbtJoao.Checked == true)
            {
                recebeApostador = apostadores[0];
                return apostadores[0];
                
            }
            else if (rbtBeto.Checked == true)
            {
                recebeApostador = apostadores[1];
                return apostadores[1];
            }
            else
            {
                recebeApostador = apostadores[2];
                return apostadores[2];
            }
        }

        private void TrocarNomeLabel()
        {
            if (rbtJoao.Checked == true)
            {
                var teste2 = apostadores[0].Nome;
                lblNomeApostador.Text = teste2;
            }
            else if (rbtBeto.Checked == true)
            {
                var teste2 = apostadores[1].Nome;
                lblNomeApostador.Text = teste2;
            }
            else if (rbtAlfredo.Checked == true)
            {
                var teste2 = apostadores[2].Nome;
                lblNomeApostador.Text = teste2;
            }
        }

        private void VerificaTextField(Apostador apostador)
        {
            if (rbtJoao.Checked == true)
            {
                //var teste = apostadores[0].Nome + " apostou " + numericValor.Value + " no cachorro " + numericCao.Value;
                txtJoão.Text = apostador.aposta.GetDescription();
                
            }
            else if (rbtBeto.Checked == true)
            {
                //var teste = apostadores[1].Nome + " apostou " + numericValor.Value + " no cachorro " + numericCao.Value;
                txtBeto.Text = apostador.aposta.GetDescription();

            }
            else
            {
                //var teste = apostadores[2].Nome + " apostou " + numericValor.Value + " no cachorro " + numericCao.Value;
                txtAlfredo.Text = apostador.aposta.GetDescription();
                
            }
        } 

        private void rbtJoao_CheckedChanged(object sender, EventArgs e)
        {
            TrocarNomeLabel();
        }

        private void rbtBeto_CheckedChanged(object sender, EventArgs e)
        {
            TrocarNomeLabel();
        }

        private void rbtAlfredo_CheckedChanged(object sender, EventArgs e)
        {
            TrocarNomeLabel();
        }
    }
}

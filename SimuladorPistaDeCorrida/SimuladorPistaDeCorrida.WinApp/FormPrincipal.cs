using SimuladorPistaDeCorrida.Domain;
using System;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.WinApp
{
    public partial class FormPrincipal : Form
    {
        private Apostador[] _apostadores;
        private Cachorro[] _cachorro;
        Random _myRandom = new Random();

        public FormPrincipal()
        {
            InitializeComponent();

            ///Apostadores
            _apostadores = new Apostador[3];
            _apostadores[0] = new Apostador("João", 50, rbtJoao, lblJoao);
            _apostadores[1] = new Apostador("Beto", 75, rbtBeto, lblBeto);
            _apostadores[2] = new Apostador("Alfredo", 45, rbtAlfredo, lblAlfredo);
            ///Cachorros 
            _cachorro = new Cachorro[4];
            _cachorro[0] = new Cachorro(pbxCao1, pbxCao1.Location.X, (this.pbxPistaCorrida.Width - 150), _myRandom);
            _cachorro[1] = new Cachorro(pbxCao2, pbxCao2.Location.X, (this.pbxPistaCorrida.Width - 150), _myRandom);
            _cachorro[2] = new Cachorro(pbxCao3, pbxCao3.Location.X, (this.pbxPistaCorrida.Width - 150), _myRandom);
            _cachorro[3] = new Cachorro(pbxCao4, pbxCao4.Location.X, (this.pbxPistaCorrida.Width - 150), _myRandom);

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            txtJoão.Text = _apostadores[0].PegaAposta().GetDescriçaoAposta();
            txtBeto.Text = _apostadores[1].PegaAposta().GetDescriçaoAposta();
            txtAlfredo.Text = _apostadores[2].PegaAposta().GetDescriçaoAposta();
        }

        private void SetandoApostadores(int numero)
        {
            VisibilidadeBotoes();
            lblNomeApostador.Text = _apostadores[numero].ToString();
            TrocaNomeLabel();
            VerificaTextField(numero);
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_apostadores[VerificaRadioButton()].PegaAposta().GetQuantidade() is 0)
                {
                    int valoraposta = Convert.ToInt32(numericValor.Value);
                    int numerocao = Convert.ToInt32(numericCao.Value);

                    if (_apostadores[VerificaRadioButton()].NovaAposta(valoraposta, numerocao - 1))
                    {
                        VerificaTextField(VerificaRadioButton());

                        if (ConferirTodasApostas())
                        {
                            MessageBox.Show("Todos os jogadores apostaram..", "Apostas feitas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnApostar.Enabled = false;
                            btnCorrer.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente para apostar", "Erro na aposta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O Jogador " + _apostadores[VerificaRadioButton()] + ", ja apostou.", "Aposta já feita!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aposta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public int VerificaRadioButton()
        {
            if (rbtJoao.Checked == true)
            {
                return 0;
            }
            else if (rbtBeto.Checked == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        private void TrocaNomeLabel()
        {
            if (rbtJoao.Checked == true)
            {
                var teste2 = _apostadores[0]._nome;
                lblNomeApostador.Text = teste2;
            }
            else if (rbtBeto.Checked == true)
            {
                var teste2 = _apostadores[1]._nome;
                lblNomeApostador.Text = teste2;
            }
            else if (rbtAlfredo.Checked == true)
            {
                var teste2 = _apostadores[2]._nome;
                lblNomeApostador.Text = teste2;
            }
        }

        private void VerificaTextField(int verifica)
        {
            #region Área Comentada
            //if (rbtJoao.Checked == true)
            //{
            //    //var teste = _apostadores[0]._nome + " apostou " + numericValor.Value + " no cachorro " + numericCao.Value;
            //    //txtJoão.Text = teste;
            //    txtJoão.Text = apostador.aposta.GetDescription();

            //}
            //else if (rbtBeto.Checked == true)
            //{
            //    //var teste = _apostadores[1]._nome + " apostou " + numericValor.Value + " no cachorro " + numericCao.Value;
            //    //txtBeto.Text = teste;
            //    txtBeto.Text = apostador.aposta.GetDescription();

            //}
            //else
            //{
            //    //var teste = _apostadores[2]._nome + " apostou " + numericValor.Value + " no cachorro " + numericCao.Value;
            //    //txtAlfredo.Text = teste;
            //    txtAlfredo.Text = apostador.aposta.GetDescription();

            //}
            #endregion 

            if (verifica == 0)
                txtJoão.Text = _apostadores[verifica].PegaAposta().GetDescriçaoAposta();
            else if (verifica == 1)
                txtBeto.Text = _apostadores[verifica].PegaAposta().GetDescriçaoAposta();
            else
                txtAlfredo.Text = _apostadores[verifica].PegaAposta().GetDescriçaoAposta();
        }

        /// Conferi se todos apostaram
        private bool ConferirTodasApostas()
        {
            if (_apostadores[0].PegaAposta().GetQuantidade() > 0 && _apostadores[1].PegaAposta().GetQuantidade() > 0 && _apostadores[2].PegaAposta().GetQuantidade() > 0)
            {
                return true;
            }
            return false;
        }

        private void VisibilidadeBotoes()
        {
            if (btnApostar.Enabled == false)
                btnApostar.Enabled = true;

            if (btnCorrer.Enabled == true)
                btnCorrer.Enabled = false;
        }

        private void rbtJoao_CheckedChanged(object sender, EventArgs e)
        {
            //TrocaNomeLabel();
            SetandoApostadores(0);
        }

        private void rbtBeto_CheckedChanged(object sender, EventArgs e)
        {
            // TrocaNomeLabel();
            SetandoApostadores(1);
        }

        private void rbtAlfredo_CheckedChanged(object sender, EventArgs e)
        {
           // TrocaNomeLabel();
            SetandoApostadores(2);
        }

        private void Restart()
        {
            for (int i = 0; i <= 2; i++)
            {
                _apostadores[i].LimparAposta();
            }

            for (int i = 0; i <= 3; i++)
            {
                _cachorro[i].PegarPosiçãoInicial();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (_cachorro[i].Correr())
                {
                    timer1.Stop();
                    for (int a = 0; a <= 2; a++)
                    {
                        _apostadores[a].Collect(i);
                    }
                    MessageBox.Show("O vencedor foi o: " + _cachorro[i]);
                    Restart();
                    btnApostar.Enabled = true;
                    btnCorrer.Enabled = false;
                    return;
                }

            }
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }


    }
}

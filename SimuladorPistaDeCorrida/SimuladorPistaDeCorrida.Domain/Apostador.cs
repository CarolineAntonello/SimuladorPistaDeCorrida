using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.Domain
{
    public class Apostador ///Guy
    {
        public string _nome; ///o nome do apostador
        public Aposta _minhaAposta; ///uma instancia de Aposta() que mantem as apostas 
        public int _dinheiro; ///quanto dinheiro resta
        public RadioButton _meuradiobutton; ///botão de radio
        public Label _minhalabel; ///meu rotulo
        public Aposta aposta;
       
        /// Parametro do apostador
        public Apostador(string nome, int dinheiro, RadioButton meuradiobutton, Label minhalabel)
        {
            _nome = nome;
            _dinheiro = dinheiro;
            _meuradiobutton = meuradiobutton;
            _minhalabel = minhalabel;
            _minhaAposta = new Aposta(this);
            UpdateLabels();
        }

        ///// Parametro do apostador
        //public Apostador()
        //{
        //}

        /// <summary>
        /// Atualiza a label com o nome e o dinheiro que cada um possui
        /// </summary>
        public void UpdateLabels()
        {
            /// _minhalabel.Text = string.Format(_nome + " possui "+ _dinheiro + "R$.");
            _minhalabel.Text = _nome + " possui " + _dinheiro + "R$.";
        }

        /// <summary>
        /// Reinicializar minha aposta para que ela zere e instanciar uma nova aposta
        /// </summary>
        public void LimparAposta()
        {
            _minhaAposta = null;
            _minhaAposta = new Aposta(this);
        }

        /// <summary>
        /// Crie uma nova aposta e armazene-a no meu campo aposta 
        /// Retorne verdadeiro se o cara tem dinheiro para apostar
        /// </summary>
        public bool NovaAposta(int quantidade, int cachorro)
        {
            if (quantidade <= 4)
               throw new Exception("A aposta minima deve ser maior que 5R$.");
               // MessageBox.Show("A aposta mínima deve ser maior que 5R$", "Aposta não realizada!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            if (_minhaAposta != null)
            {
                if (quantidade <= _dinheiro)
                {
                    _minhaAposta = new Aposta(this);
                    _minhaAposta.SetQuantidade(quantidade);
                    _minhaAposta.SetCachorro(cachorro);
                    return true;
                }
                else
                    throw new Exception(_nome + ": saldo Insuficiente" + "voce possui" + _dinheiro + "R$.");
            }
            else
                return false;
            
        }

        /// <summary>
        /// Cobre minha aposta se eu ganhar
        /// </summary>
        public void Collect(int ganhador)
        {
            if (_minhaAposta != null)
            {
                _dinheiro += _minhaAposta.PagaAposta(ganhador);
                UpdateLabels();
                return;
            }
            else
                throw new Exception("Aposta anulada");
        }

        public int RecebeDinheiro()
        {
            return _dinheiro;
        }

        public Aposta PegaAposta()
        {
            return _minhaAposta;
        }

        public override string ToString()
        {
            return _nome;
        }

    }

}

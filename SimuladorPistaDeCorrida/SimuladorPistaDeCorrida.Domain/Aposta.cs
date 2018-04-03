using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.Domain
{
    /// <summary>
    /// Este é o objeto que a classe Apostador usa para representar apostas no aplicativo
    /// </summary>
    public class Aposta ///Bet
    {
        private Apostador _apostador; 
        private int _quantidade; /// Valor apostado
        private int _cachorro;

        public Aposta(Apostador apostador)
        {
            _apostador = apostador;
        }

        public Aposta(Apostador apostador, int quantidade, int cachorro)
        {
            _apostador = apostador;
            _quantidade = quantidade;
            _cachorro = cachorro;
        }

        /// <summary>
        /// Retorna uma sequencia de caracteres que diz quem fez a aposta, quanto dinheiro
        /// Foi apostado e em qual cão ("João apostou 8 no cão 4"). Se a aposta for zero, a aposta não foi feita ("João não apostou")
        /// </summary>
        public string GetDescriçaoAposta()
        {
            if(_quantidade > 1)
                return _apostador._nome + " : apostou " + _quantidade + " no cão: " + (_cachorro + 1);

            return string.Format("...",_apostador);

        }

        /// <summary>
        /// O parametro deve receber o vencedor da corrida. Se o cão venceu, retorna a quantidade apostada.
        /// De outra forma, retorna um valor negativo correspondente ao valor apostado.
        /// </summary>
        public int PagaAposta(int ganhador)
        {
            if (_cachorro == ganhador)
            {
                return _quantidade;
            }
            else
            {
                return _quantidade * -1;
            }
        }

        /// <summary>
        /// Pega a quantidade apostada
        /// </summary>
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        public void SetCachorro(int cachorro)
        {
            _cachorro = cachorro;
        }


    }
}

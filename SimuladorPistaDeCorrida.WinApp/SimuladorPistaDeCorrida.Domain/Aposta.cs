using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.Domain
{
    //este é o objeto que a classe Guy usa para representar apostas no aplicativo
    public class Aposta
    {
        //public int _quantidade;//amount
        //public int _cachorro;
        //public Apostador _apostador;//o cara q fez a aposta
        private Apostador apostador;
        private int quantidade;
        private int cachorro;

        public Aposta(Apostador apostador, int quantidade, int cachorro)
        {
            this.apostador = apostador;
            this.quantidade = quantidade;
            this.cachorro = cachorro;
        }


        public string GetDescription()
        {
            //retorna uma sequencia de caracteres que diz quem fez a aposta, quanto dinheiro
            //foi apostado e em qual cão ("João apostou 8 no cão 4"). Se a aposta for zero,
            //a aposta não foi feita ("João não apostou")
            return apostador.Nome + "Apostou " + quantidade + " no cão " + cachorro;

        }

        public int PayOut(int Winner)
        {
            //o parametro deve receber o vencedor da corrida. se o cão venceu, 
            //retorna a quantidade apostada.
            //De outra forma, retorna um valor negativo correspondente ao valor apostado. 
            if (cachorro == Winner)
            {
                return quantidade;
            }
            else
            {
                return quantidade * -1;
            }
        }

    }
}

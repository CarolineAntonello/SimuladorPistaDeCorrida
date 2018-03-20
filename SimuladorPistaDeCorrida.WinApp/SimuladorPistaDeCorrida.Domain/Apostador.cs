using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.Domain
{
    public class Apostador
    {
        public string Nome;//o nome do cara
        public Aposta MinhaAposta;//uma instancia de Aposta() que mantem as apostas 
        public int Dinheiro;//quanto dinheiro resta
        public RadioButton Meuradiobutton;//botão de radio
        public Label Minhalabel;//meu rotulo

        
        public void UpdateLabels()
        {
            Minhalabel.Text = Nome + " tem: " + Dinheiro;

        }

        public void LimparAposta()
        {
            //reinicializar minh aposta para que ela zere
            MinhaAposta = null;
        }

        public bool NovaAposta(int quantidade, int cachorro)
        {
            //Crie uma nova aposta e armazene-a no meu campo bet 
            //retorne verdadeiro se o cara tem dinheiro para apostar
            //apostadores[0].NovaAposta(numericUpDown1.value, numericUpDown2.value);

            if (MinhaAposta != null)
            {
                if(quantidade <= Dinheiro)
                {
                    MinhaAposta = new Aposta(this, quantidade, cachorro);
                    return true;
                }
                else
                {
                    throw new Exception(Nome + ": saldo Insuficiente" + "voce possui" + Dinheiro);
                }
            }
            else
            {
                return false;
            }

            
        }

        public void Collect(int Winner)
        {
            //cobre minha aposta se eu ganhei
            Dinheiro += MinhaAposta.PayOut(Winner);
        }

    }

}

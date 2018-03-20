using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorPistaDeCorrida.Domain
{
    public class Cachorro
    {
        public int StartingPosition;//onde a caixa de imagem inicia
        public int RacetrackLength;//o quanto a pista de corrida tem de comprimento
        public PictureBox Mypicturebox = null;//meu objeto caixa de imagem 
        public int Location = 0;//minha posição na pista
        public Random MyRandom;//uma instancia de random

        Cachorro[] cachorros = new Cachorro[3];
        

        public bool Run()
        {
            //mova-se para frente 1-2-3 ou 4 espaços aleatoriamente
            //atualize a posição da minha caixa de imagem no formulário 
            //retorna true se eu ganhei a corrida

            return true;
        }

        public void TakeStartingPosition()
        {
            //volte minha posição para a linha de partida
        }

        //public void Correr()
        //{
        //    MyRandom = new Random();
        //    int distance = MyRandom.Next(4);
        //    Pointer p = Mypicturebox.Location;

        //    p.X += distance;
        //    Mypicturebox.Location = p;
        //}
    }
}

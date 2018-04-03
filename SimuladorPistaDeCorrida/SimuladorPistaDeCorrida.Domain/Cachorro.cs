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
    public class Cachorro ///BlackHound
    {
        public int _startingPosition; ///onde a caixa de imagem inicia
        public int _racetrackLength; ///o quanto a pista de corrida tem de comprimento
        public PictureBox _myPictureBox = null; ///objeto caixa de imagem 
        public int _location = 0; ///posição na corrida
        public Random _myRandom; ///uma instancia de random

        public Cachorro(PictureBox myPictureBox, int startingPosition, int racetrackLength, Random myRandom)
        {
            _myPictureBox = myPictureBox;
            _startingPosition = startingPosition;
            _racetrackLength = racetrackLength;
            _location = new int();
            _myRandom = myRandom;
        }

        /// <summary>
        /// Mova-se para frente 1-2-3 ou 4 espaços aleatoriamente
        /// Atualize a posição da minha caixa de imagem no formulário retorna true se eu ganhei a corrida
        /// </summary>
        public bool Correr()
        {
            
            var point = _myPictureBox.Location;
            var dist = PegarDistancia();
            point.X += dist;
            _myPictureBox.Location = point;

            if (_myPictureBox.Location.X >= _racetrackLength)
                return true;

            return false;
        }

        /// <summary>
        /// Volte minha posição para a linha de partida
        /// </summary>
        public void PegarPosiçãoInicial()
        {
            var point = _myPictureBox.Location;
            point.X = _startingPosition;
            _myPictureBox.Location = point;
        }

        /// <summary>
        /// Pega a minha distância
        /// </summary>
        private int PegarDistancia()
        {
            return _myRandom.Next(0, 5);
        }

        public override string ToString()
        {
            return string.Format("{0}", _myPictureBox.AccessibleName);
        }
    }
}

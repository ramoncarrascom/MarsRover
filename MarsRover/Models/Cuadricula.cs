using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Cuadricula
    {
        private int tamanyoX;
        private int tamanyoY;

        public int TamanyoX
        {
            get { return tamanyoX; }

            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(TamanyoX), "El valor debe ser mayor que cero.");

                tamanyoX = value;
            }
        }

        public int TamanyoY
        {
            get { return tamanyoY; }

            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(TamanyoY), "El valor debe ser mayor que cero.");

                tamanyoY = value;
            }
        }

        public Cuadricula() : this(10, 10)
        {
        }

        public Cuadricula(int tamanyoX, int tamanyoY)
        {
            TamanyoX = tamanyoX;
            TamanyoY = tamanyoY;
        }

        public bool EsValorPermitido(Coordenada coordenada)
        {
            if (coordenada == null)
            {
                return false;
            }

            return coordenada.X >= 1 && coordenada.X <= TamanyoX &&
                   coordenada.Y >= 1 && coordenada.Y <= TamanyoY;
        }
    }
}

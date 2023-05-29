using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Coordenada
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(X), "El valor de X debe ser un número mayor que 0");
                }

                x = value;
            }
        }

        public int Y
        {
            get { return y; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Y), "El valor de Y debe ser un número mayor que 0");
                }

                y = value;
            }
        }

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }

}

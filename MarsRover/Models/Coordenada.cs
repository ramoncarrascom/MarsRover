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
            get 
            { 
                return x; 
            } 
            
            set 
            {
                ValidateXvalue(value);
                x = value; 
            } 
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                ValidateYvalue(value);
                y = value;
            }
        }

        public Coordenada(int x, int y)
        {
            ValidateXvalue(x);
            ValidateYvalue(y);
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        private static void ValidateXvalue(int x)
        {
            if (x <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(x), "El valor de X debe ser un número mayor que 0");
            }
        }

        private static void ValidateYvalue(int y)
        {
            if (y <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(y), "El valor de Y debe ser un número mayor que 0");
            }
        }
    }
}

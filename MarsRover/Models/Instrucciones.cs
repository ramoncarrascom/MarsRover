using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Instrucciones
    {
        private string ordenes;
        private int posicion;

        public Instrucciones(string ordenes)
        {
            if (string.IsNullOrEmpty(ordenes))
            {
                throw new ArgumentException("La cadena de órdenes no puede estar vacía.");
            }

            if (!SonLetrasPermitidas(ordenes))
            {
                throw new ArgumentException("La cadena de órdenes contiene caracteres no permitidos.");
            }

            this.ordenes = ordenes.ToUpper();
            posicion = 0;
        }

        public char? SiguienteOrden()
        {
            if (posicion >= ordenes.Length)
            {
                return null;
            }

            char siguienteOrden = ordenes[posicion];
            posicion++;
            return siguienteOrden;
        }

        public void Restablecer()
        {
            posicion = 0;
        }

        private bool SonLetrasPermitidas(string cadena)
        {
            foreach (char c in cadena)
            {
                if (c != 'L' && c != 'M' && c != 'R' && c != 'l' && c != 'm' && c != 'r')
                {
                    return false;
                }
            }

            return true;
        }
    }

}

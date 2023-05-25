using MarsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Orientacion
    {
        private Orientaciones valor;

        public Orientaciones Valor 
        {
            get
            {
                return valor;
            }
        }

        public Orientacion() 
        {
            valor = Orientaciones.NORTE;
        }

        public Orientacion(Orientaciones valor)
        {
            this.valor = valor;
        }

        public void GirarDerecha()
        {
            int orientacionActual = (int)valor;
            orientacionActual++;
            valor = (Orientaciones)(orientacionActual <= 4 ? orientacionActual : 1);
        }

        public void GirarIzquierda()
        {
            int orientacionActual = (int)valor;
            orientacionActual--;
            valor = (Orientaciones)(orientacionActual >= 1 ? orientacionActual : 4);
        }
    }
}

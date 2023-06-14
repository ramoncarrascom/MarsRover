using MarsRover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Rover
    {
        private Coordenada coordenada;
        private readonly Orientacion orientacion;
        private readonly Cuadricula cuadricula;

        public Coordenada Coordenadas
        {
            get
            {
                return coordenada.Clone();
            }
        }

        public Orientacion Orientacion
        {
            get
            {
                return orientacion.Clone();
            }
        }

        public Cuadricula Cuadricula
        {
            get
            {
                return cuadricula.Clone();
            }
        }


        public Rover(Cuadricula cuadricula, Coordenada coordenadaInicial, Orientacion orientacionInicial)
        {
            coordenada = coordenadaInicial.Clone();
            orientacion = orientacionInicial.Clone();
            this.cuadricula = cuadricula.Clone();
        }

        public void GirarDerecha()
        {
            orientacion.GirarDerecha();
        }

        public void GirarIzquierda()
        {
            orientacion.GirarIzquierda();
        }

        public void Avanzar()
        {
            try
            {
                Coordenada nuevaCoordenada = CalcularNuevaCoordenada();
                if (cuadricula.EsValorPermitido(nuevaCoordenada))
                {
                    coordenada = nuevaCoordenada;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private Coordenada CalcularNuevaCoordenada()
        {
            int nuevaX = coordenada.X;
            int nuevaY = coordenada.Y;

            switch (orientacion.Valor)
            {
                case Orientaciones.NORTE:
                    nuevaY--;
                    break;
                case Orientaciones.ESTE:
                    nuevaX++;
                    break;
                case Orientaciones.SUR:
                    nuevaY++;
                    break;
                case Orientaciones.OESTE:
                    nuevaX--;
                    break;
            }

            return new Coordenada(nuevaX, nuevaY);
        }

    }
}

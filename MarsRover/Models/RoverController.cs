using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class RoverController
    {
        private readonly Rover rover;
        private readonly Instrucciones instrucciones;

        public RoverController(Rover rover, Instrucciones instrucciones)
        {
            this.rover = rover;
            this.instrucciones = instrucciones;
        }

        public void EjecutarInstrucciones()
        {
            char? orden;
            while ((orden = instrucciones.SiguienteOrden()) != null)
            {
                switch (orden)
                {
                    case 'M':
                        rover.Avanzar();
                        break;
                    case 'L':
                        rover.GirarIzquierda();
                        break;
                    case 'R':
                        rover.GirarDerecha();
                        break;
                    default:
                        throw new InvalidOperationException($"Orden desconocida: {orden}");
                }
            }
        }
    }
}

using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test.Models
{
    public class RoverControllerTest
    {
        [Test]
        public void RoverController_DebeMoverRover_HaciaAdelante_ConOrdenM()
        {
            // Arrange
            Cuadricula cuadricula = new(5, 5);
            Coordenada inicio = new(3, 3);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, inicio, orientacionInicial);
            Instrucciones instrucciones = new("M");
            RoverController controller = new(rover, instrucciones);

            // Act
            controller.EjecutarInstrucciones();

            // Assert
            Assert.That(rover.Coordenadas.Y, Is.EqualTo(2));
        }

        [Test]
        public void RoverController_DebeGirarRoverALaIzquierda_ConOrdenL()
        {
            // Arrange
            Cuadricula cuadricula = new(5, 5);
            Coordenada inicio = new(3, 3);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, inicio, orientacionInicial);
            Instrucciones instrucciones = new("L");
            RoverController controller = new(rover, instrucciones);

            // Act
            controller.EjecutarInstrucciones();

            // Assert
            Assert.That(rover.Orientacion.Valor, Is.EqualTo(Orientaciones.OESTE));
        }

        [Test]
        public void RoverController_DebeGirarRoverALaDerecha_ConOrdenR()
        {
            // Arrange
            Cuadricula cuadricula = new(5, 5);
            Coordenada inicio = new(3, 3);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, inicio, orientacionInicial);
            Instrucciones instrucciones = new("R");
            RoverController controller = new(rover, instrucciones);

            // Act
            controller.EjecutarInstrucciones();

            // Assert
            Assert.That(rover.Orientacion.Valor, Is.EqualTo(Orientaciones.ESTE));
        }

        [Test]
        public void RoverController_DebeProcesarUnaSecuenciaDeOrdenes()
        {
            // Arrange
            Cuadricula cuadricula = new(5, 5);
            Coordenada inicio = new(3, 3);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, inicio, orientacionInicial);
            Instrucciones instrucciones = new("MLMR");
            RoverController controller = new(rover, instrucciones);

            // Act
            controller.EjecutarInstrucciones();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(rover.Coordenadas.X, Is.EqualTo(2));
                Assert.That(rover.Coordenadas.Y, Is.EqualTo(2));
                Assert.That(rover.Orientacion.Valor, Is.EqualTo(Orientaciones.NORTE));
            });
        }
    }
}

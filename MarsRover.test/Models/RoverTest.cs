using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test.Models
{
    public class RoverTest
    {
        [Test]
        public void Rover_Orientacion_DevuelveNuevaInstanciaConMismoValor()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(3, 5);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            Orientacion clonedOrientacion = rover.Orientacion;

            // Assert
            Assert.That(clonedOrientacion, Is.Not.SameAs(orientacionInicial));
            Assert.That(clonedOrientacion.Valor, Is.EqualTo(orientacionInicial.Valor));
        }

        [Test]
        public void Rover_Coordenadas_DevuelveNuevaInstanciaConMismoValor()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(3, 5);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            Coordenada clonedCoordenadas = rover.Coordenadas;

            // Assert
            Assert.That(clonedCoordenadas, Is.Not.SameAs(coordenadaInicial));
            Assert.Multiple(() =>
            {
                Assert.That(clonedCoordenadas.X, Is.EqualTo(coordenadaInicial.X));
                Assert.That(clonedCoordenadas.Y, Is.EqualTo(coordenadaInicial.Y));
            });
        }

        [Test]
        public void Rover_Cuadricula_DevuelveNuevaInstanciaConMismoValor()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(3, 5);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            Cuadricula clonedCuadricula = rover.Cuadricula;

            // Assert
            Assert.That(clonedCuadricula, Is.Not.SameAs(cuadricula));
            Assert.Multiple(() =>
            {
                Assert.That(clonedCuadricula.TamanyoX, Is.EqualTo(cuadricula.TamanyoX));
                Assert.That(clonedCuadricula.TamanyoY, Is.EqualTo(cuadricula.TamanyoY));
            });
        }

        [Test]
        public void Rover_Avanzar_CoordenadasValidas_Avanzar()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(5, 5);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(5));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(4));
            });
        }

        [Test]
        public void Rover_Avanzar_CoordenadasInvalidasDestino_SegunNormasCuadricula_NoSeDesplaza()
        {
            // Arrange
            Cuadricula cuadricula = new(5, 5);
            Coordenada coordenadaInicial = new(5, 5);
            Orientacion orientacionInicial = new(Orientaciones.SUR);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(5));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(5));
            });
        }

        [Test]
        public void Rover_Avanzar_CoordenadasInvalidasDestino_SegunNormasCoordenada_ExcepcionGestionada()
        {
            // Arrange
            Cuadricula cuadricula = new(5, 5);
            Coordenada coordenadaInicial = new(3, 1);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(3));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(1));
            });
        }

        [Test]
        public void Rover_Avanzar_CoordenadasValidas_LimiteInferiorX_Avanzar()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(1, 5);
            Orientacion orientacionInicial = new(Orientaciones.OESTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(1));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(5));
            });
        }

        [Test]
        public void Rover_Avanzar_CoordenadasValidas_LimiteSuperiorX_Avanzar()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(10, 5);
            Orientacion orientacionInicial = new(Orientaciones.ESTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(10));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(5));
            });
        }

        [Test]
        public void Rover_Avanzar_CoordenadasValidas_LimiteInferiorY_Avanzar()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(5, 10);
            Orientacion orientacionInicial = new(Orientaciones.SUR);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(5));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(10));
            });
        }

        [Test]
        public void Rover_Avanzar_CoordenadasValidas_LimiteSuperiorY_Avanzar()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(5, 1);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(5));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(1));
            });
        }

        [Test]
        public void Rover_GirarIzquierdaAvanzar_CoordenadasValidas_AvanzarEnDireccionIzquierda()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(5, 5);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.GirarIzquierda();
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(4));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(5));
            });
        }

        [Test]
        public void Rover_GirarDerechaAvanzar_CoordenadasValidas_AvanzarEnDireccionDerecha()
        {
            // Arrange
            Cuadricula cuadricula = new(10, 10);
            Coordenada coordenadaInicial = new(5, 5);
            Orientacion orientacionInicial = new(Orientaciones.NORTE);
            Rover rover = new(cuadricula, coordenadaInicial, orientacionInicial);

            // Act
            rover.GirarDerecha();
            rover.Avanzar();

            // Assert
            Coordenada nuevaCoordenada = rover.Coordenadas;
            Assert.Multiple(() =>
            {
                Assert.That(nuevaCoordenada.X, Is.EqualTo(6));
                Assert.That(nuevaCoordenada.Y, Is.EqualTo(5));
            });
        }

    }
}

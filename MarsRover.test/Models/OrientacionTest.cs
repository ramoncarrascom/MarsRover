using MarsRover.Enums;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test.Models
{
    public class OrientacionTest
    {
        [Test]
        public void Orientacion_GirarIzquierda_DesdeNorte_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.NORTE);

            // Act
            orientacion.GirarIzquierda();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.OESTE));
        }

        [Test]
        public void Orientacion_GirarIzquierda_DesdeEste_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.ESTE);

            // Act
            orientacion.GirarIzquierda();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.NORTE));
        }

        [Test]
        public void Orientacion_GirarIzquierda_DesdeSur_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.SUR);

            // Act
            orientacion.GirarIzquierda();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.ESTE));
        }

        [Test]
        public void Orientacion_GirarIzquierda_DesdeOeste_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.OESTE);

            // Act
            orientacion.GirarIzquierda();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.SUR));
        }

        [Test]
        public void Orientacion_GirarDerecha_DesdeNorte_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.NORTE);

            // Act
            orientacion.GirarDerecha();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.ESTE));
        }

        [Test]
        public void Orientacion_GirarDerecha_DesdeEste_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.ESTE);

            // Act
            orientacion.GirarDerecha();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.SUR));
        }

        [Test]
        public void Orientacion_GirarDerecha_DesdeSur_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.SUR);

            // Act
            orientacion.GirarDerecha();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.OESTE));
        }

        [Test]
        public void Orientacion_GirarDerecha_DesdeOeste_DebeCambiarLaOrientacionCorrectamente()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.OESTE);

            // Act
            orientacion.GirarDerecha();
            Orientaciones nuevaOrientacion = orientacion.Valor;

            // Assert
            Assert.That(nuevaOrientacion, Is.EqualTo(Orientaciones.NORTE));
        }

        [Test]
        public void Orientacion_Clone_DevuelveNuevaInstanciaConMismoValor()
        {
            // Arrange
            Orientacion orientacion = new Orientacion(Orientaciones.NORTE);

            // Act
            Orientacion clonedOrientacion = orientacion.Clone();

            // Assert
            Assert.That(clonedOrientacion, Is.Not.SameAs(orientacion));
            Assert.That(clonedOrientacion.Valor, Is.EqualTo(orientacion.Valor));
        }

    }
}

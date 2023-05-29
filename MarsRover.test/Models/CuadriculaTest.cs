using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test.Models
{
    public class CuadriculaTest
    {
        [Test]
        public void Cuadricula_DebeTener_TamanyoPorDefecto_10x10()
        {
            // Arrange
            Cuadricula cuadricula = new();

            // Act
            int tamanyoX = cuadricula.TamanyoX;
            int tamanyoY = cuadricula.TamanyoY;

            // Assert
            Assert.That(tamanyoX, Is.EqualTo(10));
            Assert.That(tamanyoY, Is.EqualTo(10));
        }

        [Test]
        public void Cuadricula_DebeAdmitir_ValoresPersonalizados()
        {
            // Arrange
            int tamanyoX = 5;
            int tamanyoY = 7;

            // Act
            Cuadricula cuadricula = new Cuadricula(tamanyoX, tamanyoY);

            // Assert
            Assert.That(cuadricula.TamanyoX, Is.EqualTo(tamanyoX));
            Assert.That(cuadricula.TamanyoY, Is.EqualTo(tamanyoY));
        }

        [Test]
        public void Cuadricula_DebeLanzarExcepción_SiTamanyoXNoEsPositivo()
        {
            // Arrange
            int tamanyoX = -5;
            int tamanyoY = 1;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Cuadricula(tamanyoX, tamanyoY));
        }

        [Test]
        public void Cuadricula_DebeLanzarExcepción_SiTamanyoYNoEsPositivo()
        {
            // Arrange
            int tamanyoX = 1;
            int tamanyoY = -5;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Cuadricula(tamanyoX, tamanyoY));
        }

        [Test]
        public void Cuadricula_DebeLanzarExcepción_SiTamanyoXEs0()
        {
            // Arrange
            int tamanyoX = 0;
            int tamanyoY = 1;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Cuadricula(tamanyoX, tamanyoY));
        }

        [Test]
        public void Cuadricula_DebeLanzarExcepción_SiTamanyoYEs0()
        {
            // Arrange
            int tamanyoX = 1;
            int tamanyoY = 0;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Cuadricula(tamanyoX, tamanyoY));
        }

        [Test]
        public void Cuadricula_EsValorPermitido_SiCoordenadaEsValido_DevuelveTrue()
        {
            // Arrange
            int tamanyoX = 5;
            int tamanyoY = 7;
            Cuadricula cuadricula = new Cuadricula(tamanyoX, tamanyoY);
            Coordenada coordenada = new Coordenada(3, 4);

            // Act
            bool esPermitido = cuadricula.EsValorPermitido(coordenada);

            // Assert
            Assert.IsTrue(esPermitido);
        }

        [Test]
        public void Cuadricula_EsValorPermitido_SiXEstaFueraDeRango_DevuelveFalse()
        {
            // Arrange
            int tamanyoX = 5;
            int tamanyoY = 7;
            Cuadricula cuadricula = new Cuadricula(tamanyoX, tamanyoY);
            Coordenada coordenada = new Coordenada(7, 4);

            // Act
            bool esPermitido = cuadricula.EsValorPermitido(coordenada);

            // Assert
            Assert.That(esPermitido, Is.False);
        }

        [Test]
        public void Cuadricula_EsValorPermitido_SiYEstaFueraDeRango_DevuelveFalse()
        {
            // Arrange
            int tamanyoX = 5;
            int tamanyoY = 7;
            Cuadricula cuadricula = new Cuadricula(tamanyoX, tamanyoY);
            Coordenada coordenada = new Coordenada(3, 8);

            // Act
            bool esPermitido = cuadricula.EsValorPermitido(coordenada);

            // Assert
            Assert.That(esPermitido, Is.False);
        }

        [Test]
        public void Cuadricula_EsValorPermitido_SiCoordenadaNull_DevuelveFalse()
        {
            // Arrange
            int tamanyoX = 5;
            int tamanyoY = 7;
            Cuadricula cuadricula = new Cuadricula(tamanyoX, tamanyoY);
            Coordenada coordenada = null!;

            // Act
            bool esPermitido = cuadricula.EsValorPermitido(coordenada);

            // Assert
            Assert.That(esPermitido, Is.False);
        }
    }
}

using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test.Models
{
    public class CoordenadaTest
    {
        [Test]
        public void Coordenada_X_EnConstructor_DebeSerMayorQue0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { Coordenada test = new Coordenada(0, 1); });
        }

        [Test]
        public void Coordenada_X_EnConstructor_DebeSerPositivo()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { Coordenada test = new Coordenada(-1, 1); });
        }

        [Test]
        public void Coordenada_Y_EnConstructor_DebeSerMayorQue0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { Coordenada test = new Coordenada(1, 0); });
        }

        [Test]
        public void Coordenada_Y_EnConstructor_DebeSerPositivo()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { Coordenada test = new Coordenada(1, -1); });
        }

        [Test]
        public void Coordenada_X_Asignada_DebeSerMayorQue0()
        {
            Coordenada test = new(1, 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => { test.X = 0; });
        }

        [Test]
        public void Coordenada_X_Asignada_DebeSerPositiva()
        {
            Coordenada test = new(1, 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => { test.X = -1; });
        }

        [Test]
        public void Coordenada_Y_Asignada_DebeSerMayorQue0()
        {
            Coordenada test = new(1, 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => { test.Y = 0; });
        }

        [Test]
        public void Coordenada_Y_Asignada_DebeSerPositiva()
        {
            Coordenada test = new(1, 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => { test.Y = -1; });
        }

        [Test]
        public void Coordenada_X_DebeDevolverElValorInicializado()
        {
            // Arrange
            int initialValue = 1;

            // Act
            Coordenada test = new(initialValue, 1);
            int x = test.X;

            // Assert
            Assert.That(x, Is.EqualTo(initialValue));
        }

        [Test]
        public void Coordenada_Y_DebeDevolverElValorInicializado()
        {
            // Arrange
            int initialValue = 1;

            // Act
            Coordenada test = new(1, initialValue);
            int y = test.Y;

            // Assert
            Assert.That(y, Is.EqualTo(initialValue));
        }

        [Test]
        public void Coordenada_X_DebeDevolverElValorSeteado()
        {
            // Arrange                        
            int settedValue = 1;
            Coordenada test = new(10, 10);

            // Act
            test.X = settedValue;
            int x = test.X;

            // Assert
            Assert.That(x, Is.EqualTo(settedValue));
        }

        [Test]
        public void Coordenada_Y_DebeDevolverElValorSeteado()
        {
            // Arrange            
            int settedValue = 1;
            Coordenada test = new(10, 10);

            // Act
            test.Y = settedValue;
            int y = test.Y;

            // Assert
            Assert.That(y, Is.EqualTo(settedValue));
        }

        [Test]
        public void Coordenada_ToString_DebeDevolverParentesisInicioYFin()
        {
            // Arrange
            Coordenada test = new(10, 10);

            // Act
            string res = test.ToString();

            // Assert
            Assert.Multiple(() =>
            {                
                Assert.That(res, Does.StartWith("("));
                Assert.That(res, Does.EndWith(")"));
            });
        }

        [Test]
        public void Coordenada_ToString_DebeContenerUnaComa()
        {
            // Arrange
            Coordenada test = new(10, 10);

            // Act
            string res = test.ToString();

            // Assert
            Assert.That(res, Does.Contain(","));            
        }

        [Test]
        public void Coordenada_ToString_DebeFormarCorrectamenteElLiteral()
        {
            // Arrange
            Coordenada test = new(5, 6);

            // Act
            string res = test.ToString();

            // Assert
            Assert.That(res, Is.EqualTo("(5,6)"));
        }

        [Test]
        public void Coordenada_Clone_DevuelveNuevaInstanciaConMismosValores()
        {
            // Arrange
            Coordenada coordenada = new(3, 4);

            // Act
            Coordenada clonedCoordenada = coordenada.Clone();

            // Assert
            Assert.That(clonedCoordenada, Is.Not.SameAs(coordenada));
            Assert.That(clonedCoordenada.X, Is.EqualTo(coordenada.X));
            Assert.That(clonedCoordenada.Y, Is.EqualTo(coordenada.Y));
        }
    }
}

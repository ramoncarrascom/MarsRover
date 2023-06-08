using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test.Models
{
    public class InstruccionesTest
    {
        [Test]
        public void Instrucciones_ConstruccionConCadenaVacia_DebeLanzarExcepcion()
        {
            // Arrange
            string ordenes = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Instrucciones(ordenes));
        }

        [Test]
        public void Instrucciones_ConstruccionConCaracteresNoPermitidos_DebeLanzarExcepcion()
        {
            // Arrange
            string ordenes = "LMMRX";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Instrucciones(ordenes));
        }

        [Test]
        public void Instrucciones_SiguienteOrden_PosicionAumentaCorrectamente()
        {
            // Arrange
            string ordenes = "LMR";
            Instrucciones instrucciones = new(ordenes);

            // Act
            char? orden1 = instrucciones.SiguienteOrden();
            char? orden2 = instrucciones.SiguienteOrden();
            char? orden3 = instrucciones.SiguienteOrden();

            // Assert
            Assert.Multiple(() =>
            {                
                Assert.That(orden1, Is.EqualTo('L'));
                Assert.That(orden2, Is.EqualTo('M'));
                Assert.That(orden3, Is.EqualTo('R'));
            });
        }

        [Test]
        public void Instrucciones_SiguienteOrden_FinDeCadenaRetornaNull()
        {
            // Arrange
            string ordenes = "L";
            Instrucciones instrucciones = new(ordenes);

            // Act
            char? orden1 = instrucciones.SiguienteOrden();
            char? orden2 = instrucciones.SiguienteOrden();
            Assert.Multiple(() =>
            {

                // Assert
                Assert.That(orden1, Is.EqualTo('L'));
                Assert.That(orden2, Is.Null);
            });
        }

        [Test]
        public void Instrucciones_Restablecer_PosicionSeRestableceCorrectamente()
        {
            // Arrange
            string ordenes = "LMLM";
            Instrucciones instrucciones = new(ordenes);

            // Act
            instrucciones.SiguienteOrden();
            instrucciones.SiguienteOrden();
            instrucciones.Restablecer();
            char? orden = instrucciones.SiguienteOrden();

            // Assert
            Assert.That(orden, Is.EqualTo('L'));            
        }

        [Test]
        public void Instrucciones_ConstruccionConCadenaEnMinuscula_ResultadoEnMayuscula()
        {
            // Arrange
            string ordenes = "lmrm";

            // Act
            Instrucciones instrucciones = new(ordenes);
            char? orden = instrucciones.SiguienteOrden();

            // Assert
            Assert.That(orden, Is.EqualTo('L'));
        }

    }
}

using LibreriaTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTesting
{
    [TestFixture]
    public class OperacionNUnitTest
    {
        [Test]
        public void SumarNumeros_InputDosNumeros_GetValorCorrecto()
        {
            // Arrange (La inicialización de los objetos y la definición de los valores de prueba)
            Operacion operacion = new Operacion();
            int numero1 = 5;
            int numero2 = 3;
            int resultadoEsperado = 8;

            // Act (La ejecución del método que se va a probar)
            int resultadoActual = operacion.SumarNumeros(numero1, numero2);

            // Assert (La verificación de que el resultado es el esperado)
            Assert.That(resultadoActual, Is.EqualTo(resultadoEsperado));

        }
    }
}

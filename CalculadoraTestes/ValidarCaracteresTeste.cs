using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidarCaracteresTeste
    {
        private ContarCaracteres _contar;

        public ValidarCaracteresTeste()
        {
            _contar = new ContarCaracteres();  
        }
        [Fact]
        public void DeveContarQuantosCaracteresTemNoTexto()
        {
            //Arrenge
            string texto = "Luiz";

            //Act
            int resultado = _contar.ContarStrings(texto);

            //Assert
            Assert.Equal(4, resultado);
        }
    }
}
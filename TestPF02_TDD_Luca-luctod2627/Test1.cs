
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PF02_TDD_Luca_luctod2627;

namespace TestPF02_TDD_Luca_luctod2627
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Factorial_NumeroNegativo_DevuelveMenosUno()
        {
            Funciones funciones = new Funciones();
            Assert.AreEqual(-1L, funciones.CalcularFactorial(-3));
        }

        [TestMethod]
        public void Factorial_Cero_DevuelveUno()
        {
            Funciones funciones = new Funciones();
            Assert.AreEqual(1L, funciones.CalcularFactorial(0));
        }

        [TestMethod]
        public void Factorial_NumeroPositivo_DevuelveResultadoCorrecto()
        {
            Funciones funciones = new Funciones();
            Assert.AreEqual(120L, funciones.CalcularFactorial(5));
        }
        [TestMethod]
        public void Contrasenya_Nula_DevuelveFalse()
        {
            Funciones funciones = new Funciones();
            Assert.IsFalse(funciones.EsContrasenyaValida(null));
        }

        [TestMethod]
        public void Contrasenya_Vacia_DevuelveFalse()
        {
            Funciones funciones = new Funciones();
            Assert.IsFalse(funciones.EsContrasenyaValida(""));
        }

        [TestMethod]
        public void Contrasenya_MenosDeOchoCaracteres_DevuelveFalse()
        {
            Funciones funciones = new Funciones();
            Assert.IsFalse(funciones.EsContrasenyaValida("abc#123"));
        }

        [TestMethod]
        public void Contrasenya_SinAlmohadilla_DevuelveFalse()
        {
            Funciones funciones = new Funciones();
            Assert.IsFalse(funciones.EsContrasenyaValida("abcdefgh"));
        }

        [TestMethod]
        public void Contrasenya_Valida_DevuelveTrue()
        {
            Funciones funciones = new Funciones();
            Assert.IsTrue(funciones.EsContrasenyaValida("abcde#123"));
        }
    }
}

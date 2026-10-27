
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
    }
}

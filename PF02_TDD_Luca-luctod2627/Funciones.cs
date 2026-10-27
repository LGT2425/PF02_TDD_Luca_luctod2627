using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF02_TDD_Luca_luctod2627
{
    public class Funciones
    {
        public long CalcularFactorial(int n)
        {
            if (n < 0)
                return -1;

            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
        public bool EsContrasenyaValida(string contrasenya)
        {
            if (contrasenya == null || contrasenya == "")
            {
                return false;
            }

            if (contrasenya.Length < 8)
            {
                return false;
            }

            if (!contrasenya.Contains("#"))
            {
                return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<string>(); 
        }
        public int somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;

            listaHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;

        }
        public int subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;

            listaHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;
        }
        public int multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;

            listaHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;
        }
        public int dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;

            listaHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;
        }
        public List<string> Historico()
        {
            List<string> lista;

            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAndroid.Model
{
    public class Calculadora
    {
        public Double PrimeiroValor { get; set; }
        public Double SegundoValor { get; set; }
        public String Operacao { get; set; }
        public Double Resultado { get; set; }
        public IList<string> Operacoes { get; set; }
    }
}

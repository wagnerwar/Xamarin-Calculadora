using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TesteAndroid.Model;
using Xamarin.Forms;

namespace TesteAndroid.ViewModel
{
    public class CalculadoraViewModel : BaseViewModel
    {
        public ICommand CalcularCommand { get; private set; }
        public Calculadora calculadora { get; set; }
        public CalculadoraViewModel()
        {
            CalcularCommand = new Command<string>(Calcular);
            this.calculadora = new Calculadora();
            this.CarregarOperacoesDisponiveis();
        }

        public Double PrimeiroValor { 
            get {
                return calculadora.PrimeiroValor;
            } set {                
                calculadora.PrimeiroValor = value;
                OnPropertyChanged();
            }
        }

        public Double SegundoValor
        {
            get
            {
                return calculadora.SegundoValor;
            }
            set
            {                
                calculadora.SegundoValor = value;
                OnPropertyChanged();
            }
        }

        public String Operacao
        {
            get
            {
                return calculadora.Operacao;
            }
            set
            {                
                calculadora.Operacao = value;
                OnPropertyChanged();
            }
        }

        public Double Resultado
        {
            get
            {
                return calculadora.Resultado;
            }
            set
            {                
                calculadora.Resultado = value;
                OnPropertyChanged();
            }
        }
        public IList<string> OperacoesDisponiveis
        {
            get
            {
                return calculadora.Operacoes;
            }
        }
        private void CarregarOperacoesDisponiveis()
        {
            this.calculadora.Operacoes = new List<string>();
            this.calculadora.Operacoes.Add("+");
            this.calculadora.Operacoes.Add("-");
            this.calculadora.Operacoes.Add("*");
            this.calculadora.Operacoes.Add("/");
        }
        void Calcular(string obj)
        {
            switch (this.Operacao)
            {
                case "+":
                    this.Resultado = this.PrimeiroValor + this.SegundoValor;
                    break;
                case "-":
                    this.Resultado = this.PrimeiroValor - this.SegundoValor;
                    break;
                case "*":
                    this.Resultado = this.PrimeiroValor * this.SegundoValor;
                    break;
                case "/":
                    this.Resultado = this.PrimeiroValor / this.SegundoValor;
                    break;
                default:
                    break;
            }            
            MessagingCenter.Send<MainPage>(new MainPage(), "AlterarResultado");
        }
    }
}

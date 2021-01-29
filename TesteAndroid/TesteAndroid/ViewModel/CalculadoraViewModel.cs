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
        public ICommand MaisCommand { get; private set; }
        public Calculadora calculadora { get; set; }
        public CalculadoraViewModel()
        {
            MaisCommand = new Command<string>(Mais);        
        }

        public Double PrimeiroValor { 
            get {
                return calculadora.PrimeiroValor;
            } set {
                OnPropertyChanged();
                calculadora.PrimeiroValor = value;
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
                OnPropertyChanged();
                calculadora.SegundoValor = value;
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
                OnPropertyChanged();
                calculadora.Operacao = value;
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
                OnPropertyChanged();
                calculadora.Resultado = value;
            }
        }

        void Mais(string obj)
        {
            calculadora.Resultado = calculadora.PrimeiroValor + calculadora.SegundoValor;
            MessagingCenter.Send<MainPage>(new MainPage(), "AlterarResultado");
        }
    }
}

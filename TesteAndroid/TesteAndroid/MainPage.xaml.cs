using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TesteAndroid.ViewModel;

namespace TesteAndroid
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new CalculadoraViewModel();

            // Assinando mensagem
            MessagingCenter.Subscribe<MainPage>(this, "AlterarResultado", (sender) =>
            {
                DisplayAlert("Cálculo feito", "Cálculo feito", "OK");
            });
        }

        private void Mais_Clicked(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                Double resultado, primeiro_valor, segundo_valor;
                primeiro_valor = Double.Parse(PrimeiroValor.Text);
                segundo_valor = Double.Parse(SegundoValor.Text);
                resultado = primeiro_valor + segundo_valor;
                Resultado.Text = resultado.ToString();
            }
            catch(Exception ex)
            {
                DisplayAlert("Erro!", "Tente novamente mais tarde!", "OK");
            }            
        }

        private void Menos_Clicked(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                Double resultado, primeiro_valor, segundo_valor;
                primeiro_valor = Double.Parse(PrimeiroValor.Text);
                segundo_valor = Double.Parse(SegundoValor.Text);

                if(segundo_valor > primeiro_valor)
                {
                    DisplayAlert("Erro!", "Primeiro valor deve ser maior do que o segundo valor", "OK");
                }

                resultado = primeiro_valor - segundo_valor;
                Resultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", "Tente novamente mais tarde!", "OK");
            }
        }

        private void Multiplicacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                Double resultado, primeiro_valor, segundo_valor;
                primeiro_valor = Double.Parse(PrimeiroValor.Text);
                segundo_valor = Double.Parse(SegundoValor.Text);
                resultado = primeiro_valor * segundo_valor;
                Resultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", "Tente novamente mais tarde!", "OK");
            }
        }

        private void Divisao_Clicked(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                Double resultado, primeiro_valor, segundo_valor;
                primeiro_valor = Double.Parse(PrimeiroValor.Text);
                segundo_valor = Double.Parse(SegundoValor.Text);
                resultado = primeiro_valor / segundo_valor;
                Resultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", "Tente novamente mais tarde!", "OK");
            }
        }

        private void ValidarCampos()
        {
            if(String.IsNullOrEmpty(PrimeiroValor.Text) || String.IsNullOrEmpty(SegundoValor.Text))
            {
                throw new Exception("Valores devem estar preenchidos");
            }
        }
    }
}

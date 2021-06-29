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
    }
}

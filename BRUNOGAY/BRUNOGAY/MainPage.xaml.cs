using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BRUNOGAY
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txt_altura.Text);
            double peso = Convert.ToDouble(txt_peso.Text);

            Console.WriteLine("AQUI =====================", altura, peso);

            double imc = peso / (altura * altura);

            await DisplayAlert("Resultado ", "Seu IMC é:" + imc + " ,Sua classificação é magreza", "OK");

            if (imc < 18.5)
            {
                await DisplayAlert("Resultado ", "Seu IMC é:" + imc.ToString("0.00") + " ,Sua classificação é magreza", "OK");
                zerar();

            }
            if (imc > 18.5 && imc < 24.9)
            {
                await DisplayAlert("Resultado ", "Seu IMC é:" + imc.ToString("0.00") + " ,Sua classificação é Normal", "OK");
                zerar();
            }

            if (imc > 25.0 && imc < 29.9)
            {
                await DisplayAlert("Resultado ", "Seu IMC é:" + imc.ToString("0.00") + " ,Sua classificação é Sobrepeso", "OK");
                zerar();
            }

            if (imc > 30.0 && imc < 34.9)
            {
                await DisplayAlert("Resultado ", "Seu IMC é:" + imc.ToString("0.00") + " ,Sua classificação é Obesidade Grau 1", "OK");
                zerar();
            }


            if (imc > 35.0 && imc < 39.9)
            {
                await DisplayAlert("Resultado ", "Seu IMC é:" + imc.ToString("0.00") + " ,Sua classificação é Obesidade Grau 2", "OK");
                zerar();
            }

            if (imc >= 40.0)
            {
                await DisplayAlert("Resultado ", "Seu IMC é:" + imc.ToString("0.00") + " ,Sua classificação é Obesidade Mórbida", "OK");
                zerar();
            }






            void zerar()
            {
                txt_peso.Text = "";
                txt_altura.Text = "";
            }
      
        }

    }
}

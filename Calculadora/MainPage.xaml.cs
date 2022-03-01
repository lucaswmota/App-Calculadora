using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {

        double resultado, numero1, numero2;

        public MainPage()
        {

            InitializeComponent();
        }

        void mostrarResultado()
        {
            entResultado.Text = resultado.ToString();

            int red = 0, green = 0, blue = 0;

            Random randomizer = new Random();

            red = randomizer.Next(255);
            green = randomizer.Next(255);
            blue = randomizer.Next(255);

            Color randomColor = Color.FromRgb(red, green, blue);

            cabecalho.BackgroundColor = randomColor;
        }

        void entraDados()
        {
            try
            {
                numero1 = double.Parse(entNumero1.Text);
                numero2 = double.Parse(entNumero2.Text);
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", "Valor Invalido " + ex.Message, "OK");
            }
        }

        private void btnSoma_Clicked(object sender, EventArgs e)
        {
            entraDados();

            resultado = numero1 + numero2;

            mostrarResultado();
        }

        private void btnSubtracao_Clicked(object sender, EventArgs e)
        {
            entraDados();

            resultado = numero1 - numero2;

            mostrarResultado();
        }

        private void btnMultiplicacao_Clicked(object sender, EventArgs e)
        {
            entraDados();

            resultado = numero1 * numero2;

            mostrarResultado();
        }

        private void btnDivisao_Clicked(object sender, EventArgs e)
        {
            entraDados();

            resultado = numero1 / numero2;

            mostrarResultado();
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            entNumero1.Text = "";
            entNumero2.Text = "";
            entResultado.Text = "";
        }

        private void btnFechar_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

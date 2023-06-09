using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppEjercicio1_1
{
    public partial class MainPage : ContentPage
    {
        public float Num1 { get; set; } = 0;
        public float Num2 { get; set; } = 0;

        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                await this.Navigation.PushAsync(
                    new Resultado(
                        $"La suma de {txtnumero1.Text} + {txtnumero2.Text} es: ",
                         Num1 + Num2)
                );
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                await this.Navigation.PushAsync(
                    new Resultado(
                        $"La resta de {txtnumero1.Text} - {txtnumero2.Text} es: ",
                         Num1 - Num2)
                );
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                await this.Navigation.PushAsync(
                    new Resultado(
                        $"La division de {txtnumero1.Text} / {txtnumero2.Text} es: ",
                         Num1 / Num2)
                );
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
        }

        private async void btnmultipl_Clicked(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                await this.Navigation.PushAsync(
                    new Resultado(
                        $"La multiplicacion de {txtnumero1.Text} * {txtnumero2.Text} es: ",
                         Num1 * Num2)
                );
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtnumero1.Text) && string.IsNullOrWhiteSpace(txtnumero2.Text))
            {
                DisplayAlert("Error", "Por favor completa ambos campos", "OK");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtnumero1.Text))
            {
                DisplayAlert("Error", "Por favor ingresa un valor en el primer campo", "OK");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtnumero2.Text))
            {
                DisplayAlert("Error", "Por favor ingresa un valor en el segundo campo", "OK");
                return false;
            }

            return true;
        }


    }
}

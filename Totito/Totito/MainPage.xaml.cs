using System;
using Xamarin.Forms;

namespace Totito
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Messaging, string>(this, "Message", async (s, a) => {
                await DisplayAlert("Mensaje", a.ToString(), "Cancelar");
            });
        }


        private async void BtnGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Totito());
        }

        private async void BtnNavigation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Totito());
        }

        private async void BtnAnimacion_Clicked(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            await boton.ScaleTo(2, 500, Easing.CubicInOut);
            //await boton.RotateTo(90, 2000, Easing.CubicOut);
            await boton.ScaleTo(1, 500, Easing.BounceOut);
        }

        private async void BtnAlert_Clicked(object sender, EventArgs e)
        {
            bool res = await DisplayAlert("Alerta", "¿Está seguro?", "Sí", "No");
        }

        private async void BtnOptions_Clicked(object sender, EventArgs e)
        {
            string[] opciones = { "Flauta", "Violín", "Piano" };
            string res = await DisplayActionSheet("Opciones", "Cancelar", "Destruir", opciones);
            await DisplayAlert("Resultado", res, "OK");
        }

        private async void BtnMessaging_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Messaging());
        }

        private async void BtnModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Totito());
        }

        private async void BtnReloj_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Reloj());
        }

        private async void BtnDiscografia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Discografia());
        }
    }
}


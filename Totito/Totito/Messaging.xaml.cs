using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Totito
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Messaging : ContentPage
    {
        public Messaging()
        {
            InitializeComponent();
        }

        private async void BtnSendMenssage_Clicked(object sender, EventArgs e)
        {            
            MessagingCenter.Send<Messaging, string>(this, "Message", "Hola");
            await Navigation.PopAsync();
        }
    }
}
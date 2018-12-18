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
	public partial class Totito : ContentPage
	{
        bool turno;
		public Totito ()
		{
            InitializeComponent();
            
            for (int i = 0; i < 3; i++) //columna
            {
                for (int j = 0; j < 3; j++) //fila
                {
                    //se crea el botón
                    Button btn = new Button();
                    btn.BackgroundColor = Color.White;
                    btn.BorderColor = Color.Black;

                    //se agrega el manejador del evento click
                    btn.Clicked += Button_Clicked;

                    //se agrega el botón al grid y se coloca en la celda apropiada
                    MainGrid.Children.Add(btn);
                    Grid.SetColumn(btn, i);
                    Grid.SetRow(btn, j);
                }
            }
            turno = false;    
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button boton = (sender as Button);

            Color color = Color.White;

            //se selecciona el color a mostrar en el cuadro en base al jugador en turno 
            //(Jugador 1: AZUL, jugador 2: AMARILLO)            
            if (boton.BackgroundColor.Equals(Color.White))
                color = turno ? Color.Yellow : Color.Blue;

            //se aplica el color al botón
            boton.BackgroundColor = color;

            //se cambia de turno
            turno = !turno;
        }
    }
}
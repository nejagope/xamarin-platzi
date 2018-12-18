using System;
using System.Collections.Generic;
using System.Text;

namespace Totito
{
    public class Disco: NotificationObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; OnPropertyChanged(); }
        }

        private string banda;

        public string Banda
        {
            get { return banda; }
            set { banda = value; OnPropertyChanged(); }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; OnPropertyChanged(); }
        }

        private string portada;

        public string Portada
        {
            get { return portada; }
            set { portada = value; OnPropertyChanged(); }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; OnPropertyChanged(); }
        }


    }
}

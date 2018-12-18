using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Totito
{
    public class DatosDiscos: NotificationObject
    {
        private ObservableCollection<Disco> discos;

        public ObservableCollection<Disco> Discos
        {
            get { return discos; }
            set {
                discos = value;
                OnPropertyChanged();
            }
        }

        public DatosDiscos()
        {
            Discos = new ObservableCollection<Disco>
            {
                new Disco()
                {
                    Banda = "Metallica",
                    Fecha = new DateTime(1986, 3, 3),
                    Nombre = "Master of Puppets",
                    Portada = "Master",
                    Precio = 5
                },

                new Disco()
                {
                    Banda = "Metallica",
                    Fecha = new DateTime(1984, 7, 27),
                    Nombre = "Ride the Lightning",
                    Portada = "Lightning",
                    Precio = 10
                }
            };
        }

    }
}

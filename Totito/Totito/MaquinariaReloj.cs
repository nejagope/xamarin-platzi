using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Totito
{
    class MaquinariaReloj: NotificationObject
    {
        private int horas;

        public int Horas
        {
            get { return horas; }
            set {
                horas = value;
                OnPropertyChanged();
            }
        }


        private int minutos;

        public int Minutos
        {
            get { return minutos; }
            set {
                minutos = value;
                OnPropertyChanged();
            }
        }

        private int segundos;

        public int Segundos
        {
            get { return segundos; }
            set {
                segundos = value;
                OnPropertyChanged();
            }
        }

        public MaquinariaReloj()
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Segundos < 59)
                Segundos++;
            else
            {
                Segundos = 0;

                if (Minutos < 59)
                    Minutos++;
                else
                {
                    Minutos = 0;
                    Horas++;
                }
            }
                
        }
    }
}

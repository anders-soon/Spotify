using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaElementos
    {
        public List<Elemento> _elementos { get; set; }

        public ListaElementos()
        {
            _elementos = new List<Elemento>();
            LoadElements();

        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento
            {
                Nombre = "Yandel",
                Descripcion = "Tu Cama,Tu olor, Tu mirada"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "Enrique Iglesias",
                Descripcion = "Cama, Cuando me Enamoro, Juntos"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "Ricardo Arjona",
                Descripcion = "Mujeres, Amor, Taxi"
            });
            _elementos.Add(new Elemento
            {
                Nombre = "Beky G",
                Descripcion = "Take Shower ,Dura, Manos Arriba"
            });
            _elementos.Add(new Elemento
            {
                Nombre = "Carol G",
                Descripcion = "Tu cama, Ven pa Ca, No te Vayas"
            });
        }
    }

}




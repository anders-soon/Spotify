using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify
{
    public class Elemento4
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaElementos4
    {
        public List<Elemento4> _elementos { get; set; }

        public ListaElementos4()
        {
            _elementos = new List<Elemento4>();
            LoadElements();

        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento4
            {
                Nombre = "X",
                Descripcion = "Niki Jam"
            });
            _elementos.Add(new Elemento4
            {
                Nombre = "Despacito",
                Descripcion = "Luis Fonsi"
            });
            _elementos.Add(new Elemento4
            {
                Nombre = "Mujeres",
                Descripcion = "Ricardo Arjona"
            });
            _elementos.Add(new Elemento4
            {
                Nombre = "Take Shower",
                Descripcion = "Becy G"
            });
            _elementos.Add(new Elemento4
            {
                Nombre = "Prince Roy",
                Descripcion = "Darte un Beso"
            });





        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify
{
    public class Elemento3
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaElementos3
    {
        public List<Elemento3> _elementos { get; set; }

        public ListaElementos3()
        {
            _elementos = new List<Elemento3>();
            LoadElements();

        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento3
            {
                Nombre = "Billboard Hot 100",
                Descripcion = "por Billboard (Nielsen)"
            });
            _elementos.Add(new Elemento3
            {
                Nombre = "Top 100 Tracks Currently on Spotify",
                Descripcion = "por Spotify"
            });
            _elementos.Add(new Elemento3
            {
                Nombre = "Hipster International",
                Descripcion = "por Sean Parker"
            });
            _elementos.Add(new Elemento3
            {
                Nombre = "'90s SMASH HITS!",
                Descripcion = "por Filtr US"
            });
            _elementos.Add(new Elemento3
            {
                Nombre = "Weekly Top 40 Country",
                Descripcion = "por Chad Krivanec"
            });



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify
{
    public class Elemento2
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaElementos2
    {
        public List<Elemento2> _elementos { get; set; }

        public ListaElementos2()
        {
            _elementos = new List<Elemento2>();
            LoadElements();

        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento2
            {
                Nombre = "Thriller",
                Descripcion = "Artista: Michael Jackson"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "Back in Black",
                Descripcion = "Artista: ACDC"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "The Dark Side Of The Moon",
                Descripcion = "Artista: Pink Floyd"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "The Bodyguard",
                Descripcion = "Artista: Whitney Houston"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "Their Greatest Hits",
                Descripcion = "Artista: The Eagles"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "Rumours",
                Descripcion = "Artista: Fletwood Mac"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "Saturday Night Fever",
                Descripcion = "Artista: Bee Gees y varios artistas"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "El fantasma de la ópera",
                Descripcion = "Artista: Andrew Lloyd Webber"
            });
            _elementos.Add(new Elemento2
            {
                Nombre = "Led Zeppelin IV",
                Descripcion = "Artista: Led Zeppelin"
            });


        }
    }
}

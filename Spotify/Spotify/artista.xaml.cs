using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spotify
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class artista : ContentPage
	{

		public artista ()
		{
			InitializeComponent ();

		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos elementos = new ListaElementos();
            ListElemets.ItemsSource = elementos._elementos;
        }



    }
}
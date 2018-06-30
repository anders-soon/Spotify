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
	public partial class play : ContentPage
	{
		public play ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos3 elementos = new ListaElementos3();
            ListElemets3.ItemsSource = elementos._elementos;
        }
    }
}
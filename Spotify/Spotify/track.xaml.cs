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
	public partial class track : ContentPage
	{
		public track ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos4 elementos = new ListaElementos4();
            ListElemets4.ItemsSource = elementos._elementos;
        }
    }
}
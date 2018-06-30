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
	public partial class album : ContentPage
	{
		public album ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos2 elementos = new ListaElementos2();
            ListElemets2.ItemsSource = elementos._elementos;
        }
    }
}
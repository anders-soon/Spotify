using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Spotify
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

        }

        private  void artista_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new artista());

        }

        private void album_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new album());
        }

        private void play_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new play());
        }

        private void track_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new track());
        }
    }
}

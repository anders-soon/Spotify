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
	public partial class login : ContentPage
	{
		public login ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (usuario.Text != "admin" || contraseña.Text != "123")
            {
                DisplayAlert("Error", "Datos Incorrectos", "OK");
                usuario.Text = "";
                contraseña.Text = "";

            }
            else
            {

                ((NavigationPage)this.Parent).PushAsync(new MainPage());

                usuario.Text = "";
                contraseña.Text = "";
            }

        }
    }
}
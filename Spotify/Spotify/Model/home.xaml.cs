﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spotify.Model
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class home : ContentPage
	{
		public home ()
		{
			InitializeComponent ();
		}
	}
}